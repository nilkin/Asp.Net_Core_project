namespace CorporX.Models
{
    public class MemberLink
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public string ClassName { get; set; }
        public string Url { get; set; }
        public Member Member { get; set; }
    }
}
