using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace StockMarket
{
    public class Investor
    {
        private List<Stock> portfolio;

        public int Count
        {
            get { return portfolio.Count; }
        }

        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public decimal MoneyToInvest { get; set; }
        public string BrokerName { get; set; }

        public Investor(string fullName, string emailAddress, decimal moneyToInvest, string brokerName)
        {
            FullName = fullName;
            EmailAddress = emailAddress;
            MoneyToInvest = moneyToInvest;
            BrokerName = brokerName;
            portfolio = new List<Stock>();
        }


        public void BuyStock(Stock stock)
        {
            if (stock.MarketCapitalization >= 10000 || MoneyToInvest >= 10000)
            {
                portfolio.Add(stock);
            }
        }

        public string SellStock(string companyName, decimal sellPrice)
        {
            if (portfolio.Count > 0)
            {
                if (!portfolio.Exists(x => x.CompanyName == companyName))
                {
                    Console.WriteLine($"{companyName} does not exist.");
                }

                Stock price = portfolio.FirstOrDefault(x => x.CompanyName == companyName);

                if (sellPrice <= price.PricePerShare)
                {
                    Console.WriteLine($"Cannot sell {companyName}.");
                }
            }
            Stock stock = portfolio.FirstOrDefault(x => x.CompanyName == companyName);
                portfolio.Remove(stock);
                MoneyToInvest += sellPrice;
                return $"{companyName} was sold.";
           
        }

        public Stock FindStock(string companyName)
        {
            if (!portfolio.Exists(x => x.CompanyName == companyName))
            {
                return null;
            }

            Stock stock = portfolio.FirstOrDefault(x => x.CompanyName == companyName);
            return stock;
        }

        public Stock FindBiggestCompany()
        {
            Stock stock = portfolio.OrderByDescending(x => x.MarketCapitalization).FirstOrDefault();
            return stock;
        }

        public string InvestorInformation()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"The investor {FullName} with a broker {BrokerName} has stocks:");
            foreach (var stock in portfolio)
            {
                sb.AppendLine($"{stock}");
            }

            return sb.ToString();
        }
    }
}
