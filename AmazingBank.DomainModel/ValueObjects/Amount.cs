using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingBank.DomainModel.ValueObjects
{
    //Value Object
    public struct Amount
    {
        public Currency Currency { get; set; }
        public decimal Value { get; set; }
    }
}
