// Models/Trainer.cs
public class Trainer
{
    public int TrainerId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Speciality { get; set; }
    public decimal FeePer30Minutes { get; set; }
    public DateTime HireDate { get; set; }
    public List<Session> Sessions { get; set; }
}