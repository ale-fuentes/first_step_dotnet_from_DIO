using System;

namespace DIO.series.ale
{
    class Program
    {

        static SerieRepository repository = new SerieRepository();
        static void Main(string[] args)
        {
            string myOption = GetOptionForUser();
            while (myOption.ToUpper() != "X")
            {
                switch (myOption)
                {
                    case "1": listSeries(); break;
                    case "2": addSerie(); break;
                    case "3": updateSerie(); break;
                    case "4": excludeSerie(); break;
                    case "5": detailSerie(); break;
                    case "C": Console.Clear(); break;
                }
                myOption = GetOptionForUser();
            }
        }

        private static void excludeSerie()
        {
            Console.WriteLine("Exclude one Serie");

            Console.Write("Which Id of your serie you want exclude: ");
            int selectId = int.Parse(Console.ReadLine());

            repository.Exclude(selectId);
        }

        private static void detailSerie()
        {
            Console.WriteLine("Update one Serie");

            Console.Write("Which Id of your serie you want update: ");
            int selectId = int.Parse(Console.ReadLine());

            var serie = repository.ReturnFromId(selectId);

            Console.Write(serie.ToString());
        }

        private static void updateSerie()
        {
            Console.WriteLine("Update one Serie");

            Console.Write("Which Id of your serie you want update: ");
            int selectId = int.Parse(Console.ReadLine());

            foreach (int gender in Enum.GetValues(typeof(Gender)))
            {
                Console.WriteLine($"{gender} - {Enum.GetName(typeof(Gender), gender)}");
            }

            Console.Write("Select gender of Serie: ");
            int selectGender = int.Parse(Console.ReadLine());
            Console.Write("Title of Serie: ");
            string selectTitle = Console.ReadLine();
            Console.Write("Year of Serie: ");
            int selectYear = int.Parse(Console.ReadLine());
            Console.Write("Description of Serie: ");
            string selectDescription = Console.ReadLine();

            Serie newSerie = new Serie(id: selectId,
                                    gender: (Gender)selectGender,
                                    title: selectTitle,
                                    description: selectDescription,
                                    year: selectYear);

            repository.Update(selectId, newSerie);
        }

        private static void addSerie()
        {
            Console.WriteLine("Add new Serie");

            foreach (int gender in Enum.GetValues(typeof(Gender)))
            {
                Console.WriteLine($"{gender} - {Enum.GetName(typeof(Gender), gender)}");
            }

            Console.Write("Select gender of Serie: ");
            int selectGender = int.Parse(Console.ReadLine());
            Console.Write("Title of Serie: ");
            string selectTitle = Console.ReadLine();
            Console.Write("Year of Serie: ");
            int selectYear = int.Parse(Console.ReadLine());
            Console.Write("Description of Serie: ");
            string selectDescription = Console.ReadLine();

            Serie newSerie = new Serie(id: repository.NextId(),
                                    gender: (Gender)selectGender,
                                    title: selectTitle,
                                    description: selectDescription,
                                    year: selectYear);

            repository.Add(newSerie);
        }

        private static void listSeries()
        {
            Console.WriteLine("Listing my Series:");
            var listSeries = repository.List();

            if (listSeries.Count == 0) { Console.WriteLine("There are no Series to list"); }

            foreach (var serie in listSeries)
            {
                var isExclude = serie.isExclude() ? "Exclude" : "Available";
                Console.WriteLine($"ID: {serie.getId()} - {serie.getTitle()} [{isExclude}] ");
            }
        }

        private static string GetOptionForUser()
        {
            Console.WriteLine();
            Console.WriteLine("SERIES by 'DIO & alefuentes'");
            Console.WriteLine("What is your options?");

            Console.WriteLine("1 > Listing your Series.");
            Console.WriteLine("2 > Add new Serie.");
            Console.WriteLine("3 > Update one Serie.");
            Console.WriteLine("4 > Exclude one Serie.");
            Console.WriteLine("5 > Details one Serie.");
            Console.WriteLine("C > Clean screen.");
            Console.WriteLine("X > Exit.");
            Console.WriteLine();

            string optionUser = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return optionUser;
        }
    }
}
