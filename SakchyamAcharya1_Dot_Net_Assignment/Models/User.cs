namespace SakchyamAcharya1_Dot_Net_Assignment.Models
{
    public class User
    {
        public required int Id { get; set; }
        public required string FullName { get; set; }
        public required string Email { get; set; }
        public required string PasswordHash { get; set; }
        public required string Address { get; set; }
        public required string PhoneNumber { get; set; }
    }
}
