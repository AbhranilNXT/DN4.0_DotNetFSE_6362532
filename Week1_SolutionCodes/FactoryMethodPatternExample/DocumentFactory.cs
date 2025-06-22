using System;

public class DocumentFactory
{
    public IDocument CreateDocument(string type)
    {
        switch (type.ToLower())
        {
            case "word":
                return new WordDocument();
            case "pdf":
                return new PdfDocument();
            case "excel":
                return new ExcelDocument();
            default:
                throw new ArgumentException("Unknown document type: " + type);
        }
    }
}