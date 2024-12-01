using System;
using System.Security.Cryptography;
using System.Text;
using iText.Kernel.Pdf;

namespace Tools
{
    public class PasswordGenerator
    {
        // Fonction pour générer un mot de passe de longueur personnalisée
        public string GeneratePwd(int length = 12, bool includeLowercase = true, bool includeUppercase = true, bool includeDigits = true, bool includeSymbols = true)
        {
            if (length <= 0)
                throw new ArgumentException("La longueur du mot de passe doit être supérieure à 0.");

            // Définir les ensembles de caractères possibles
            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string digits = "1234567890";
            string symbols = "!@#$%^&*()-_+=[]{};:,.?/";

            // Construire la liste des caractères valides selon les critères
            StringBuilder validCharsBuilder = new StringBuilder();
            if (includeLowercase) validCharsBuilder.Append(lowercase);
            if (includeUppercase) validCharsBuilder.Append(uppercase);
            if (includeDigits) validCharsBuilder.Append(digits);
            if (includeSymbols) validCharsBuilder.Append(symbols);

            string validChars = validCharsBuilder.ToString();

            if (string.IsNullOrEmpty(validChars))
                return "";
                //throw new ArgumentException("Au moins une catégorie de caractères doit être incluse.");

            // Utiliser RNGCryptoServiceProvider pour générer des valeurs aléatoires
            using (var rng = new RNGCryptoServiceProvider())
            {
                byte[] randomBytes = new byte[length];
                rng.GetBytes(randomBytes);

                // Construire le mot de passe
                StringBuilder passwordBuilder = new StringBuilder(length);
                foreach (byte b in randomBytes)
                {
                    passwordBuilder.Append(validChars[b % validChars.Length]);
                }

                return passwordBuilder.ToString();
            }
        }
    }


    public class PDFManager
    {
        public void LockPDF(string inputPath, string outputPath, string password)
        {
            // Lire le fichier PDF d'entrée
            PdfReader reader = new PdfReader(inputPath);

            // Créer un fichier PDF de sortie avec la protection par mot de passe
            PdfWriter writer = new PdfWriter(outputPath, new WriterProperties()
                .SetStandardEncryption(
                    Encoding.UTF8.GetBytes(password),    // Mot de passe utilisateur
                    Encoding.UTF8.GetBytes(password),    // Mot de passe propriétaire
                    EncryptionConstants.ALLOW_PRINTING, // Permissions (exemple : autoriser l'impression)
                    EncryptionConstants.ENCRYPTION_AES_256 // Type de cryptage
                ));

            using (PdfDocument pdfDoc = new PdfDocument(reader, writer))
            {
                pdfDoc.Close(); // Clôturer le document pour finaliser l'écriture
            }
        }

        public void UnlockPdf(string inputPath, string outputPath, string password)
        {
            // Lire le fichier PDF protégé
            PdfReader reader = new PdfReader(inputPath, new ReaderProperties()
                .SetPassword(Encoding.UTF8.GetBytes(password))).SetUnethicalReading(true); // Mot de passe pour déchiffrer le PDF

            // Créer un fichier PDF de sortie sans protection
            PdfWriter writer = new PdfWriter(outputPath);

            using (PdfDocument pdfDoc = new PdfDocument(reader, writer))
            {
                // Copier tout le contenu du PDF d'entrée au PDF de sortie
                pdfDoc.Close(); // Clôturer le document pour finaliser l'écriture
            }
        }
    }
}
