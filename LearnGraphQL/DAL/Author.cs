namespace LearnGraphQL.Models
{
    public record Author
    {
        public required Guid Id { get; set; }
        
        public required string Name { get; set; }
    }
}
