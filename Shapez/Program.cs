using Shapez.Models;
using Spectre.Console;
using System.Diagnostics;

namespace Shapez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();

            using (var db = new AppDbContext())
            {
                db.Database.EnsureCreated();

                var table = new Table();

                table.AddColumn("Owner");
                table.AddColumn(new TableColumn("Shape").Centered());
                table.AddColumn(new TableColumn("Color").Centered());

                if (db.Shapes.Any() == false)
                {
                    string[] colors = { "Red", "Blue", "Green", "Yellow", "Purple" };

                    string[] shapes = { "Square", "Circle", "Triangle" };

                    for (int i = 0; i < 1000000; i++)
                    {
                        db.Shapes.Add(new Models.Shape
                        {
                            Color = colors[i % 5],
                            Shapez = shapes[i % 3],
                            Owner = (i % 10)
                        });
                    }
                    db.SaveChanges();
                }
                sw.Start();
                List<Shape> shapesList = db.Shapes.ToList();
                foreach (var item in shapesList)
                {
                    table.AddRow(item.Owner.ToString(), item.Shapez, item.Color);
                }
                sw.Stop();

                AnsiConsole.Write(table);

                AnsiConsole.MarkupLine($"[bold green] Records: {shapesList.Count:N0} - Took: {sw.Elapsed.Hours}h::{sw.Elapsed.Minutes}m::{sw.Elapsed.Seconds}s::{sw.Elapsed.Milliseconds}ms[/]");
            }
        }
    }
}