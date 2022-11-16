using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleUnitTest
{
    public class BankAccounts 
    { 
    private readonly string m_customerName;
    private double m_balance;

    private BankAccounts() { }

    public BankAccounts(string customerName, double balance)
    {
        m_customerName = customerName;
        m_balance = balance;
    }

    public string CustomerName
    {
        get { return m_customerName; }
    }

    public double Balance
    {
        get { return m_balance; }
    }

    public void Debit(double amount)
    {
        if (amount > m_balance)
        {
            throw new ArgumentOutOfRangeException("amount");
        }

        if (amount < 0)
        {
            throw new ArgumentOutOfRangeException("amount");
        }

            m_balance -= amount;
        }

    public void Credit(double amount)
    {
        if (amount < 0)
        {
            throw new ArgumentOutOfRangeException("amount");
        }

        m_balance += amount;
    }

    public static void Main()
    {
        BankAccounts obj = new BankAccounts("Ragini Singh", 11.99);
        obj.Credit(5.77);
        obj.Debit(11.22);
        Console.WriteLine("Current balance is ${0}", obj.Balance);
    }
}
}
