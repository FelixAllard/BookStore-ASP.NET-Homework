using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using OnlineBookstoreAssignment.Models;

namespace OnlineBookstoreAssignment.Controllers;

public class BookController(ILogger<HomeController> logger) : Controller
{
    private readonly ILogger<HomeController> _logger = logger;

    public static List<Book> allTheBooks = new List<Book>
    {
        new Book { Id = 1, Title = "Book One", Author = "Author A", Publisher = "Publisher A", Genre = "Genre A", Price = "9.99", Quantity = "10", Description = "A fascinating tale of adventure.", Category = "Fiction", Image = "image1.jpg" },
        new Book { Id = 2, Title = "Book Two", Author = "Author B", Publisher = "Publisher B", Genre = "Genre B", Price = "14.99", Quantity = "5", Description = "A deep dive into the mysteries of life.", Category = "Philosophy", Image = "image2.jpg" },
        new Book { Id = 3, Title = "Book Three", Author = "Author C", Publisher = "Publisher C", Genre = "Genre C", Price = "19.99", Quantity = "3", Description = "An epic journey of self-discovery.", Category = "Biography", Image = "image3.jpg" },
        new Book { Id = 4, Title = "Book Four", Author = "Author D", Publisher = "Publisher D", Genre = "Genre D", Price = "24.99", Quantity = "7", Description = "A thrilling story of courage and bravery.", Category = "History", Image = "image4.jpg" },
        new Book { Id = 5, Title = "Book Five", Author = "Author E", Publisher = "Publisher E", Genre = "Genre E", Price = "29.99", Quantity = "2", Description = "A heartwarming tale of love and friendship.", Category = "Romance", Image = "image5.jpg" },
        new Book { Id = 6, Title = "Book Six", Author = "Author F", Publisher = "Publisher F", Genre = "Genre F", Price = "12.99", Quantity = "8", Description = "A gripping narrative of suspense and intrigue.", Category = "Thriller", Image = "image6.jpg" },
        new Book { Id = 7, Title = "Book Seven", Author = "Author G", Publisher = "Publisher G", Genre = "Genre G", Price = "16.99", Quantity = "6", Description = "A captivating story of ambition and power.", Category = "Drama", Image = "image7.jpg" },
        new Book { Id = 8, Title = "Book Eight", Author = "Author H", Publisher = "Publisher H", Genre = "Genre H", Price = "8.99", Quantity = "4", Description = "A delightful exploration of dreams and reality.", Category = "Fantasy", Image = "image8.jpg" },
        new Book { Id = 9, Title = "Book Nine", Author = "Author I", Publisher = "Publisher I", Genre = "Genre I", Price = "20.99", Quantity = "9", Description = "An enchanting story of magic and wonder.", Category = "Science Fiction", Image = "image9.jpg" },
        new Book { Id = 10, Title = "Book Ten", Author = "Author J", Publisher = "Publisher J", Genre = "Genre J", Price = "18.99", Quantity = "1", Description = "A thrilling conclusion to an epic saga.", Category = "Adventure", Image = "image10.jpg" }
    };
    public IActionResult ViewBook(int id)
    {
        Book selectedBook = allTheBooks.FirstOrDefault(b => b.Id == id);
        if (selectedBook == null)
            return Error("Didn't find the book you are looking for.");
        return View(selectedBook);
    }
    public static List<String> GetBooksCategory()
    {
        return allTheBooks.Select(b => b.Category).Distinct().ToList();
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error(string didnTFindTheBookYouAreLookingFor)
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}