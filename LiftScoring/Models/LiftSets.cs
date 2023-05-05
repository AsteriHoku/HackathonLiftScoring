using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LiftScoring.Models
{
    public class LiftSets
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(LiftType.Id))]
        public int Type_Id { get; set; }

        public int Weight { get; set; }

        public int Reps { get; set; }
    }
}
