using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AHCWebDeveloperExam.Models
{
    public class OrderSummary
    {
        public int Id { get; set; }
        public DateTime PeriodDate { get; set; }
        public string PeriodLabel { get; set; }
        public int Ordered { get; set; }
        public int Shipped { get; set; }
        public int Remainder { get; set; }
        public double TotalOrderedAmount { get; set; }
        public double TotalShippedAmount { get; set; }

        public override string ToString()
        {
            return String.Format("Id: {0}, PeriodDate: {1}, PeriodLabel:{2}, Ordered:{3}, Shipped:{4}, Remainder:{5}, TotalOrderedAmount:{6}, TotalShippedAmount:{7}",
                Id, PeriodDate, PeriodLabel, Ordered, Shipped, Remainder, TotalOrderedAmount, TotalShippedAmount);
        }
    }
}