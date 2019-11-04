using Microsoft.Extensions.Logging;
using SearchFightWeb.Controllers;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace SearchFightWeb
{
    public class Initializer
    {
        public static void LaunchingApp(string[] args)
        {
            if (args == null || args.Length == 0)
            {

                Console.WriteLine("Is required  \"param1\" and \"param2\" to start the fight ");
                Console.WriteLine("Press any key to exit...");
            }
            if (args.Length >= 3)
            {
                Console.WriteLine("This app only support 2 params, more params are supported later. Maybe...");
                Console.WriteLine("Press any key to exit...");
            }
            else
            {/*
                string search1 = args[0];
                string search2 = args[1];

                //GoogleSearch FirstGoogleSearch = GoogleController.GoogleWebResult(search1);
                //GoogleSearch SecondGoogleSearch = GoogleController.GoogleWebResult(search2);

                BingSearch FirstBingSearch = BingController.BingWebResult(search1);
                BingSearch SecondBingSearch = BingController.BingWebResult(search2);

                //Print 1
                Printer.PrintYellow($"\"{search1}\""); Printer.Print(" searchs on ");
                //Printer.PrintBlue($"{FirstGoogleSearch.engine}: "); Printer.PrintGray($"{FirstGoogleSearch.number_of_results}"); Printer.Print(" results vs ");
                Printer.PrintBlue($"{FirstBingSearch.engine}: "); Printer.PrintGray($"{FirstBingSearch.webPages.totalEstimatedMatches} "); Printer.Print("results \n");

                //Print 2
                Printer.PrintYellow($"\"{search2}\""); Printer.Print(" searchs on ");
                //Printer.PrintBlue($"{SecondGoogleSearch.engine}: "); Printer.PrintGray($"{FirstGoogleSearch.number_of_results}"); Printer.Print(" results vs ");
                Printer.PrintBlue($"{SecondBingSearch.engine}: "); Printer.PrintGray($"{SecondBingSearch.webPages.totalEstimatedMatches} "); Printer.Print("results \n");

                //Print 3
                //WinnerController.TotalWinner(FirstGoogleSearch, SecondGoogleSearch, FirstBingSearch, SecondBingSearch);
                */
                Console.WriteLine();
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }

    public interface IData
    {
        string Get();
        void Append(string data);
        void Clear();
    }

    public class Data : IData
    {
        private string _data = "-";

        public void Append(string data)
        {
            _data += data;
        }

        public string Get()
        {
            return _data;
        }

        public void Clear()
        {
            _data = String.Empty;
        }
    }
}
