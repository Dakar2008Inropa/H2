using Spectre.Console;

namespace AsyncTest
{
    internal interface IBacon { }
    internal interface ICoffee { }
    internal interface IEgg { }
    internal interface IJuice { }
    internal interface IToast { }

    static class Program
    {
        static async Task Main(string[] args)
        {
            string selectedFont = GetRandomFont();

            var font = FigletFont.Load($"Fonts/{selectedFont}");

            AnsiConsole.Write(new FigletText(font, "Asynchronous programming with async and await").LeftJustified().Color(Color.Red));
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
                Console.WriteLine(taskMessages[finishedTask]);
                await finishedTask;
                breakfastTasks.Remove(finishedTask);
            }

            PourOJ();
            AnsiConsole.MarkupLine("[bold orange1]Orange Juice is ready[/]");
            AnsiConsole.MarkupLine("[bold steelblue1_1]Breakfast is ready[/]");
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
            List<string> fonts = new List<string>();
            fonts.Add("larry3d.flf");
            fonts.Add("univers.flf");
            fonts.Add("smslant.flf");
            fonts.Add("standard.flf");
            fonts.Add("starwars.flf");
            fonts.Add("thick.flf");
            fonts.Add("thin.flf");

            Random random = new Random();
            int index = random.Next(fonts.Count);
            return fonts[index];
        }
        #endregion
    }
}