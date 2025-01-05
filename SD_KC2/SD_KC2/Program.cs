using SD_KC2;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("How many albums do you want to add?");
        int numberOfRecords = int.Parse(Console.ReadLine());

        var recordList = new List<MyClass>();

        for (int i = 0; i < numberOfRecords; i++)
        {
            // Create a new instance of Album
            var album = new Album();

            // Get input from user for MyProperty (album name, inherited from MyClass)
            Console.WriteLine("Enter the name of the album: ");
            album.MyProperty = Console.ReadLine();  // Inherited property from MyClass

            // Get input for Artist (specific to Album)
            Console.WriteLine("Enter the artist of the album: ");
            album.Artist = Console.ReadLine();

            // Get input for Year (specific to Album)
            Console.WriteLine("Enter the year of the album: ");
            album.Year = int.Parse(Console.ReadLine());

            // Add the album object to the list
            recordList.Add(album);
        }

        // Print out the list of records (using the overridden ToString() in Album)
        Console.WriteLine("\nHere are the albums you entered:");
        foreach (var item in recordList)
        {
            Console.WriteLine(item.ToString());  // calling Album's ToString() method
        }
    }
}
