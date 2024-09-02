using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankRekening.Models
{
    public class Bank
    {
        public string BankCard;
        public string BankName;
        public double Saldo;

        public Bank(string bankCard, string bankName, double saldo) 
        {
            BankName = bankCard;
            BankName = bankName;
            Saldo = saldo;
        }
        public void Deposite(double amount)
        {
            Saldo += amount;
        }
        public void Withdraw(double amount)
        {
            Saldo -= amount;
        }
        public double ShowSaldo()
        {
            return Saldo;
        }
        public override string ToString()
        {
            return $"{BankCard} {BankName} {Saldo}";
        }
    }
}
