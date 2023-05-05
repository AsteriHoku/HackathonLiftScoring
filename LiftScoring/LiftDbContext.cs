using LiftScoring.Models;
using Microsoft.EntityFrameworkCore;

namespace LiftScoring;
public class LiftDbContext : DbContext
{
    public LiftDbContext() : base("name = LiftDbContext") {}
    public virtual DbSet<LifterModel> Lifters { get; set; }
    public virtual DbSet<LiftSession> Sessions { get; set; }
    public virtual DbSet<LiftType> Types { get; set; }

}