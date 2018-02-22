using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeagueProj.Model;

namespace LeagueProj.ViewModel
{
    class DataViewModel
    {
        public ObservableCollection<Summoner> Summoner { get; set; }
        public ObservableCollection<Matchlist> Matchlist { get; set; }
        public ObservableCollection<Data> Data { get; set; } 
        public void LoadData()
        {
            ObservableCollection<Summoner> summoner = new ObservableCollection<Summoner>();
            summoner.Add(new Summoner
            {

            });
            Summoner = summoner;

            // May want to loop through 20 times to do this for the list.add stuff. Would
            // allow there to be multiple matches on the page for the stackpanel to go
            // through
            ObservableCollection<Matchlist> matchlist = new ObservableCollection<Matchlist>();
            matchlist.Add(new Matchlist
            {

            });
            Summoner = summoner;

            ObservableCollection<Data> data = new ObservableCollection<Data>();
            data.Add(new Data
            {

            });
            Data = data;

            
        }
    }
}
