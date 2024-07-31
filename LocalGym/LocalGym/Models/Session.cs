// Models/Session.cs
public class Session
{
    public int SessionId { get; set; }
    public int MemberId { get; set; }
    public Member Member { get; set; }
    public int TrainerId { get; set; }
    public Trainer Trainer { get; set; }
    public DateTime SessionDate { get; set; }
    public int Duration { get; set; }
}