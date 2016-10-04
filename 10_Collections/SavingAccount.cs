using System;

namespace _10_Collections
{
public class SavingsAccount : IAsset
{
    public SavingsAccount(string accountName, double balance, double interestRate)
    {
        this.Name = accountName;
        this.Balance = balance;
        this.InterestRate = interestRate;
    }

    public string Name
    {
        get;
        set;
    }
    public double InterestRate
    {
        get;
        private set;
    }
    public double Balance
    {
        get;
        private set;
    }

        public double GetValue()
    {

        return Balance;
    }

    public void ApplyInterest()
    {
        Balance += (InterestRate / 100) * Balance;
    }
    public override string ToString()
    {
        return "SavingsAccount[value=" + this.Balance + ",interestRate=" + this.InterestRate + "]";
    }
}
}
