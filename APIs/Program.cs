namespace APIs
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Response? response = await FakeApiBooks.GetBookAsync(2);

            Console.WriteLine($"Books in store: ");
            if (response != null && response.Data != null)
            {
                
                foreach (var book in response.Data)
                {
                    Console.WriteLine("--------------------------");
                    Console.WriteLine($"Title: {book.Title}");
                    Console.WriteLine($"Author: {book.Author}");
                    Console.WriteLine($"Title: {book.Description}");
                    Console.WriteLine($"Title: {book.Published}");
                }
            }
            else
            {
                Console.WriteLine("Response was null");
            }
        }
    }
}
