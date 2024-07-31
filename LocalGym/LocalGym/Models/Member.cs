// Models/Member.cs
public class Member
{
    public int MemberId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public DateTime JoinDate { get; set; }
    public List<Session> Sessions { get; set; }
}



