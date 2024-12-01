using System;
using System.Runtime.Serialization;

namespace iText.Kernel.Pdf
{
    [Serializable]
    internal class PdfException : Exception
    {
        public PdfException()
        {
        }

        public PdfException(string message) : base(message)
        {
        }

        public PdfException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected PdfException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}