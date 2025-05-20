// See https://aka.ms/new-console-template for more information
using System;
abstract class Employee
{
  public String name;
  public String _name
  {
    get { return name; }
    set { name = value; }
  }
  public double luong;
  public double _luong
  {
    get { return luong; }
    set { luong = value; }
  }
  public String loainhanvien;
  public String _loainhanvien
  {
    get { return loainhanvien; }
    set { loainhanvien = value; }
  }

  public double tinhluong(double tongluong)
  {
    if (loainhanvien == "FullTimeEmployee ")
    {
      tongluong = luong + luong * 0.1;
    }
    else
    {
      tongluong = luong + luong * 0.05;
    }
    return tongluong;
  }
}
class nhanvien: Employee
{
  
}
class Program
{
  public static void Main(string[] args)
  {
    Console.WriteLine("Nhap so luong nhan vien: ");
    int n = int.Parse(Console.ReadLine());
   nhanvien[] ds = new nhanvien[n];
    for (int i = 0; i < n; i++)
    {
      ds[i] = new nhanvien();
      Console.WriteLine("Nhap ten nhan vien: ");
      ds[i]._name = Console.ReadLine();
      Console.WriteLine("Nhap luong nhan vien: ");
      ds[i]._luong = double.Parse(Console.ReadLine());
      Console.WriteLine("Nhap loai nhan vien: ");
      ds[i]._loainhanvien = Console.ReadLine();
    }
    for (int i = 0; i < n; i++)
    {
      Console.WriteLine("Ten nhan vien: " + ds[i]._name);
      Console.WriteLine("Luong nhan vien: " + ds[i]._luong);
      Console.WriteLine("Loai nhan vien: " + ds[i]._loainhanvien);
      Console.WriteLine("Tong luong nhan vien: " + ds[i].tinhluong(ds[i]._luong));
    }
  }
   
}
