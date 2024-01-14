using System;
using System.Collections.Generic;

class Ogrenci //öğrenci sınıfını tanımladık
{
    private int _numara; //değişken 
      [Key] 
    public int id { get; set; }// id değişkeni 
    public string ad { get; set; } //ad
    public string soyad { get; set; } // soyad
    public int numara { get; set; } // numara
    public string cinsiyet { get; set; } // cinsiyet
}
