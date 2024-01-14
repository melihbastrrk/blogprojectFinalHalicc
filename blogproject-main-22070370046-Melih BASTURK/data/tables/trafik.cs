using System;
using System.Collections.Generic;

class Trafik
{
    private int _id; //değişken 
      [Key] 
    public int id { get; set; }// id değişkeni 
    public string iller { get; set; } // string türünde iller
    public int olu_yarali { get; set; } // int türünde sayısı
    public int olu { get; set; } // int türünde olu sayısı
    public int yarali{ get; set; } // int türünde yararli sayısı

}
