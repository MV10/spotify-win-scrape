using System.Diagnostics;

namespace spotify_win_scrape;

internal class Program
{
    static void Main(string[] args)
    {
        string last = string.Empty;
        bool running = true;
        while(running)
        {
            Thread.Sleep(500);
            if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape) running = false;

            var p = Process.GetProcessesByName("SPOTIFY");
            if (p.Length > 0)
            {
                if(last != p[0].MainWindowTitle)
                {
                    last = p[0].MainWindowTitle;
                    Console.WriteLine(last);
                }
            }
        }
    }
}
