using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using LeagueProj.Model;

namespace LeagueProj.ViewModel
{
    class viewmodel1
    {
        public ObservableCollection<exampleModel> Coll { get; set; }
        public void LoadExampleModel()
        {
            ObservableCollection<exampleModel> coll = new ObservableCollection<exampleModel>();

            coll.Add(new exampleModel { okay = "ree", notokay = "disaree"});
 
            Coll = coll;
        }
    }
}
