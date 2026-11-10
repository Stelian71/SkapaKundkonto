namespace SkapaKundkonto.Models;

public class Customer(
    string name,
    string organizationNumber,
    string email,
    string phoneNumber)
{
    public string Name { get; set; } = name;
    public string OrganizationNumber { get; set; } = organizationNumber;
    public string Email { get; set; } = email;
    public string PhoneNumber { get; set; } = phoneNumber;
}