using System;
using System.Collections.Generic;

class Okul //okul sınıfını tanımladık
{
    private int _id; //değişken
        [Key] //birincil anahtar
    public int id { get; set; }// id değişkeni 
    public string ad { get; set; } //ad
    public string adres { get; set; } //adres

}
