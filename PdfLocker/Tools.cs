using System;
using System.Security.Cryptography;
using System.Text;
using iText.Kernel.Pdf;

namespace Tools
{
    // Class to generate a password with customizable criteria
    public class PasswordGenerator
    {
        // Function to generate a random password with a specified length and optional character sets
        public string GeneratePwd(int length = 12, bool includeLowercase = true, bool includeUppercase = true, bool includeDigits = true, bool includeSymbols = true)
        {
            // Ensure password length is greater than 0
            if (length <= 0)
                throw new ArgumentException("Password length should be superior than 0.");

            // Define possible character sets for the password
            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string digits = "1234567890";
            string symbols = "!@#$%^&*()-_+=[]{};:,.?/";

            // Build a string of valid characters based on user options
            StringBuilder validCharsBuilder = new StringBuilder();
            if (includeLowercase) validCharsBuilder.Append(lowercase);
            if (includeUppercase) validCharsBuilder.Append(uppercase);
            if (includeDigits) validCharsBuilder.Append(digits);
            if (includeSymbols) validCharsBuilder.Append(symbols);

            string validChars = validCharsBuilder.ToString();

            // Return an empty string if no valid characters are selected
            if (string.IsNullOrEmpty(validChars))
                return "";

            // Use RNGCryptoServiceProvider for cryptographically secure random number generation
            using (var rng = new RNGCryptoServiceProvider())
            {
                byte[] randomBytes = new byte[length];
                rng.GetBytes(randomBytes);

                // Build the password by selecting random characters from the valid characters string
                StringBuilder passwordBuilder = new StringBuilder(length);
                foreach (byte b in randomBytes)
                {
                    passwordBuilder.Append(validChars[b % validChars.Length]);
                }

                // Return the generated password
                return passwordBuilder.ToString();
            }
        }
    }

    // Class to handle PDF operations like locking and unlocking
    public class PDFManager
    {
        // Method to lock a PDF with a password and create a protected copy
        public bool LockPDF(string inputPath, string outputPath, string password)
        {
            try
            {
                PdfReader reader = new PdfReader(inputPath);

                PdfWriter writer = new PdfWriter(outputPath, new WriterProperties()
                    .SetStandardEncryption(
                        Encoding.UTF8.GetBytes(password),
                        Encoding.UTF8.GetBytes(password),
                        EncryptionConstants.ALLOW_PRINTING,
                        EncryptionConstants.ENCRYPTION_AES_256
                    ));

                using (PdfDocument pdfDoc = new PdfDocument(reader, writer))
                {
                    pdfDoc.Close();
                }

                return true; // Return true if no exception occurs, indicating success
            }
            catch (Exception)
            {
                return false; // Return false if an exception occurs, indicating failure
            }
        }


        // Method to unlock a protected PDF and save it as a new unprotected copy
        public bool UnlockPdf(string inputPath, string outputPath, string password)
        {
            try
            {
                PdfReader reader = new PdfReader(inputPath, new ReaderProperties()
                    .SetPassword(Encoding.UTF8.GetBytes(password)))
                    .SetUnethicalReading(true);

                PdfWriter writer = new PdfWriter(outputPath);

                using (PdfDocument pdfDoc = new PdfDocument(reader, writer))
                {
                    pdfDoc.Close();
                }

                return true; // Return true if no exception occurs, indicating success
            }
            catch (Exception)
            {
                return false; // Return false if an exception occurs, indicating failure
            }
        }

    }
}
