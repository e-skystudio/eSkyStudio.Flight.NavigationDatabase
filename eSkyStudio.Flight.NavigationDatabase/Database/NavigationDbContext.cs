using eSkyStudio.Flight.NavigationDatabase.Models;
using Microsoft.EntityFrameworkCore;


namespace eSkyStudio.Flight.NavigationDatabase.Database;
public partial class NavigationDbContext : DbContext
{
    public string DbPath { get; set; }

    public NavigationDbContext(string path)
    {
        DbPath = path;
    }
    public NavigationDbContext(DbContextOptions<NavigationDbContext> options)
        : base(options)
    {
        DbPath = String.Empty;
    }

    public virtual DbSet<Airport> Airports { get; set; } = null!;
    public virtual DbSet<AirportCommunication> AirportCommunications { get; set; } = null!;
    public virtual DbSet<AirportMsa> AirportMsas { get; set; } = null!;
    public virtual DbSet<ControlledAirspace> ControlledAirspaces { get; set; } = null!;
    public virtual DbSet<CruisingTable> CruisingTables { get; set; } = null!;
    public virtual DbSet<EnrouteAirway> EnrouteAirways { get; set; } = null!;
    public virtual DbSet<EnrouteAirwayRestriction> EnrouteAirwayRestrictions { get; set; } = null!;
    public virtual DbSet<EnrouteCommunication> EnrouteCommunications { get; set; } = null!;
    public virtual DbSet<EnrouteNdbnavaid> EnrouteNdbnavaids { get; set; } = null!;
    public virtual DbSet<EnrouteWaypoint> EnrouteWaypoints { get; set; } = null!;
    public virtual DbSet<FirUir> FirUirs { get; set; } = null!;
    public virtual DbSet<Gate> Gates { get; set; } = null!;
    public virtual DbSet<Gls> Gls { get; set; } = null!;
    public virtual DbSet<GridMora> GridMoras { get; set; } = null!;
    public virtual DbSet<Header> Headers { get; set; } = null!;
    public virtual DbSet<Holding> Holdings { get; set; } = null!;
    public virtual DbSet<Iap> Iaps { get; set; } = null!;
    public virtual DbSet<LocalizerMarker> LocalizerMarkers { get; set; } = null!;
    public virtual DbSet<LocalizersGlideslope> LocalizersGlideslopes { get; set; } = null!;
    public virtual DbSet<Pathpoint> Pathpoints { get; set; } = null!;
    public virtual DbSet<RestrictiveAirspace> RestrictiveAirspaces { get; set; } = null!;
    public virtual DbSet<Runway> Runways { get; set; } = null!;
    public virtual DbSet<Sid> Sids { get; set; } = null!;
    public virtual DbSet<Star> Stars { get; set; } = null!;
    public virtual DbSet<TerminalNdbnavaid> TerminalNdbnavaids { get; set; } = null!;
    public virtual DbSet<TerminalWaypoint> TerminalWaypoints { get; set; } = null!;
    public virtual DbSet<Vhfnavaid> Vhfnavaids { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlite($"DataSource={DbPath}");
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
