using BookStore.Models;

namespace BookStore.ViewModels
{
    public class CartVM
    {
        public IEnumerable<Cart> Cart { get; set; }

        public int Total { get; set; }
    }
}
