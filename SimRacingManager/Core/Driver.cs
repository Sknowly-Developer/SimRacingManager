using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace SimRacingManager.Core;

[Table("drivers")]
public class Driver : BaseModel
{
    [PrimaryKey("uuid")]
    public Guid Guid { get; set; }
    
    [Column("name")]
    public string Name { get; set; }

    [Column("surname")]
    public string Surname { get; set; }
    
    [Column("number")]
    public int Number { get; set; }

    public int Position;
    public int Points;
    public string VehicleType;
}