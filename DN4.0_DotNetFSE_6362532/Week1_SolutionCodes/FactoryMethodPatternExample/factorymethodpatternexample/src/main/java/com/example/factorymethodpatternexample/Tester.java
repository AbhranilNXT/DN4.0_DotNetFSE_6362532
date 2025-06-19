package com.example.factorymethodpatternexample;

public class Tester {
    public static void main(String[] args) {
        DocumentFactory factory = new DocumentFactory();
        Document word = factory.createDocument("word");
        word.create();
        Document excel = factory.createDocument("excel");
        excel.create();
        Document pdf = factory.createDocument("pdf");
        pdf.create();
        Document unknown = factory.createDocument("unknown"); // This will throw an exception
        unknown.create();
    }
}
