using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestToWork.Models
{
    public class ShopAllInfViewModel
    {
        public int ShopsId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int ModeOfOperation { get; set; }
        public Dictionary<string, string[]> DaysOfWeek { get; set; }
    }
}