﻿using Spectre.Console;
using System.Diagnostics;

namespace AsyncTest
{
    static class Program
    {
        static async Task Main(string[] args)
        {
            Stopwatch stopw = new Stopwatch();
            stopw.Start();

            string selectedFont = GetRandomFont();

            var font = FigletFont.Load($"Fonts/{selectedFont}");

            AnsiConsole.Write(new FigletText(font, "Asynchronous Programming with async and await").LeftJustified().Color(Color.Red));
            PourCoffee();
            AnsiConsole.MarkupLine("[bold darkorange3]coffee is ready[/]");

            var eggsTask = FryEggsAsync(2);
            var baconTask = FryBaconAsync(3);
            var toastTask = MakeToastWithButterAndJamAsync(2);

            var taskMessages = new Dictionary<Task, string>
            {
                { eggsTask, "eggs are ready" },
                { baconTask, "bacon is ready" },
                { toastTask, "toast is ready" }
            };

            var breakfastTasks = taskMessages.Keys.ToList();

            while (breakfastTasks.Count > 0)
            {
                Task finishedTask = await Task.WhenAny(breakfastTasks);
                AnsiConsole.MarkupLine($"[bold green1]{taskMessages[finishedTask]}[/]");
                await finishedTask;
                breakfastTasks.Remove(finishedTask);
            }

            PourOJ();
            AnsiConsole.MarkupLine("[bold orange1]Orange Juice is ready[/]");
            AnsiConsole.MarkupLine("[bold steelblue1_1]Breakfast is ready[/]");

            stopw.Stop();
            TimeSpan ts = stopw.Elapsed;
            string elapsedTime = $"{ts.Minutes}m {ts.Seconds}s {ts.Milliseconds}ms";
            AnsiConsole.MarkupLine($"[bold white]Elapsed time: [bold red]{elapsedTime}[/][/]");
        }

        #region Async Methods
        private static async Task MakeToastWithButterAndJamAsync(int number)
        {
            await ToastBreadAsync(number);
            ApplyButter();
            ApplyJam();
        }

        private static async Task ToastBreadAsync(int slices)
        {
            for (int slice = 0; slice < slices; slice++)
            {
                AnsiConsole.MarkupLine("[bold tan]Putting a slice of bread in the toaster[/]");
            }
            AnsiConsole.MarkupLine("[bold tan]Start toasting...[/]");
            await Task.Delay(3000);
            AnsiConsole.MarkupLine("[bold tan]Remove toast from toaster[/]");
        }

        private static async Task FryBaconAsync(int slices)
        {
            AnsiConsole.MarkupLine($"[bold lightsalmon3_1]putting [tan]{slices}[/] slices of bacon in the pan[/]");
            AnsiConsole.MarkupLine("[bold lightsalmon3_1]cooking first side of bacon...[/]");
            await Task.Delay(3000);
            for (int slice = 0; slice < slices; slice++)
            {
                AnsiConsole.MarkupLine("[bold lightsalmon3_1]flipping a slice of bacon[/]");
            }
            AnsiConsole.MarkupLine("[bold lightsalmon3_1]cooking the second side of bacon...[/]");
            await Task.Delay(3000);
            AnsiConsole.MarkupLine("[bold lightsalmon3_1]Put bacon on plate[/]");
        }

        private static async Task FryEggsAsync(int howMany)
        {
            AnsiConsole.MarkupLine("[bold white]Warming the egg pan...[/]");
            await Task.Delay(3000);
            AnsiConsole.MarkupLine($"[bold white]cracking [bold red]{howMany}[/] eggs[/]");
            AnsiConsole.MarkupLine("cooking the eggs ...");
            await Task.Delay(3000);
            AnsiConsole.MarkupLine("Put eggs on plate");
        }
        #endregion

        #region Sync Methods
        private static void PourOJ()
        {
            AnsiConsole.MarkupLine("[bold orange1]Pouring orange juice[/]");
        }

        private static void ApplyJam() =>
            AnsiConsole.MarkupLine("[bold tan]Putting jam on the toast[/]");

        private static void ApplyButter() =>
            AnsiConsole.MarkupLine("[bold tan]Putting butter on the toast[/]");

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
        #endregion
    }
}