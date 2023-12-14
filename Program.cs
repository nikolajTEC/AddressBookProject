namespace AddressBookProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AdressBook janAdressBook = new AdressBook("Jan");
            Address address1 = new Address("Hans Peter Nielsen", "Birkehøj 5", "2134123456");
            Address address2 = new Address("Jens Peter Larsen", "Poppelhøj 6", "2345619481");
            janAdressBook.AddAddress(address1);
            janAdressBook.AddAddress(address2);
            Console.WriteLine(janAdressBook);

            janAdressBook.RemoveAdress(1);
            Console.WriteLine($"\n{janAdressBook}");

            AdressBook boAdressBook = new AdressBook("Bo");
            Address address3 = new Address("Niels Peter Hansen", "Bøgehøj 7", "213412345636");
            Address address4 = new Address("Jens Peter Larsen", "Poppelhøj 6", "234567980");
            boAdressBook.AddAddress(address3);
            boAdressBook.AddAddress(address4);
            Console.WriteLine($"\n{boAdressBook}");

            AdressBook janOgBoAdressBook = new AdressBook("Jan and Bo");
            janOgBoAdressBook.AddAddress(address1);
            janOgBoAdressBook.AddAddress(address2);
            janOgBoAdressBook.AddAddress(address3);
            janOgBoAdressBook.AddAddress(address4);
            Console.WriteLine($"\n{janOgBoAdressBook}");


            Console.ReadLine();
        }
    }
}
