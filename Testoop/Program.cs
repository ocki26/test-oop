// See https://aka.ms/new-console-template for more information
using System;
abstract class pet
{
  int age;
  public string _name
  {
    get
    {
      return name;
    }
    set
    {
      name = value;
    }
  }
  string name;
  public int _age
  {
    get
    {
      return age;
    }
    set
    {
      age = value;
    }
  }
  public abstract void animalSound();
  
  public void animal()
  {
    Console.WriteLine(" PET MAKE sound");
  }

}
class dog : pet
{
  public override void animalSound()
  {
    Console.WriteLine("Dog barks");
  }
}
class cat : pet
{
  public override void animalSound()
  {
    Console.WriteLine("Cat meows");
  }
}
class Program
{
  public static void Main(string[] args)
  {
    pet p = new dog();
    p._name = "dog";
    p._age = 2;
    Console.WriteLine("Name: " + p._name);
    Console.WriteLine("Age: " + p._age);
    p.animalSound();
    p.animal();

    pet c = new cat();
    c._name = "cat";
    c._age = 3;
    Console.WriteLine("Name: " + c._name);
    Console.WriteLine("Age: " + c._age);
    c.animalSound();
    c.animal();
  }
   
}
