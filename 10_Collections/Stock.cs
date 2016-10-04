using System;

namespace _10_Collections
{
    public class Stock : IAsset
    {

        public Stock()
        {

        }

        public Stock(string symbol, double pricePerShare, double numShares)
        {
            this.Name = symbol;
            this.PricePerShare = pricePerShare;
            this.NumShares = numShares;
        }

        public double NumShares
        {
            get;
            set;
        }

        public double PricePerShare
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public long Id { get; set; }

        public double GetValue()
        {
            return NumShares * PricePerShare;
        }

        public static double TotalValue(Stock[] stocks)
        {
            double Total1 = stocks[0].GetValue();
            double Total2 = stocks[1].GetValue();
            return Total1 + Total2;
        }
        public override string ToString()
        {
            return ("Stock[symbol=ABC,pricePerShare=12.23,numShares=50]");
        }


        public override bool Equals(object obj)
        {
            Stock x = (Stock)obj;
            if (x.Name == Name && x.PricePerShare == PricePerShare && x.NumShares == NumShares)
            {
                return true;
            }
            else
            {
                return false;

            }
        }

        public static double TotalValue(IAsset[] portfolio)
        {
            double totalValue = 0;

            foreach (IAsset a in portfolio)
            {
                totalValue += a.GetValue();
            }
            return totalValue; 
        }

    }
}