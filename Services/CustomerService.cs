using SkapaKundkonto.Models;
using SkapaKundkonto.Repositories;

namespace SkapaKundkonto.Services;

public class CustomerService(CustomerRepository repository)
{
    private readonly CustomerRepository repository = repository;

    public bool CreateCustomer(
        string name,
        string organizationNumber,
        string email,
        string phoneNumber,
        out string message)
    {
        // Validera kunduppgifter
        if (string.IsNullOrWhiteSpace(name) ||
            string.IsNullOrWhiteSpace(organizationNumber) ||
            string.IsNullOrWhiteSpace(email) ||
            string.IsNullOrWhiteSpace(phoneNumber))
        {
            message = "Valideringsfel: Alla kunduppgifter måste fyllas i.";
            return false;
        }

        // Kontrollera om kunden redan finns
        if (repository.CustomerExists(organizationNumber, email))
        {
            message = "Kundkonto finns redan.";
            return false;
        }

        // Skapa kund
        Customer customer = new(
            name,
            organizationNumber,
            email,
            phoneNumber);

        // Spara kund
        repository.Save(customer);

        message = "Kundkonto har skapats.";
        return true;
    }
}