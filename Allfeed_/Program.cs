using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using X1_FEED;
using X1_All_EVENTS;
using System.Collections;

namespace Allfeed_
{
    

    class Program

    {
        public static double P1;
        public static double P2;
        public static int RoundP1;
        public static int RoundP2;
        int b = 0;

        public static int[] C_Events_Index = new int[1000];
        public static int ChooseEvent;
        public static string Event_URL;
        HttpClient client = new HttpClient();
        public static int SportInt;

        

        public static async Task Main(string[] args)
        {
         

        

            Console.WriteLine("1  - football"+"\n"+
                              "2  - Ice Hockey"+ "\n" +
                              "3  - Basketball" + "\n" +
                              "4  - Tennis" + "\n" +
                              "5  - " + "\n" +
                              "6  - Volleyball" + "\n" +
                              "7  - " + "\n" +
                              "8  - Handball" + "\n" +
                              "9  - " + "\n" +
                              "10 - Table Tennis" + "\n" +
                              "40 - Esports");
          SportInt = Convert.ToInt32(Console.ReadLine());
          Program program = new Program();
          await program.GetSportEvents();

        }


        public async Task GetSportEvents()
        {
            Console.Clear();
            string response = await client.GetStringAsync("https://1xbet.com/LiveFeed/Get1x2_VZip?sports="+ SportInt + "&count=50&mode=4&country=15&getEmpty=true&noFilterBlockEvent=true");

            var Sports_data = JsonConvert.DeserializeObject<X1_EVENTSSEARCH>(response);
            Array.Resize(ref C_Events_Index, Sports_data.Value.Length);

            for (int i = 0; i < Sports_data.Value.Length; i++)
            {
                if (Sports_data.Value[i].O1 != null)
                {
                    C_Events_Index[i] = Sports_data.Value[i].I;
                    Console.WriteLine(i+"  "+Sports_data.Value[i].O1 + " - " + Sports_data.Value[i].O2 + "  -  " + Sports_data.Value[i].I);

                }else { break; }
            }
            ChooseEvent = Convert.ToInt32(Console.ReadLine());
            ChooseEvent = Sports_data.Value[ChooseEvent].I;
            Event_URL = @"https://1xbet.com/LiveFeed/GetGameZip?id=" + ChooseEvent + "&lng=ru&cfview=0&isSubGames=true&GroupEvents=true&allEventsGroupSubGames=true&countevents=250&grMode=2&marketType=1&isNewBuilder=true";

            //Event_URL = @"https://1xbet.com/LiveFeed/GetGameZip?id=390799183&lng=ru&cfview=0&isSubGames=true&GroupEvents=true&allEventsGroupSubGames=true&countevents=250&grMode=2&marketType=1&isNewBuilder=true";

            Program program = new Program();
            await program.GetLiveFeed();

        }

        public async Task GetLiveFeed()
        {
            var OddsNum = new Dictionary<int, string>()
            {
                [1] = "Исход",
                [2] = "Двойной шанс",
                [3] = "Фора",
                [4] = "Тотал",
                [5] = "ТоталКом1",
                [6] = "ТоталКом2",
                [11] = "Следующий гол",
                [21] = "Обе Забьют",
                [33] = "Точный счёт",
                [120] = "Овертайм",
                [292] = "Выиграет Раунд",
                [4196] = "1-ый пистолетный раунд",
                [4197] = "2-ой пистолетный раунд",
                [751] = "Гонка до",
                [752] = "Тотал по картам",
                [753] = "Фора по картам",
                [911] = "Тотал раундов чет/нечет",
                [1007] = "Азиатский тотал",
                [1008] = "Азиатская Фора",
                [1512] = "Тотал по картам чет/нечет ",
                [2476] = "Азиатский индивидуальный тотал 1-го",

            };



            var OddsNumT = new Dictionary<int, string>()
            {
           
                [1] = "Исход П1",
                [2] = "Ничья",
                [3] = "ИсходП2",
                [7] = "Фора1",
                [8] = "Фора2",
                [9] = "ТоталБ",
                [10] = "ТоталМ",
                [11] = "ТоталБ Ком1",
                [12] = "ТоталМ Ком1",
                [13] = "ТоталБ Ком2",
                [14] = "ТоталМ Ком2",
                [731] = "Точный счёт",
                [759] = "Овертайм Да",
                [761] = "Овертайм Нет",
                [1365] = "Раунд Ком1",
                [1366] = "Раунд Ком2",
                [2822] = "Ком 1 Гонка до",
                [2823] = "Ком 1 Гонка до",
                [2824] = "Тотал по картам 2.5Б",
                [2825] = "Тотал по картам 2.5М",
                [2826] = "1 Фора по картам",
                [2827] = "2 Фора по картам",
                [3508] = "Тотал раундов Чётный",
                [3509] = "Тотал раундов Нечётный",
                [5167] = "Тотал по картам Чётный",
                [5168] = "Тотал по картам Нечётный",
                [13292] = "(1)Пистолетный раунд Ком1",
                [13293] = "(1)Пистолетный раунд Ком2",
                [13294] = "(2)Пистолетный раунд Ком1",
                [13295] = "(2)Пистолетный раунд Ком2",
               

            };
            //  for 
              for (; ; )
             {

            string responseFeed = await client.GetStringAsync(Event_URL);
            var Event_Feed = JsonConvert.DeserializeObject<X1_LIVE_FEED>(responseFeed);
            P1 = Event_Feed.Value.GE[0].E[0][0].C;
            Console.Clear();
           
            for (int i = 0; i < Event_Feed.Value.GE.Length; i++)
            {
                for (int j = 0; j < Event_Feed.Value.GE[i].E.Length ; j++)
                {
                    for (int c = 0; c < Event_Feed.Value.GE[i].E[j].Length; c++)
                    {
                    
                        Console.WriteLine(OddsNumT[Event_Feed.Value.GE[i].E[j][c].T] + "  " + Event_Feed.Value.GE[i].E[j][c].P + "   -   " + Event_Feed.Value.GE[i].E[j][c].C);
                    }
                }
                Console.WriteLine("");
            }


            Console.WriteLine("");
            {

                for (int i = 0; i < Event_Feed.Value.SG.Length; i++)
                {
                    Console.WriteLine("Карта "+(++i));
                    --i;
                    for (int m = 0; m < Event_Feed.Value.SG[i].GE.Length; m++)
                    {
                        for (int j = 0; j < Event_Feed.Value.SG[i].GE[m].E.Length; j++)
                        {
                            for (int c = 0; c < Event_Feed.Value.SG[i].GE[m].E[j].Length; c++)
                            {
                                Console.WriteLine(OddsNumT[Event_Feed.Value.SG[i].GE[m].E[j][c].T] + "  " + Event_Feed.Value.SG[i].GE[m].E[j][c].P + " - " + Event_Feed.Value.SG[i].GE[m].E[j][c].C);
                            
                            }
                            
                        }
                            Console.WriteLine("");
                        }

               
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.ReadLine();
                }
            }
         
            // Task.Delay(1000).Wait();
        }


        }


    }
 
}