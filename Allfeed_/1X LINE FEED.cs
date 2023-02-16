namespace X1_FEEDLINE
{
    internal class X1_LINE_FEED
    {

       
            public string Error { get; set; }
            public int ErrorCode { get; set; }
            public string Guid { get; set; }
            public int Id { get; set; }
            public bool Success { get; set; }
            public Value[] Value { get; set; }
        }

        public class Value
        {
            public AE[] AE { get; set; }
            public string CHIMG { get; set; }
            public int CI { get; set; }
            public int CID { get; set; }
            public string CN { get; set; }
            public int COI { get; set; }
            public E[] E { get; set; }
            public int EC { get; set; }
            public int HS { get; set; }
            public bool HSI { get; set; }
            public bool HSRT { get; set; }
            public int I { get; set; }
            public int KI { get; set; }
            public string L { get; set; }
            public string LE { get; set; }
            public int LI { get; set; }
            public MIO MIO { get; set; }
            public MI[] MIS { get; set; }
            public int[] MS { get; set; }
            public int N { get; set; }
            public string O1 { get; set; }
            public int O1C { get; set; }
            public string O1CT { get; set; }
            public string O1E { get; set; }
            public int O1I { get; set; }
            public string[] O1IMG { get; set; }
            public int[] O1IS { get; set; }
            public string O2 { get; set; }
            public int O2C { get; set; }
            public string O2CT { get; set; }
            public string O2E { get; set; }
            public int O2I { get; set; }
            public string[] O2IMG { get; set; }
            public int[] O2IS { get; set; }
            public int S { get; set; }
            public string SE { get; set; }
            public int SGC { get; set; }
            public string SGI { get; set; }
            public int SI { get; set; }
            public string SIMG { get; set; }
            public string SN { get; set; }
            public int SS { get; set; }
            public int SSI { get; set; }
            public int SST { get; set; }
            public string STI { get; set; }
            public int SmI { get; set; }
            public int T { get; set; }
            public string TN { get; set; }
            public string TNS { get; set; }
            public int B { get; set; }
            public string[] RLI { get; set; }
            public bool GSE { get; set; }
            public int GVE { get; set; }
            public bool HLU { get; set; }
            public int IV { get; set; }
            public string V { get; set; }
            public string VE { get; set; }
        }

        public class MIO
        {
            public string Loc { get; set; }
            public string SSc { get; set; }
            public string TSt { get; set; }
        }

        public class AE
        {
            public int G { get; set; }
            public ME[] ME { get; set; }
        }

        public class ME
        {
            public float C { get; set; }
            public int G { get; set; }
            public int T { get; set; }
            public float P { get; set; }
            public int CE { get; set; }
        }

        public class E
        {
            public float C { get; set; }
            public int G { get; set; }
            public int T { get; set; }
            public int CE { get; set; }
            public float P { get; set; }
            public bool B { get; set; }
        }

        public class MI
        {
            public int K { get; set; }
            public string V { get; set; }
        }

    }
    