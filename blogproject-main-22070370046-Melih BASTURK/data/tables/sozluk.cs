using System;
using System.Collections.Generic;

class sozluk //sözlük sınıfını tanımladık
{
    private int _id; //değişken 
      [Key] 
    public int id { get; set; }// id değişkeni 
    public string ing { get; set; } //ingilizce anlamı
    public string türkce { get; set; } // türkce anlamı

}
