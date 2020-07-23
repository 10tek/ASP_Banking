using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Model
{
    //BankAccount (Id, Number, IdentityUser, ValidPeriod, BankCards)
    public class BankAccount : EntityModel
    {
        public string AccountNumber { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public DateTime ValidPeriod { get; set; } = DateTime.Now.AddYears(10);
        public List<BankCard> BankCards { get; set; } = new List<BankCard>();
    }
}
