using Xunit;
using Tools; // Make sure to use the correct namespace for your project
using System;
using System.IO;
using iText.Kernel.Pdf;
using iText.Layout;
using System.Text;

namespace PdfLockerTests
{
    public class PasswordGeneratorTests
    {
        private Random _random = new Random();

        // Generate a random length between 8 and 16 characters
        private int GenerateRandomLength() => _random.Next(8, 17);

        // Randomly choose whether a character type should be included
        private bool GetRandomBoolean() => _random.Next(2) == 0;

        [Fact]
        public void TestGeneratePasswordWithRandomLength()
        {
            // Arrange
            int length = GenerateRandomLength();
            var passwordGenerator = new PasswordGenerator();

            // Act
            string generatedPassword = passwordGenerator.GeneratePwd(length, true, true, true, true);

            // Assert
            Assert.Equal(length, generatedPassword.Length);  // Check that the generated password has the correct length
        }

        [Fact]
        public void TestGeneratePwdContainUppercase()
        {
            // Arrange
            int length = GenerateRandomLength();
            bool includeUppercase = GetRandomBoolean();
            var passwordGenerator = new PasswordGenerator();

            // Act
            string generatedPassword = passwordGenerator.GeneratePwd(length, includeUppercase, true, false, false);

            // Assert
            if (includeUppercase)
                Assert.Contains(generatedPassword, c => char.IsUpper(c)); // Check that there is an uppercase letter
        }

        [Fact]
        public void TestGeneratePwdContainLowercase()
        {
            // Arrange
            int length = GenerateRandomLength();
            bool includeLowercase = GetRandomBoolean();
            var passwordGenerator = new PasswordGenerator();

            // Act
            string generatedPassword = passwordGenerator.GeneratePwd(length, includeLowercase, false, false, false);

            // Assert
            if (includeLowercase)
                Assert.Contains(generatedPassword, c => char.IsLower(c)); // Check that there is a lowercase letter
        }

        [Fact]
        public void TestGeneratePwdContainNumbers()
        {
            // Arrange
            int length = GenerateRandomLength();
            bool includeNumbers = GetRandomBoolean();
            var passwordGenerator = new PasswordGenerator();

            // Act
            string generatedPassword = passwordGenerator.GeneratePwd(length, false, false, includeNumbers, false);

            // Assert
            if (includeNumbers)
                Assert.Contains(generatedPassword, c => char.IsDigit(c)); // Check that there is a digit
        }

        [Fact]
        public void GeneratePwd_ShouldContainSymbols()
        {
            // Arrange
            int length = GenerateRandomLength();
            bool includeSymbols = GetRandomBoolean();
            var passwordGenerator = new PasswordGenerator();

            // Act
            string generatedPassword = passwordGenerator.GeneratePwd(length, false, false, false, includeSymbols);

            // Assert
            if (includeSymbols)
                Assert.Contains(generatedPassword, c => !char.IsLetterOrDigit(c)); // Check that there is a symbol
        }
    }

    public class PdfManagerTests
    {
        // Method to create an empty PDF
        public void CreateEmptyPdf(string outputFilePath)
        {
            using (var writer = new PdfWriter(outputFilePath))
            {
                using (var pdf = new PdfDocument(writer))
                {
                    var document = new Document(pdf);
                    // Empty PDF, nothing added
                }
            }
        }

        // Method to generate a temporary file path for the PDF
        private string GenerateTempPdfPath(string prefix)
        {
            return Path.Combine(Path.GetTempPath(), prefix + Guid.NewGuid().ToString() + ".pdf");
        }

        [Fact]
        public void TestLockPdf()
        {
            // Arrange
            string inputFilePath = GenerateTempPdfPath("empty_pdf_");  // Generate a temporary path for the empty PDF
            string outputFilePath = GenerateTempPdfPath("locked_");
            string password = "TestPassword";

            // Create an empty PDF for the test
            CreateEmptyPdf(inputFilePath);

            var pdfManager = new PDFManager();

            // Act: Lock the PDF with a password
            bool isLocked = pdfManager.LockPDF(inputFilePath, outputFilePath, password);
            Assert.True(isLocked, "The locked file was not created.");
        }

        [Fact]
        public void TestUnLockPdf()
        {
            // Arrange
            string inputFilePath = GenerateTempPdfPath("empty_pdf_");  // Generate a temporary path for the empty PDF
            string outputFilePath = GenerateTempPdfPath("locked_");
            string password = "TestPassword";

            // Create an empty PDF for the test
            CreateEmptyPdf(inputFilePath);

            var pdfManager = new PDFManager();

            // Act: Lock the PDF with a password
            bool isLocked = pdfManager.LockPDF(inputFilePath, outputFilePath, password);
            Assert.True(isLocked, "The locked file was not created.");
            bool isUnLocked = pdfManager.UnlockPdf(inputFilePath, outputFilePath, password);
            Assert.True(isUnLocked, "The locked file was not unlocked.");
        }
    }
}
