using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LiftScoring.Models;
public class LiftSession
{
    [Key]
    public int Id { get; set; }
    public DateTime LiftDate { get; set; }

    [ForeignKey(nameof(LifterModel.Id))]
    public int LifterId { get; set; }

    public int Score { get; set; }

}