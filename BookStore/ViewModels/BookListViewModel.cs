using BookStore.Models;

namespace BookStore.ViewModels
{
    public class BookListViewModel
    {
        public IEnumerable<Book> Book { get; set; }
    }
}
