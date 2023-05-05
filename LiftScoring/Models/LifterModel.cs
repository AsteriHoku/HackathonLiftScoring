namespace LiftScoring.Models;
public class LifterModel
{
    public string Name { get; set; }
    public bool isFemale { get; set; }
    public double DeadLift { get; set; }
    public double SquatLift { get; set; }
    public double BenchLift { get; set; }
    public double OverheadPressLift { get; set; }
    public double CurlLift { get; set; }
    public double RowLift { get; set; }

}