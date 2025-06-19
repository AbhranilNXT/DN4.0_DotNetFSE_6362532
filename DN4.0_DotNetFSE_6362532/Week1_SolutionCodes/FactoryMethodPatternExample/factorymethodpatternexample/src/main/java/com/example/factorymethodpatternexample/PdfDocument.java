package com.example.factorymethodpatternexample;

class PdfDocument implements Document {
    public void create() {
        System.out.println("Creating PDF document");
    }
}