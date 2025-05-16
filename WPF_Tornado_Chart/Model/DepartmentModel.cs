namespace WPF_Tornado_Chart.Model
{
    public class DepartmentModel
    {
        public DepartmentModel(string deptName, double passStart, double pass, double passEnd)
        {
            DeptName = deptName;
            PassStart = passStart;
            Pass = pass;
            PassEnd = passEnd;
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
