namespace StripeAdmin.Services
{
    using Stripe;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    interface IStripeService
    {
        Task<IEnumerable<Invoice>> GetInvoices(string customerId);
    }
}
