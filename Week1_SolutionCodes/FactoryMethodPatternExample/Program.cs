using System;

class Program
{
    static void Main(string[] args)
    {
        DocumentFactory factory = new DocumentFactory();

        IDocument word = factory.CreateDocument("word");
        word.Create();

        IDocument excel = factory.CreateDocument("excel");
        excel.Create();

        IDocument pdf = factory.CreateDocument("pdf");
        pdf.Create();

        //Exception handling for unknown document type
        IDocument unknown = factory.CreateDocument("unknown");
        unknown.Create();
    }
}