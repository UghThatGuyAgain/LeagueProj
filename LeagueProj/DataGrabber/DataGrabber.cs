using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeagueProj.Model;
using RiotSharp;

namespace LeagueProj.DataGrabber
{
    public class DataGrabber
    {
        RiotApi api = RiotApi.GetDevelopmentInstance("");

        public ObservableCollection<Summoner> GetSummoner(string summonerName)
        {
            ObservableCollection<Summoner> summoner = new ObservableCollection<Summoner>();
            var summonerObject = api.GetSummonerByName(RiotSharp.Misc.Region.na, summonerName);
            summoner.Add(new Summoner
            {
                summonerName = summonerObject.Name,
                summonerLevel = summonerObject.Level.ToString(),
                profilePicUrl = ""

            });
            return summoner;
        }
        public ObservableCollection<Matchlist> GetMatchlist(long gameId)
        {
            ObservableCollection<Matchlist> matchlist = new ObservableCollection<Matchlist>();
            

            return matchlist;
        }
    }
}
