using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _02_hotel_challenge.Classes
{
    public class Reservation
    {
        public Reservation(int days)
        {
            this.Days = days;
        }

        private List<Person> _people = new List<Person>();
        private Suite _suite = null!;
        private int _days = 0;


        public List<Person> People
        {
            get => _people;
            set
            {
                if (value.All(p => p is Person))
                {
                    _people = value;
                }
                else
                {
                    throw new ArgumentException("Invalid person");
                }
            }
        }
        public Suite Suite
        {
            get => _suite;
            set
            {
                if (value is Suite)
                {
                    _suite = value;
                }
                else
                {
                    throw new ArgumentException("Invalid suite");
                }
            }
        }
        public int Days
        {
            get => _days;
            set
            {
                if (value > 0)
                {
                    _days = value;
                }
                else
                {
                    throw new ArgumentException("Invalid days");
                }
            }
        }

        public void RegisterGuests(List<Person> person)
        {
            if (Suite == null)
            {
                throw new InvalidOperationException("Suite is not initialized.");
            }

            if (People == null)
            {
                People = new List<Person>();
            }

            if (People.Count + person.Count > Suite.capacity)
            {
                throw new ArgumentException($"Over suite capacity. The suite has a capacity of {Suite.capacity} people.");
            }

            People.AddRange(person);
        }

        public void RegisterSuite(Suite suite)
        {
            Suite = suite;
        }

        public int GuestsQuantity()
        {
            int guestsCount = People.Count;
            return guestsCount;
        }

        public string guestsNames()
        {
            string guestsString = string.Join(", ", People.Select(p => p.ToString()));
            return guestsString;
        }

        public decimal TotalValue()
        {
            if (Days > 9)
            {
                decimal discountedTotalValue = Suite.daily * Days * 0.9m;
                return Math.Round(discountedTotalValue, 2);
            }
            decimal totalValue = Suite.daily * Days;
            return Math.Round(totalValue, 2);
        }
    }
}