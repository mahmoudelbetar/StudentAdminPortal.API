namespace StudentAdminPortal.API.Dtos
{
    public class StudentDto
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public long Mobile { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? ProfilePictureUrl { get; set; }
        public Guid GenderId { get; set; }
        public GenderDto Gender { get; set; }
        public AddressDto Address { get; set; }
    }
}
