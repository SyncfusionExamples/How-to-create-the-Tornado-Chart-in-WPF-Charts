using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Tornado_Chart.Model
{
    public class DepartmentModel
    {
        public DepartmentModel(string deptname, double passstart, double pass, double passend)
        {
            DeptName = deptname;
            PassStart = passstart;
            Pass = pass;
            PassEnd = passend;
        }

        public string DeptName
        {
            get;
            set;
        }

        public double PassStart
        {
            get;
            set;
        }

        public double Pass
        {
            get;
            set;
        }

        public double PassEnd
        {
            get;
            set;
        }
    }
}
