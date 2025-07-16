using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Tornado_Chart.Model
{
    public class DataModel
    {
        public DataModel(DateTime year, double export, double import)
        {
            Year = year;
            Export = export;
            Import = import;
        }

        public DateTime Year
        {
            get;
            set;
        }

        public double Export
        {
            get;
            set;
        }

        public double Import
        {
            get;
            set;
        }
    }
}
