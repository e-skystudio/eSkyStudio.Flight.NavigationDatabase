using eSkyStudio.Flight.NavigationDatabase.Database;
using eSkyStudio.Flight.NavigationDatabase.Models;


string DbPath = Path.Join(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),  "Navdata", "QsimPro", "navdata.s3db");
if(!File.Exists(DbPath))
{
    Console.WriteLine("Unable to find navigation database at location : {DbPath}!");
    Environment.Exit(0x01);
}

NavigationDbContext database = new NavigationDbContext(DbPath);

foreach(TerminalNdbnavaid ndb in database.TblTerminalNdbnavaids.Where(nav => nav.AirportIdentifier.Substring(0, 2) == "EB"))
{
    Console.WriteLine($"{ndb.Identifier} - {ndb.Latitude}°N - {ndb.Longitude}°E");
}

