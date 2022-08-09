namespace X1_FEED
{
    internal class X1_LIVE_FEED
    {


            public string Error { get; set; }
            public int ErrorCode { get; set; }
            public string Guid { get; set; }
            public int Id { get; set; }
            public bool Success { get; set; }
            public Value Value { get; set; }
    }

        public class Value
        {
            public string CHIMG { get; set; }
            public int CID { get; set; }
            public string CN { get; set; }
            public int CO { get; set; }
            public int COI { get; set; }
            public int EC { get; set; }
            public int EGC { get; set; }
            public GE[] GE { get; set; }
            public int I { get; set; }
            public int KI { get; set; }
            public string L { get; set; }
            public string LE { get; set; }
            public int LI { get; set; }
            public MEC[] MEC { get; set; }
            public int[] MS { get; set; }
            public int N { get; set; }
            public string O1 { get; set; }
            public int O1C { get; set; }
            public string O1E { get; set; }
            public int O1I { get; set; }
            public string[] O1IMG { get; set; }
            public int[] O1IS { get; set; }
            public string O2 { get; set; }
            public int O2C { get; set; }
            public string O2E { get; set; }
            public int O2I { get; set; }
            public string[] O2IMG { get; set; }
            public int[] O2IS { get; set; }
            public int S { get; set; }
            public string SE { get; set; }
            public string SGI { get; set; }
            public int SI { get; set; }
            public string SN { get; set; }
            public int SS { get; set; }
            public int SSI { get; set; }
            public string STI { get; set; }
            public int T { get; set; }
            public string TN { get; set; }
            public string TNS { get; set; }
            public bool AM { get; set; }
            public int HMH { get; set; }
            public bool OuR { get; set; }
            public int R { get; set; }
            public SC SC { get; set; }
            public SG[] SG { get; set; }
            public bool SVoAP { get; set; }
            public Tw[] TwS { get; set; }
            public int VA { get; set; }
            public string VI { get; set; }
        }

        public class SC
        {
            public int CP { get; set; }
            public string CPS { get; set; }
            public FS FS { get; set; }
            public P[] PS { get; set; }
            public object[] S { get; set; }
            public int TR { get; set; }
        }

        public class FS
        {
        }

        public class P
        {
            public int Key { get; set; }
            public Value1 Value { get; set; }
        }

        public class Value1
        {
            public int S1 { get; set; }
            public int S2 { get; set; }
        }

        public class GE
        {
            public E[][] E { get; set; }
            public int G { get; set; }
        }

        public class E
        {
            public float C { get; set; }
            public int G { get; set; }
            public int T { get; set; }
            public float P { get; set; }
        }

        public class MEC
        {
            public int EC { get; set; }
            public int MT { get; set; }
            public string N { get; set; }
        }

        public class SG
        {
            public int EC { get; set; }
            public int EGC { get; set; }
            public GE1[] GE { get; set; }
            public int I { get; set; }
            public MEC1[] MEC { get; set; }
            public int MG { get; set; }
            public int N { get; set; }
            public int P { get; set; }
            public string PN { get; set; }
            public int SI { get; set; }
            public int SS { get; set; }
            public int T { get; set; }
            public int R { get; set; }
        }

        public class GE1
        {
            public E1[][] E { get; set; }
            public int G { get; set; }
        }

        public class E1
        {
            public float C { get; set; }
            public int G { get; set; }
            public int T { get; set; }
            public float P { get; set; }
            public int CE { get; set; }
        }

        public class MEC1
        {
            public int EC { get; set; }
            public int MT { get; set; }
            public string N { get; set; }
        }

        public class Tw
        {
            public string CN { get; set; }
            public int L { get; set; }
            public string S { get; set; }
            public string SN { get; set; }
        }


}


