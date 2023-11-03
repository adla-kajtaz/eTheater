using Microsoft.Extensions.Configuration;
using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTheater.Services
{
    public class StripeService
    {
		private readonly string apiKey;

		public StripeService(IConfiguration configuration)
		{
			apiKey = configuration["StripeSettings:ApiKey"] ?? Environment.GetEnvironmentVariable("STRIPE_API_KEY");
		}

		public string CreatePurchase(int amount, string description)
		{
			StripeConfiguration.ApiKey = apiKey;
			var options = new PaymentIntentCreateOptions
			{
				Amount = amount * 100,
				Currency = "EUR",
				Description = description,
			};
			var service = new PaymentIntentService();
			var paymentIntent = service.Create(options);

			return paymentIntent.ClientSecret;
		}
	}
}
