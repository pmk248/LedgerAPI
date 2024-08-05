namespace LedgerAPI.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }

        // Navigation properties
        public ICollection<GroupMember> GroupMembers { get; set; }
        public ICollection<Expense> PaidExpenses { get; set; }
        public ICollection<ExpenseParticipant> ExpenseParticipants { get; set; }
    }
}
