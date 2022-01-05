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

    public virtual DbSet<TblAirport> TblAirports { get; set; } = null!;
    public virtual DbSet<TblAirportCommunication> TblAirportCommunications { get; set; } = null!;
    public virtual DbSet<TblAirportMsa> TblAirportMsas { get; set; } = null!;
    public virtual DbSet<TblControlledAirspace> TblControlledAirspaces { get; set; } = null!;
    public virtual DbSet<TblCruisingTable> TblCruisingTables { get; set; } = null!;
    public virtual DbSet<TblEnrouteAirway> TblEnrouteAirways { get; set; } = null!;
    public virtual DbSet<TblEnrouteAirwayRestriction> TblEnrouteAirwayRestrictions { get; set; } = null!;
    public virtual DbSet<TblEnrouteCommunication> TblEnrouteCommunications { get; set; } = null!;
    public virtual DbSet<TblEnrouteNdbnavaid> TblEnrouteNdbnavaids { get; set; } = null!;
    public virtual DbSet<TblEnrouteWaypoint> TblEnrouteWaypoints { get; set; } = null!;
    public virtual DbSet<TblFirUir> TblFirUirs { get; set; } = null!;
    public virtual DbSet<TblGate> TblGates { get; set; } = null!;
    public virtual DbSet<TblGl> TblGls { get; set; } = null!;
    public virtual DbSet<TblGridMora> TblGridMoras { get; set; } = null!;
    public virtual DbSet<TblHeader> TblHeaders { get; set; } = null!;
    public virtual DbSet<TblHolding> TblHoldings { get; set; } = null!;
    public virtual DbSet<TblIap> TblIaps { get; set; } = null!;
    public virtual DbSet<TblLocalizerMarker> TblLocalizerMarkers { get; set; } = null!;
    public virtual DbSet<TblLocalizersGlideslope> TblLocalizersGlideslopes { get; set; } = null!;
    public virtual DbSet<TblPathpoint> TblPathpoints { get; set; } = null!;
    public virtual DbSet<TblRestrictiveAirspace> TblRestrictiveAirspaces { get; set; } = null!;
    public virtual DbSet<TblRunway> TblRunways { get; set; } = null!;
    public virtual DbSet<TblSid> TblSids { get; set; } = null!;
    public virtual DbSet<TblStar> TblStars { get; set; } = null!;
    public virtual DbSet<TblTerminalNdbnavaid> TblTerminalNdbnavaids { get; set; } = null!;
    public virtual DbSet<TblTerminalWaypoint> TblTerminalWaypoints { get; set; } = null!;
    public virtual DbSet<TblVhfnavaid> TblVhfnavaids { get; set; } = null!;

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
