using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingBank.DomainModel.ValueObjects
{
    //Value Object
    public struct Currency
    {
        //Code examples: USD, BRL, BTC
        public string Code { get; set; }
    }
}
