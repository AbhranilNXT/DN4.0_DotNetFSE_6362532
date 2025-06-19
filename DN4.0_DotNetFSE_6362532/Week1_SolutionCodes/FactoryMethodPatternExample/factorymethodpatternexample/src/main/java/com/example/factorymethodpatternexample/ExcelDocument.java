package com.example.factorymethodpatternexample;

class ExcelDocument implements Document {
    public void create() {
        System.out.println("Creating Excel document");
    }
}
