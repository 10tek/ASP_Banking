using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Model
{
    //Service (Id, ServiceProvider, BankCard, Amount)
    public class Service : EntityModel
    {
        public Guid ServiceProviderId { get; set; }
        public ServiceProvider ServiceProvider { get; set; }
        public Guid BankCardId { get; set; }
        public BankCard BankCard { get; set; }
        public decimal Amount { get; set; }
    }
}
