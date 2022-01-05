using eSkyStudio.Flight.NavigationDatabase.Database;
using eSkyStudio.Flight.NavigationDatabase.Models;


string DbPath = Path.Join(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),  "Navdata", "QsimPro", "navdata.s3db");
if(!File.Exists(DbPath))
{
    Console.WriteLine("Unable to find navigation database at location : {DbPath}!");
    Environment.Exit(0x01);
}



NavigationDbContext database = new NavigationDbContext(DbPath);

bool valid = database.Headers.First().IsAiracValid();
string text = valid ? "Valid" : "Expired";
Console.ForegroundColor = valid ? ConsoleColor.Green : ConsoleColor.Red;
Console.WriteLine($"The Current Navigation Database is {text}");
Console.ForegroundColor = ConsoleColor.White;

foreach(TerminalNdbnavaid ndb in database.TerminalNdbnavaids.Where(nav => nav.AirportIdentifier.Substring(0, 2) == "EB"))
{
    Console.WriteLine($"{ndb.Identifier} - {ndb.Latitude}°N - {ndb.Longitude}°E");
}

