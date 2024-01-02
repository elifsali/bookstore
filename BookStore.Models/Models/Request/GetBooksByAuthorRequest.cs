namespace BookStore.Models.Models.Request
{
    public class GetBooksByAuthorRequest
    {
        public int AuthorId { get; set; }

        public DateTime AfterDate { get; set; }
    }
}
