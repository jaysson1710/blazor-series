using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp1.Client.Model
{
    public class Weather
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }

        public int Grade { get; set; }

        public string Summary { get; set; }
    }
}
