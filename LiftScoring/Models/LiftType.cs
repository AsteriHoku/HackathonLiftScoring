using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LiftScoring.Models;
public class LiftType
{
    [Key]
    public int Id { get; set; }

    [ForeignKey(nameof(LiftSession.Id))]
    public int SessionId { get; set; }
    public string Name { get; set; }
    public int HighScore { get; set; }
}