# GraphQL Queries
{
  books (where: { author: { name: {contains: "Romain"} } }) {
    title
    author {
      name
    }
  }
}

# GraphQL mutations
mutation {
  addBook(input: {
    book: {
      id: "77275b9f-8adc-4d00-af00-0cf88e26ef1f", 
      title: "MyGraphQlBOok", 
      author: {
        id: "4a477300-55e5-4b2f-b412-561f81309803", 
        name: "Me"
        }
      }
    }) {
      book {
        id
      }
  }
}