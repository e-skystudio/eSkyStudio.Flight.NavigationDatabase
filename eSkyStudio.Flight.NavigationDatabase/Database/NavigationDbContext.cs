using Microsoft.EntityFrameworkCore;
using NavigationDatabase.Models;

namespace NavigationDatabase.Database;
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

    public virtual DbSet<Airport> TblAirports { get; set; } = null!;
    public virtual DbSet<AirportCommunication> TblAirportCommunications { get; set; } = null!;
    public virtual DbSet<AirportMsa> TblAirportMsas { get; set; } = null!;
    public virtual DbSet<ControlledAirspace> TblControlledAirspaces { get; set; } = null!;
    public virtual DbSet<CruisingTable> TblCruisingTables { get; set; } = null!;
    public virtual DbSet<EnrouteAirway> TblEnrouteAirways { get; set; } = null!;
    public virtual DbSet<EnrouteAirwayRestriction> TblEnrouteAirwayRestrictions { get; set; } = null!;
    public virtual DbSet<EnrouteCommunication> TblEnrouteCommunications { get; set; } = null!;
    public virtual DbSet<EnrouteNdbnavaid> TblEnrouteNdbnavaids { get; set; } = null!;
    public virtual DbSet<EnrouteWaypoint> TblEnrouteWaypoints { get; set; } = null!;
    public virtual DbSet<FirUir> TblFirUirs { get; set; } = null!;
    public virtual DbSet<Gate> TblGates { get; set; } = null!;
    public virtual DbSet<Gls> TblGls { get; set; } = null!;
    public virtual DbSet<GridMora> TblGridMoras { get; set; } = null!;
    public virtual DbSet<Header> TblHeaders { get; set; } = null!;
    public virtual DbSet<Holding> TblHoldings { get; set; } = null!;
    public virtual DbSet<Iap> TblIaps { get; set; } = null!;
    public virtual DbSet<LocalizerMarker> TblLocalizerMarkers { get; set; } = null!;
    public virtual DbSet<LocalizersGlideslope> TblLocalizersGlideslopes { get; set; } = null!;
    public virtual DbSet<Pathpoint> TblPathpoints { get; set; } = null!;
    public virtual DbSet<RestrictiveAirspace> TblRestrictiveAirspaces { get; set; } = null!;
    public virtual DbSet<Runway> TblRunways { get; set; } = null!;
    public virtual DbSet<Sid> TblSids { get; set; } = null!;
    public virtual DbSet<Star> TblStars { get; set; } = null!;
    public virtual DbSet<TerminalNdbnavaid> TblTerminalNdbnavaids { get; set; } = null!;
    public virtual DbSet<TerminalWaypoint> TblTerminalWaypoints { get; set; } = null!;
    public virtual DbSet<Vhfnavaid> TblVhfnavaids { get; set; } = null!;

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
