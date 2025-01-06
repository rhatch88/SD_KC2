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
            var album = new Album();

            Console.WriteLine("Enter the name of the album: ");
            album.MyProperty = Console.ReadLine();  // Inherited property from MyClass

            Console.WriteLine("Enter the artist of the album: ");
            album.Artist = Console.ReadLine();

            Console.WriteLine("Enter the year of the album: ");
            album.Year = int.Parse(Console.ReadLine());

            recordList.Add(album);
        }

        Console.WriteLine("\nHere are the albums you entered:");
        foreach (var item in recordList)
        {
            Console.WriteLine(item.ToString());  // calling Album's ToString() method
        }
    }
}
