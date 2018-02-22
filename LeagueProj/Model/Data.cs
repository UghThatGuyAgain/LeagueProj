using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueProj.Model
{
    public class Main{}
    public class Summoner
    {
        // Summoner variables
        public string summonerLevel { get; set; }
        public string summonerName { get; set; }
        public string profilePicUrl { get; set; }
    }
    public class Matchlist
    {
        // MatchList variables
        public string lane { get; set; }
        public int gameId { get; set; }
        public int champId { get; set; }
        public int queueId { get; set; }
        public string role { get; set; }
        public long timestamp { get; set; }
    }
    public class Data
    {
        // Match variables
        public int participantId { get; set; }
        public int gameMode { get; set; }
        public List<Array> participants { get; set; }
        public long creationTime { get; set; }
        public Boolean win { get; set; }

        // Player data
        public Array runes { get; set; }
        public string spell1 { get; set; }
        public string spell2 { get; set; }

        public object stats { get; set; }
    }
}
