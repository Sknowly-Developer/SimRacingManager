using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace SimRacingManager.Core;

[Table("results")]
public class Results : BaseModel
{
    [PrimaryKey("uuid")]
    public Guid Guid { get; set; }
    
    [Column("track")]
    public Guid TrackGuid { get; set; }
    
    [Column("positions")]
    public Guid[]? PositionsGuid { get; set; }
    public List<Driver> Positions = [];
    
    [Column("points")]
    public int[]? Points { get; set; }
    
    [Column("fastest_lap")]
    public Guid FastestLap { get; set; }

    [Column("dnf")]
    public Guid[]? DidNotFinishes { get; set; }
    
    [Column("reached_points")]
    public Guid[]? ReachedPoints { get; set; }
}