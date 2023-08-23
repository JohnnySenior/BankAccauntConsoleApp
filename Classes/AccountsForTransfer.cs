using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemApp.Classes
{
    public class AccountsForTransfer
    {
        public AccountsForTransfer(string name, int cardNumber)
        {
            Name = name;
            CardNumber = cardNumber;
        }

        public string Name { get; set; }
        public int CardNumber { get; set; }

        public override string ToString()
        {
            return $"Card Holder Name: {Name}\nCard Number: {CardNumber}";
        }
    }
}
