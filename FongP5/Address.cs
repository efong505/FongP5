using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FongP5
{
    class Address
    {
        // Auto Properties
        public string City { get; set; }
        public string State { get; set; }
        public string Street { get; set; }
        public string ZipCode { get; set; }

        public override string ToString()
        {
            return Street + "\r\n" +
                City + ", " + State +
                " " + ZipCode;
        }
    }
}
