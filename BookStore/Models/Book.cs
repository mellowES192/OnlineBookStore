namespace BookStore.Models
{
    public class Book
    {
        public string? Id { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }

        public string? ISBN { get; set; }

        public decimal Price { get; set; }

        public string? PictureUri { get; set; }

        public int BookAuthorId { get; set; }

        public BookAuthor? BookAuthor { get; set; }

        public int StoreId { get; set; }

        public Store? Store { get; set; }

        public ICollection<BookCategory>? BookCategories { get; set; }
    }
}
