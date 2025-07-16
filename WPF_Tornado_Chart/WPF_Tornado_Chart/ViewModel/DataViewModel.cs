using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_Tornado_Chart.Model;

namespace WPF_Tornado_Chart.ViewModel
{
    public class DataViewModel
    {
        public DataViewModel()
        {
            Models = new ObservableCollection<DataModel>();

            Models.Add(new DataModel(new DateTime(2000, 7, 1), 175, -125));
            Models.Add(new DataModel(new DateTime(2001, 7, 1), 190, -125));
            Models.Add(new DataModel(new DateTime(2002, 7, 1), 210, -150));
            Models.Add(new DataModel(new DateTime(2003, 7, 1), 210, -200));
            Models.Add(new DataModel(new DateTime(2004, 7, 1), 260, -220));
            Models.Add(new DataModel(new DateTime(2005, 7, 1), 250, -140));
            Models.Add(new DataModel(new DateTime(2006, 7, 1), 220, -210));
            Models.Add(new DataModel(new DateTime(2007, 7, 1), 240, -290));
            Models.Add(new DataModel(new DateTime(2008, 7, 1), 375, -320));
            Models.Add(new DataModel(new DateTime(2009, 7, 1), 180, -325));
        }

        public ObservableCollection<DataModel> Models
        {
            get;
            set;
        }
    }
}
