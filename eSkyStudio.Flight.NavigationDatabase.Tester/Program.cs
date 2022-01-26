using System;
using System.IO;
using System.Linq;
using eSkyStudio.Flight.NavigationDatabase.Database;
using eSkyStudio.Flight.NavigationDatabase.Models;
namespace eSkyStudio.Flight.NavigationDatabase.Tester
{
    public static class Program
    {
        public static void Main()
        {
            string DbPath = Path.Join(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Documents", "Navdata", "navdata.s3db");
            if (!File.Exists(DbPath))
            {
                Console.WriteLine($"Unable to find navigation database at location : {DbPath}!");
                Environment.Exit(0x01);
            }



            NavigationDbContext database = new NavigationDbContext(DbPath);
            Console.BackgroundColor = ConsoleColor.Black;
            bool valid = database.Headers.First().IsAiracValid();
            string text = valid ? "Valid" : "Expired";
            Console.ForegroundColor = valid ? ConsoleColor.Green : ConsoleColor.Red;
            Console.WriteLine($"The Current Navigation Database is {text}");
            Console.ForegroundColor = ConsoleColor.White;

            foreach (TerminalNdbnavaid ndb in database.TerminalNdbnavaids.Where(nav => nav.AirportIdentifier.Substring(0, 2) == "EB"))
            {
                Console.WriteLine($"{ndb.Identifier} - {ndb.Latitude}°N - {ndb.Longitude}°E");
            }
        }
    }
}