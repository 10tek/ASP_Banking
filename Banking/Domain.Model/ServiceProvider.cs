using Domain.Model.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Model
{
    //ServiceProvider (Id, Name, ServiceType)
    public class ServiceProvider : EntityModel
    {
        public string Name { get; set; }
        public ServiceType ServiceType { get; set; }
    }
}
