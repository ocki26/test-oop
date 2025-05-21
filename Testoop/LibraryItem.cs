using System;
using System.ComponentModel.Design;
using System.Net;
abstract class LibraryItem
{
  public string Title
  {
    get; set;
  }
  public string Author
  {
    get; set;
  }
  public string Publication_date
  {
    get;
    set;
  }
  public bool Available
  {
    get; set;
  }
  public LibraryItem(string title, string author, string publication_date, bool available)
  {
    Title = title;
    Author = author;
    Publication_date = publication_date;
    Available = available;

  }
  public abstract void checkout();
  public abstract void Returniterm();
  
  public void Introduce()
  {
    Console.WriteLine($"{Title}+{Author}+{Publication_date}+{Available}");
  }
}
