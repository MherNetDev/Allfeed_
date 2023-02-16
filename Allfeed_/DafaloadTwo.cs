
namespace Dafager
{
    internal class DafaloadTwo
    {
        public int id { get; set; }
        public string eventType { get; set; }
        public string description { get; set; }
        public Descriptions descriptions { get; set; }
        public bool isRunning { get; set; }
        public Eventpath[] eventPaths { get; set; }
        public string sportCode { get; set; }
        public int mainBookOpenMarketCount { get; set; }
        public int liveOpenMarketCount { get; set; }
        public string feedCode { get; set; }
        public int opponentAId { get; set; }
        public int opponentBId { get; set; }
        public bool settled { get; set; }
        public string slug { get; set; }
        public Market[] markets { get; set; }
        public Opponent[] opponents { get; set; }
        public object[] match { get; set; }
        public object sets { get; set; }
        public object currentPeriod { get; set; }
        public object currentPeriodAbbreviation { get; set; }
        public int currentPeriodNumber { get; set; }
        public object clock { get; set; }
        public object scores { get; set; }
        public object extraTimeScores { get; set; }
        public object penaltyTimeScores { get; set; }
        public bool marketsLimited { get; set; }
        public int betRadarId { get; set; }
        public int ordinalPosition { get; set; }
        public bool liveStreaming { get; set; }
        public long streamingIMGId { get; set; }
        public long streamingPMId { get; set; }
        public string trackerPMId { get; set; }
        public long betgeniusId { get; set; }
        public bool mgEvent { get; set; }
        public bool hasFastMarkets { get; set; }
        public bool showBetradarScoreboard { get; set; }
        public int gameCode { get; set; }
        public object cricketOutcomes { get; set; }
        public string marketSortOrder { get; set; }
        public bool running { get; set; }
        public bool dstevent { get; set; }
    }

    public class Descriptions
    {
        public string ko_KR { get; set; }
        public string en { get; set; }
        public string zh_CN { get; set; }
        public string th_TH { get; set; }
        public string ja_JP { get; set; }
    }

    public class Eventpath
    {
        public int id { get; set; }
        public int parentId { get; set; }
        public string description { get; set; }
        public Descriptions1 descriptions { get; set; }
        public string slug { get; set; }
        public bool eSport { get; set; }
    }

    public class Descriptions1
    {
        public string te_IN { get; set; }
        public string ko_KR { get; set; }
        public string en { get; set; }
        public string hi_IN { get; set; }
        public string vi_VN { get; set; }
        public string zh_CN { get; set; }
        public string es_ES { get; set; }
        public string pt_BR { get; set; }
        public string th_TH { get; set; }
        public string ja_JP { get; set; }
        public string in_ID { get; set; }
        public string tr_TR { get; set; }
        public string zh_TW { get; set; }
    }

    public class Market
    {
        public long id { get; set; }
        public string description { get; set; }
        public Descriptions2 descriptions { get; set; }
        public string status { get; set; }
        public int periodId { get; set; }
        public int marketTypeId { get; set; }
        public Outcome[] outcomes { get; set; }
        public Period period { get; set; }
        public int eventId { get; set; }
        public Markettypeinfo marketTypeInfo { get; set; }
        public float priceDifference { get; set; }
        public long opponentId { get; set; }
        public Book book { get; set; }
        public int instance { get; set; }
        public string imgArenaGroupId { get; set; }
        public object startTimeInRunning { get; set; }
    }

    public class Descriptions2
    {
        public string te_IN { get; set; }
        public string ko_KR { get; set; }
        public string hi_IN { get; set; }
        public string en { get; set; }
        public string es_ES { get; set; }
        public string vi_VN { get; set; }
        public string pt_BR { get; set; }
        public string zh_CN { get; set; }
        public string th_TH { get; set; }
        public string ja_JP { get; set; }
        public string in_ID { get; set; }
        public string pl_PL { get; set; }
        public string tr_TR { get; set; }
    }

    public class Period
    {
        public int id { get; set; }
        public string fullAbbreviation { get; set; }
        public string fullDescription { get; set; }
        public Fulldescriptions fullDescriptions { get; set; }
        public Periodtype periodType { get; set; }
    }

    public class Fulldescriptions
    {
        public string te_IN { get; set; }
        public string ko_KR { get; set; }
        public string en { get; set; }
        public string hi_IN { get; set; }
        public string zh_CN { get; set; }
        public string pt_BR { get; set; }
        public string vi_VN { get; set; }
        public string es_ES { get; set; }
        public string th_TH { get; set; }
        public string ja_JP { get; set; }
        public string in_ID { get; set; }
    }

    public class Periodtype
    {
        public int id { get; set; }
        public bool inRunning { get; set; }
        public int op { get; set; }
    }

    public class Markettypeinfo
    {
        public int id { get; set; }
        public string style { get; set; }
        public int op { get; set; }
    }

    public class Book
    {
        public object[] placeTerms { get; set; }
        public string description { get; set; }
        public Descriptions3 descriptions { get; set; }
        public long id { get; set; }
        public bool current { get; set; }
    }

    public class Descriptions3
    {
        public string en { get; set; }
    }

    public class Outcome
    {
        public long id { get; set; }
        public string description { get; set; }
        public Descriptions4 descriptions { get; set; }
        public int ordinalPosition { get; set; }
        public long opponentId { get; set; }
        public long optionalOpponentId { get; set; }
        public Consolidatedprice consolidatedPrice { get; set; }
        public float extraKey1 { get; set; }
        public float extraKey2 { get; set; }
        public long teamId { get; set; }
        public long marketId { get; set; }
        public bool withdrawn { get; set; }
        public bool hidden { get; set; }
    }

    public class Descriptions4
    {
        public string ko_KR { get; set; }
        public string en { get; set; }
        public string zh_CN { get; set; }
        public string th_TH { get; set; }
        public string ja_JP { get; set; }
        public string ur_PK { get; set; }
        public string te_IN { get; set; }
        public string hi_IN { get; set; }
        public string pt_BR { get; set; }
        public string es_ES { get; set; }
        public string vi_VN { get; set; }
        public string in_ID { get; set; }
    }

    public class Consolidatedprice
    {
        public Currentprice currentPrice { get; set; }
        public object penultimatePrice { get; set; }
        public object antepenultimatePrice { get; set; }
        public long outcomeId { get; set; }
    }

    public class Currentprice
    {
        public long id { get; set; }
        public float _decimal { get; set; }
        public float spread { get; set; }
        public float spread2 { get; set; }
        public string format { get; set; }
    }

    public class Opponent
    {
        public int id { get; set; }
        public string description { get; set; }
        public Descriptions5 descriptions { get; set; }
    }

    public class Descriptions5
    {
        public string ko_KR { get; set; }
        public string en { get; set; }
        public string zh_CN { get; set; }
        public string th_TH { get; set; }
        public string ja_JP { get; set; }
    }


}