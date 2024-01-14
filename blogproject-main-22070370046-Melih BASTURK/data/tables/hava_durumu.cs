using System;
using System.Collections.Generic;

class Hava
{
    private int _id; //değişken 
      [Key] // birincil anahtar
    public int id { get; set; } // int türünde id değişkeni
    public string sehir { get; set; } //string türünde sehir adı
    public string durum { get; set; }  //string türünde durum
    public double sicaklik { get; set; } // double türünde sicaklik
    public int nem { get; set; } // int türünde nem miktarı
    public int tarih { get; set; } // int türünde tarih

}
