using System;
using System.Collections.Generic;

class Haberler
{
    private int _id; //değişken 
      [Key] 
    public int id { get; set; }
    public string tür { get; set; }  //string türünde tür adı
    public string url { get; set; } //string türünde url
    public int tarih { get; set; } // int türünde tarih

}
