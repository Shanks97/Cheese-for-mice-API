using API_Library.Manager;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cheese_for_mice_API
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            Console.WriteLine("starting");
            try
            {
                //Mouse
                var user = "Tocutoeltuco";                
                var mouse = await MouseManager.GetMouse(user);

                //Tribe
                var tribe = await TribeManager.GetTribe("Runtime error");
                var tribe_1 = await TribeManager.GetTribeByUser(user);
                var tribe_2 = await TribeManager.SearchTribe("Runtime e");
                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
