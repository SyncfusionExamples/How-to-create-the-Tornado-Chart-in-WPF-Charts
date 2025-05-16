using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_Tornado_Chart.Model;

namespace WPF_Tornado_Chart.ViewModel
{
    public class DepartmentViewModel
    {
        public DepartmentViewModel()
        {
            Models = new ObservableCollection<DepartmentModel>();

            Models.Add(new DepartmentModel("CSE", 5, 50, 95));
            Models.Add(new DepartmentModel("ECE", 25, 50, 75));
            Models.Add(new DepartmentModel("EEE", 30, 50, 70));
            Models.Add(new DepartmentModel("Mining", 35, 50, 65));
            Models.Add(new DepartmentModel("Civil", 15, 50, 85));
            Models.Add(new DepartmentModel("EI", 20, 50, 80));
            Models.Add(new DepartmentModel("IT", 30, 50, 70));
        }

        public ObservableCollection<DepartmentModel> Models
        {
            get;
            set;
        }
    }
}
