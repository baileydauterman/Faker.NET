namespace Faker.NET.Interfaces.Modules
{
    public interface IFakerFinance
    {
        public string AccountName();
        public string AccountNumber(int length = 8);
        public string Amount(int precision = 2, int min = 0, int max = 1000, string symbol = "");
        public string Bic(bool includeBranchCode = false);
        public string BitcoinAddress();
        public string CreditCardCVV();
        public string CreditCardIssuer();
        public string CreditCardNumber(string issuer = "");
        public string Currency();
        public string CurrencyCode();
        public string CurrencyName();
        public string CurrencySymbol();
        public string EthereumAddress();
        public string Iban(string countryCode = "", bool formatted = false);
        public string LitecoinAddress();
        public string MaskedNumber();
        public string Pin(int length = 4);
        public string RoutingNumber();
        public string TransactionDescription(string cardNumber = "", string accountNumber = "");
        public string TransactionType();
    }
}
