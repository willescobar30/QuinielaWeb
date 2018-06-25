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
        public  static RootObject worldCupDara;

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

       public Team getTeamByfifaCode(String fifaCode)
        {
            foreach (Team  user in worldCupDara.teams)
            {
                synchronizationContext.Post(new SendOrPostCallback(value =>
                {
                    //UPDATE ComboBox
                    //myComboBox.Items.Add(value as string);

                }), user.fifaCode);
            }



            return null;
        }


    }

    class User
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
