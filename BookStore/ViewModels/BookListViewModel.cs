
using BookStore.Models;

namespace BookStore.ViewModels
{
    public class BookListViewModel
    {
        public IEnumerable<Book> Books { get; set; }

        public List<BookPictures> Pictures { get; set; }
    }
}
