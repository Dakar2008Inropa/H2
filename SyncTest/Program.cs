using Spectre.Console;
using System.Diagnostics;

namespace SyncTest
{
    static class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopw = new Stopwatch();
            stopw.Start();

            string selectedFont = GetRandomFont();

            var font = FigletFont.Load($"Fonts/{selectedFont}");

            AnsiConsole.Write(new FigletText(font, "Synchronous Programming").LeftJustified().Color(Color.Red));

            PourCoffee();
            AnsiConsole.MarkupLine("[bold darkorange3]coffee is ready[/]");

            FryEggs(2);
            AnsiConsole.MarkupLine("[bold green1]eggs are ready[/]");

            FryBacon(3);
            AnsiConsole.MarkupLine("[bold green1]bacon is ready[/]");

            ToastBread(2);
            ApplyButter();
            ApplyJam();
            AnsiConsole.MarkupLine("[bold green1]toast is ready[/]");

            PourOJ();
            AnsiConsole.MarkupLine("[bold green1]toast is ready[/]");


            AnsiConsole.MarkupLine("[bold orange1]Orange juice is ready[/]");
            AnsiConsole.MarkupLine("[bold steelblue1_1]Breakfast is ready![/]");

            stopw.Stop();
            TimeSpan ts = stopw.Elapsed;
            string elapsedTime = $"{ts.Minutes}m {ts.Seconds}s {ts.Milliseconds}ms";
            AnsiConsole.MarkupLine($"[bold white]Elapsed time: [bold red]{elapsedTime}[/][/]");
        }

        private static void PourOJ()
        {
            AnsiConsole.MarkupLine("[bold orange1]Pouring orange juice[/]");
        }

        private static void ApplyJam() =>
            AnsiConsole.MarkupLine("[bold tan]Putting jam on the toast[/]");

        private static void ApplyButter() =>
            AnsiConsole.MarkupLine("[bold tan]Putting butter on the toast[/]");

        private static void ToastBread(int slices)
        {
            for (int slice = 0; slice < slices; slice++)
            {
                AnsiConsole.MarkupLine("[bold tan]Putting a slice of bread in the toaster[/]");
            }
            AnsiConsole.MarkupLine("[bold tan]Start toasting...[/]");
            Task.Delay(3000).Wait();
            AnsiConsole.MarkupLine("[bold tan]Remove toast from toaster[/]");
        }

        private static void FryBacon(int slices)
        {
            AnsiConsole.MarkupLine($"[bold lightsalmon3_1]putting [tan]{slices}[/] slices of bacon in the pan[/]");
            AnsiConsole.MarkupLine("[bold lightsalmon3_1]cooking first side of bacon...[/]");
            Task.Delay(3000).Wait();
            for (int slice = 0; slice < slices; slice++)
            {
                AnsiConsole.MarkupLine("[bold lightsalmon3_1]flipping a slice of bacon[/]");
            }
            AnsiConsole.MarkupLine("[bold lightsalmon3_1]cooking the second side of bacon...[/]");
            Task.Delay(3000).Wait();
            AnsiConsole.MarkupLine("[bold lightsalmon3_1]Put bacon on plate[/]");
        }

        private static void FryEggs(int howMany)
        {
            AnsiConsole.MarkupLine("[bold white]Warming the egg pan...[/]");
            Task.Delay(3000).Wait();
            AnsiConsole.MarkupLine($"[bold white]cracking [bold red]{howMany}[/] eggs[/]");
            AnsiConsole.MarkupLine("cooking the eggs ...");
            Task.Delay(3000).Wait();
            AnsiConsole.MarkupLine("Put eggs on plate");
        }

        private static void PourCoffee()
        {
            AnsiConsole.MarkupLine("[bold darkorange3]Pouring coffee[/]");
        }

        private static string GetRandomFont()
        {
            List<string> fonts =
            [
                "larry3d.flf",
                "univers.flf",
                "smslant.flf",
                "standard.flf",
                "starwars.flf",
                "thick.flf",
                "thin.flf",
            ];

            Random random = new Random();
            int index = random.Next(fonts.Count);
            return fonts[index];
        }
    }
}