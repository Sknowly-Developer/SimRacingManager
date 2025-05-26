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
    
    [Column("1st")]
    public Guid? First { get; set; }
    
    [Column("2nd")]
    public Guid? Second { get; set; }
    
    [Column("3rd")]
    public Guid? Third { get; set; }
    
    [Column("4th")]
    public Guid? Fourth { get; set; }
    
    [Column("5th")]
    public Guid? Fifth { get; set; }
    
    [Column("6th")]
    public Guid? Sixth { get; set; }
    
    [Column("7th")]
    public Guid? Seventh { get; set; }
    
    [Column("8th")]
    public Guid? Eighth { get; set; }
    
    [Column("9th")]
    public Guid? Ninth { get; set; }
    
    [Column("10th")]
    public Guid? Tenth { get; set; }
    
    [Column("11th")]
    public Guid? Eleventh { get; set; }
    
    [Column("12th")]
    public Guid? Twelfth { get; set; }
}