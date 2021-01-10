using System;
using LABwork5.Processor;
using LABwork5.MSWord;
using LABwork5.Operations;
using LABwork5.SoftwarePlace;
using LABwork5.TheSapper;
using LABwork5.GamePlace;
using LABwork5.ThePrinter;
using LABwork5.PC;
using LABwork5.Control;

namespace LABwork5
{
    class Program
    {
        static void Main(string[] args)
        {
            Software[] softs = new Software[]
            {
                new Software("Quicker"),
                new Software("Volodya"),
                new Software("Pinguin"),
                new Software("Sweety Betty"),
                new Software("Mother Russia"),
                new Software("Joseph from USSR"),
                new Software("Slim Shady"),
                new Software("Daddy"),
                new Software("Destroyer"),
            };

            Word[] redactors = new Word[]
            {
                new Word(8,2,4,2),
                new Word(5,3,3,3),
                new Word(2,4,2),
                new Word(5,5,1,7),
                new Word(4,1,3,3),
                new Word(1,2,7,5),
                new Word(7,3,3,3),
                new Word(5,4,5),
            };

            Game[] games = new Game[]
            {
                new Game("Action", "1"),
                new Game("Shooter", "2"),
                new Game("Platformer", "3"),
                new Game("Action", "4"),
                new Game("Beat-em up", "5"),
                new Game("Stealth", "6"),
                new Game("Survival", "7"),
                new Game("Action", "8"),
                new Game("Logic", "9"),
                new Game("Action", "10"),
                new Game("Simulator", "11"),
            };

            Game.Update update = new Game.Update("V2.0");


            Controller.FindGameForType(games);
            Controller.FindRedactorForVersion(redactors);
            Controller.ShowSoftAlphabetically(softs);

            Console.WriteLine($"There are {(int)Calendar.Days} days in year, {(int)Calendar.Month} monthes and {(int)Calendar.DayOfWeek} days in week");

            Console.WriteLine();

            update.CheckForUpdate();
            update.ShowCurrentVersion();


            Computer pc = new Computer("Dell", "Inspiron", "Windows");

            pc.Add(softs[2]);
            pc.Add(softs[4]);
            pc.Add(softs[5]);
            pc.Add(softs[0]);

            pc.ShowList();

            pc.Remove(softs[4]);

            Console.WriteLine("\nSoft after removing\n");

            pc.ShowList();

            pc.ToString();
        }
    }

    enum Calendar
    {
        Month = 12,
        Days = 365,
        DayOfWeek = 7
    }

}