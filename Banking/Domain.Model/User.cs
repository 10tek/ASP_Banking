using System;

namespace Domain.Model
{
    public class User : EntityModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}