namespace FonBet_Parser_JS_teams
{


    internal class FBTeams
    {

        public long packetVersion { get; set; }
        public int fromVersion { get; set; }
        public int catalogTablesVersion { get; set; }
        public int catalogSpecialTablesVersion { get; set; }
        public int catalogEventViewVersion { get; set; }
        public int sportBasicMarketsVersion { get; set; }
        public int sportKindsVersion { get; set; }
        public int topCompetitionsVersion { get; set; }
        public Sport[] sports { get; set; }
        public Event[] events { get; set; }
        public object[] eventBlocks { get; set; }
        public Eventmisc[] eventMiscs { get; set; }
        public Liveeventinfo[] liveEventInfos { get; set; }
        public Customfactor[] customFactors { get; set; }
    }

    public class Sport
    {
        public int id { get; set; }
        public string kind { get; set; }
        public string sortOrder { get; set; }
        public string name { get; set; }
        public int parentId { get; set; }
        public int[] parentIds { get; set; }
    }

    public class Event
    {
        public int id { get; set; }
        public string sortOrder { get; set; }
        public int level { get; set; }
        public int num { get; set; }
        public int sportId { get; set; }
        public int kind { get; set; }
        public int rootKind { get; set; }
        public int team1Id { get; set; }
        public int team2Id { get; set; }
        public string team1 { get; set; }
        public string team2 { get; set; }
        public string name { get; set; }
        public int startTime { get; set; }
        public string place { get; set; }
        public string statisticsType { get; set; }
        public int priority { get; set; }
        public int[] tv { get; set; }
        public int parentId { get; set; }
    }

    public class Eventmisc
    {
        public int id { get; set; }
        public int liveDelay { get; set; }
        public int score1 { get; set; }
        public int score2 { get; set; }
        public int timerDirection { get; set; }
        public int timerSeconds { get; set; }
        public long timerUpdateTimestampMsec { get; set; }
    }

    public class Liveeventinfo
    {
        public int eventId { get; set; }
        public string timer { get; set; }
        public int timerSeconds { get; set; }
        public int timerDirection { get; set; }
        public long timerTimestampMsec { get; set; }
        public string scoreFunction { get; set; }
        public Score[][] scores { get; set; }
        public Subscore[] subscores { get; set; }
    }

    public class Score
    {
        public string c1 { get; set; }
        public string c2 { get; set; }
        public string title { get; set; }
    }

    public class Subscore
    {
        public string kindId { get; set; }
        public string kindName { get; set; }
        public string c1 { get; set; }
        public string c2 { get; set; }
    }

    public class Customfactor
    {
        public int e { get; set; }
        public int countAll { get; set; }
        public Factor[] factors { get; set; }
    }

    public class Factor
    {
        public int f { get; set; }
        public float v { get; set; }
        public int p { get; set; }
        public string pt { get; set; }
    }



}
