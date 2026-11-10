using SkapaKundkonto.Models;

namespace SkapaKundkonto.Repositories;

public class CustomerRepository
{
    private readonly List<Customer> customers = [];

    public bool CustomerExists(string organizationNumber, string email)
    {
        return customers.Any(customer =>
            customer.OrganizationNumber == organizationNumber ||
            customer.Email == email);
    }

    public void Save(Customer customer)
    {
        customers.Add(customer);
    }

    public List<Customer> GetAll()
    {
        return customers;
    }
}