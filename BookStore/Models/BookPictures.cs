namespace BookStore.Models
{
    public class BookPictures
    {
        public int Id { get; set; }

        public string? PictureUri { get; set; }

        public string? BookId { get; set; }

        public Book? Book { get; set; }
    }
}
