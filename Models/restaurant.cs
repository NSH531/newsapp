using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace News.Web.Models
{
    public class restaurant
    {
        public Google.Apis.Services.BaseClientService g;

        public string name;
        public string addr;
        public enum type {falafel,shawarma,cafe,sushi };
        public type l;
        public List<meal> menu;
        
    }
    public class meal
    {
        public string name;
        public double price;

    }
}