namespace LedgerAPI.Models
{
    public class Group
    {
        public int GroupID { get; set; }
        public string GroupName { get; set; }
        public DateTime CreatedDate { get; set; }

        // Navigation properties
        public ICollection<GroupMember> GroupMembers { get; set; }
        public ICollection<Expense> Expenses { get; set; }
    }
}
