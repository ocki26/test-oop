using System;
class Book : LibraryItem
{
  public Book(string title, string author, string publication_date, bool available)
       : base(title, author, publication_date, available)
  { }
  public override void checkout()
  {

  }
  public override void Returniterm()
  {
    
  }
}