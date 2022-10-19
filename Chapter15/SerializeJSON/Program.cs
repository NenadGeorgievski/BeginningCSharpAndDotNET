using System.Text.Json;
using SerializeJSON;

List<Book> books = new List<Book>();
Book book1 = new Book
{
    title = "Beginning C# and .NET",
    author = "Benjamin Parkins and Jon Reid",
    code = "911-221-223-223"
};

Book book2 = new Book
{
    title = "C Sharp",
    author = "John Reid",
    code = "223-305"
};

Book book3 = new Book
{
    title = "C Sharp Fundamentals",
    author = "John Reid and friends",
    code = "223-305-3323"
};

books.Add(book1);
books.Add(book2);
books.Add(book3);

string jsonString1 = JsonSerializer.Serialize(books, typeof(List<Book>));
File.WriteAllText("Books.json", jsonString1);

string jsonString2 = File.ReadAllText("Books.json");
List<Book> books2 = JsonSerializer.Deserialize<List<Book>>(jsonString2);

foreach (Book b in books2)
{
    Console.WriteLine("code: {0} title: {1} author: {2}", b.code, b.title, b.author);
}