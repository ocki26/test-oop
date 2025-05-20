// See https://aka.ms/new-console-template for more information
using System;
class tinhdientich
{
  private int _chieudai;
  private int _chieurong;
  public int chieudai
  {
    get
    {
      return _chieudai;
    }
    set
    {
      _chieudai = value;
    }
  }
  public int chieurong
  {
    get
    {
      return _chieurong;
    }
    set
    {
      _chieurong = value;
    }
  }
  public int dientich
  {
    get
    {
      return _chieudai * _chieurong;
    }
  }
}
class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Nhap chieu dai:");
    int chieudai = int.Parse(Console.ReadLine());
    Console.WriteLine("Nhap chieu rong:");
    int chieurong = int.Parse(Console.ReadLine());
    tinhdientich s1 = new tinhdientich();
    s1.chieudai = chieudai;
    s1.chieurong = chieurong;
    Console.WriteLine("Dien tich hinh chu nhat la: " + s1.dientich);

  }
   
}
