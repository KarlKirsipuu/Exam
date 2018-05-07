using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjutus3
{
    class Date
    {
        public int MaxYear { get; set; }
        public int MinYear { get; set; }

        public Date(int maxYear, int minYear)
        {
            MaxYear = maxYear;
            MinYear = minYear;
        }

        public DateTime GenerateRandomDay()
        {
            int year, month;
            Random r = new Random();
            return new DateTime(year = r.Next(MinYear, MaxYear), month = r.Next(1, 13), r.Next(1, DateTime.DaysInMonth(year, month) + 1), r.Next(0, 24), r.Next(0, 60), r.Next(0, 60));
        }
    }
}
