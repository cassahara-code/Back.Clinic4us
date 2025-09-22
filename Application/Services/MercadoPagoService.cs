using Application.IServices;
using MercadoPago.Client.Common;
using MercadoPago.Client.Payment;
using MercadoPago.Client.Preference;
using MercadoPago.Config;
using MercadoPago.Resource.Common;
using MercadoPago.Resource.Payment;
using MercadoPago.Resource.Preference;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;

namespace Application.Services
{
    public class MercadoPagoService : IMercadoPagoService
    {
        private readonly IConfiguration _configuration;
        private readonly string _accessToken;
        private readonly string _publicKey;

        public MercadoPagoService(IConfiguration configuration)
        {
            _configuration = configuration;
            _accessToken = _configuration["MercadoPago:AccessToken"] ?? _configuration["AccessToken"];
            _publicKey = _configuration["MercadoPago:PublicKey"] ?? _configuration["PublicKey"];
        }

        public async Task<string> CreatePaymentAsync(decimal amount = 1, string description = "Assinatura Mensal", string payerEmail = "fabioomartins@gmail.com")
        {
            MercadoPagoConfig.AccessToken = _accessToken;
            var paymentClient = new PaymentClient();
            var paymentRequest = new PaymentCreateRequest
            {
                TransactionAmount = amount,
                Description = description,
                PaymentMethodId = "cc", // exemplo, pode ser alterado
                Payer = new PaymentPayerRequest
                {
                    Email = payerEmail,
                    Address = new PaymentPayerAddressRequest
                    {
                        City = "Volta Redonda",
                        FederalUnit = "RJ",
                        Neighborhood = "Cidade Nova",
                        StreetName = "Rua Dr. Djalma Caldas",
                        StreetNumber = 18,
                        ZipCode = "27258250"
                    },
                    FirstName = "Fábio",
                    //Identification = new IdentificationRequest
                    //{
                    //    Type = "CC",
                    //    Number = "5031433215406351"
                    //},
                    LastName = "Martins",
                    Phone = new PaymentPayerPhoneRequest { AreaCode = "+55", Number = "24981113434" }
                    // Removido Type = "CC"
                }
            };
            Payment payment = await paymentClient.CreateAsync(paymentRequest);
            return payment.Id.ToString();
        }

        public async Task<string> CreateCheckoutAsync(decimal amount, string description, string payerName, string payerEmail, string clinicAddress)
        {
            MercadoPagoConfig.AccessToken = _accessToken;
            var preferenceClient = new PreferenceClient();
            var preferenceRequest = new PreferenceRequest
            {
                Items = new List<PreferenceItemRequest>
                {
                    new PreferenceItemRequest
                    {
                        Title = description,
                        Quantity = 1,
                        UnitPrice = amount
                    }
                },
                Payer = new PreferencePayerRequest
                {
                    Name = payerName,
                    Email = payerEmail
                    // O campo Address não existe no SDK oficial, pode ser incluído em Description ou custom_field
                },
                BackUrls = new PreferenceBackUrlsRequest
                {
                    Success = "localhost:7185/api/MercadoPagoCallback/success",
                    Failure = "localhost:7185/api/MercadoPagoCallback/Failure",
                },
            };
            Preference preference = await preferenceClient.CreateAsync(preferenceRequest);
            return preference.InitPoint;
        }
    }
}
