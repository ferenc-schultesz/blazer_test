using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Stripe;

namespace StripeAdmin.Services
{
    public class StripeService : IStripeService
    {
        private const string publicKey = "pk_test_7bQqYNIlZoUeATQHLj1hLbnG";

        private const string privateKey = "sk_test_WVGGUkaoAftoWNMJMlTZ0ow4";

        public async Task<IEnumerable<Invoice>> GetInvoices(string customerId)
        {
            StripeConfiguration.SetApiKey("sk_test_WVGGUkaoAftoWNMJMlTZ0ow4");

            var service = new InvoiceService();
            var options = new InvoiceListOptions
            {
                Limit = 3,
            };
            var invoices = await service.ListAsync(options).ConfigureAwait(false);

            return invoices;
        }
    }
}
