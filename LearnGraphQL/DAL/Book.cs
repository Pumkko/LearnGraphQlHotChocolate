namespace LearnGraphQL.Models
{
    public record Book()
    {
        public required Guid Id { get; set; }

        public required string Title { get; set; }

        public required Author Author { get; set; }
    }
}
