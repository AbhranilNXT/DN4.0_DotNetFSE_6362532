package com.example.factorymethodpatternexample;

public class DocumentFactory {
    public Document createDocument(String type) {
        switch (type.toLowerCase()) {
            case "excel":
                return new ExcelDocument();
            case "word":
                return new WordDocument();
            case "pdf":
                return new PdfDocument();
            default:
                throw new IllegalArgumentException("Unknown document type: " + type);
        }
    }
}
