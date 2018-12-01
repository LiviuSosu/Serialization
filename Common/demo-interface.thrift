namespace * Common.ThriftInterface

struct BookInfo
{
  1: i32 Id,
  2: Author Author,
  3: string Title,
  4: i32 PageCount,
}

struct Author
{
	1: string Name
}

service LibraryService
{
  list<BookInfo> GetAllBooks();
  BookInfo GetBook(1: i32 bookId);
}