using GemBox.Document;
using System;
using System.IO;

namespace GemboxTest
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var stream = new FileStream("input.docx", FileMode.Open))
            {
                ComponentInfo.SetLicense(
                    "");
                DocumentModel document = DocumentModel.Load(stream, new DocxLoadOptions());
                document.Save("output.pdf");
            }
        }
    }
}
