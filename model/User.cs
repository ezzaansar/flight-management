namespace SE3.Models {
    public record User(
        int UserId,
        string FirstName,
        string LastName,
        string Gender,
        DateOnly DateOfBirth,
        string CNIC,
        string Email,
        string PhoneNumber,
        string Address,
        string Password,
        string Country,
        string City,
        string State,
        string Role = "Role"
    );
}