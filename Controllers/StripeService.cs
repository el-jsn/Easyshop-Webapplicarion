using Microsoft.Extensions.Configuration;
using Stripe;

public class StripeService
{
    private readonly IConfiguration _config;

    public StripeService(IConfiguration config)
    {
        _config = config;
    }

    public async Task<PaymentIntent> CreatePaymentIntentAsync(decimal amount, string currency, string description)
    {
        StripeConfiguration.ApiKey = _config.GetSection("Stripe")["SecretKey"];

        var options = new PaymentIntentCreateOptions
        {
            Amount = (long)(amount * 100),
            Currency = currency,
            Description = description,
            PaymentMethodTypes = new List<string> { "card" }
        };

        var service = new PaymentIntentService();
        var paymentIntent = await service.CreateAsync(options);

        return paymentIntent;
    }
}
