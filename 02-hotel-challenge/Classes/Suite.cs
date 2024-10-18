using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _02_hotel_challenge.Classes
{
    public class Suite
    {

        public Suite(string suiteType, int capacity, decimal daily)
        {
            this.suiteType = suiteType;
            this.capacity = capacity;
            this.daily = daily;
        }

        public string suiteType;
        public int capacity;
        public decimal daily;
    }
}