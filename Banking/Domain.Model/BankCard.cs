using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Model
{
    //BankCard (Id, Number, ValidPeriod, CardHolder, Cvc, Amount, BankAccount)
    public class BankCard : EntityModel
    {
        public string CardNumber { get; set; }
        public DateTime ValidDate { get; set; } = DateTime.Now.AddYears(2);
        public string CardHolder { get; set; }
        public int CVC { get; set; }
        public decimal Amount { get; set; }
        public Guid BankAccountId { get; set; }
        public BankAccount BankAccount { get; set; }
    }
}
