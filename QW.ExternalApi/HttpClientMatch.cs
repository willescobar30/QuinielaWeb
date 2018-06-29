using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;
using QW.ExternalApi.Models;

namespace QW.ExternalApi
{
    public class HttpClientMatch
    {

        private static SynchronizationContext synchronizationContext;
        public static RootObject worldCupDara;

        public static async void downloadJSONData()
        {

            try
            {
                //PERFORM IN BACKGROUND
                //  await Task.Run(async () =>
                // {
                worldCupDara = await "https://raw.githubusercontent.com/lsv/fifa-worldcup-2018/master/data.json".GetJsonAsync<RootObject>();

                //Console.WriteLine(users.ToString());
                /* foreach (Team user in worldCupDara.teams)
                 {
                     synchronizationContext.Post(new SendOrPostCallback(value =>
                     {
                         //UPDATE ComboBox


                     }), user.Name);
                 }*/
                // });
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        //FUNCTION TO GET ALL TEAMS
        public static List<Team> getTeams()
        {
            List<Team> teams = null;
            teams = worldCupDara.teams;
            foreach (var item in teams)
            {

                Console.WriteLine("id: " + item.fifaCode);

            }
            return teams;
        }

        //FUNCTION TO GET ALL STADIUMS
        public static List<Stadium> getStadiums()
        {
            List<Stadium> stadiums = null;
            stadiums = worldCupDara.stadiums;
            foreach (var item in stadiums)
            {

                Console.WriteLine("id: " + item.name);

            }
            return stadiums;
        }

        public static List<Match10> getGroupMatches()
        {
            List<Match10> groupMatches = null;
           // downloadJSONData();
            groupMatches = worldCupDara.groups.a.matches;
            groupMatches.AddRange(worldCupDara.groups.b.matches);
            groupMatches.AddRange(worldCupDara.groups.c.matches);
            groupMatches.AddRange(worldCupDara.groups.d.matches);
            groupMatches.AddRange(worldCupDara.groups.e.matches);
            groupMatches.AddRange(worldCupDara.groups.f.matches);
            groupMatches.AddRange(worldCupDara.groups.g.matches);
            groupMatches.AddRange(worldCupDara.groups.h.matches);

            return groupMatches;
        }


        public static List<Match10> getKnockoutMatches()
        {
            List<Match10> knockoutmatches = null;

            knockoutmatches = worldCupDara.knockout.round_16.matches;
            knockoutmatches.AddRange(worldCupDara.knockout.round_8.matches);
            knockoutmatches.AddRange(worldCupDara.knockout.round_4.matches);
            knockoutmatches.AddRange(worldCupDara.knockout.round_2.matches);
            knockoutmatches.AddRange(worldCupDara.knockout.round_2_loser.matches);


            return knockoutmatches;
        }

        //FUNCTION TO GET ALL MATCHES
        public static List<Match10> getAllMatches()
        {
           
            List<Match10> Allmatches = null;
            //downloadJSONData();
            Allmatches = getGroupMatches();
            Allmatches.AddRange(getKnockoutMatches());
            Console.WriteLine(Allmatches.Count);
            return Allmatches;
        }





    }


}
