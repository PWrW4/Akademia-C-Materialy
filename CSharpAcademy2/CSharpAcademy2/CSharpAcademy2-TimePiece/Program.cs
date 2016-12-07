using System;
using static System.Console;

namespace CSharpAcademy2
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            while (true)
            {
                Clear();            // Czyści  wszystko co obecnie mamy na konsoli konsoli
                WriteLine("1. Pokaż aktualną datę i godzinę\n" +
                                  "2. Stoper\n" +
                                  "3. Minutnik\n" +
                                  "\n 0. Wyjdź z programu");
                choice = ReadKey().KeyChar;

                switch (choice)
                {
                    case '1':
                        Clear();

                        ActuallyDateAndTime();

                        WriteLine("\nWciśnij dowolny klawisz aby kontunuować...");
                        ReadKey();

                        break;
                    case '2':
                        Clear();

                        StopWatch();

                        WriteLine("\nWciśnij dowolny klawisz aby kontunuować...");
                        ReadKey();
                        break;
                    case '3':
                        Clear();

                        EggTimer();

                        WriteLine("\nWciśnij dowolny klawisz aby kontunuować...");
                        ReadKey();
                        break;
                    default:
                        ExitProgram();      // Kończy działanie programu jeśli użytkownik wciśnie inny przycisk niż "1", "2" lub "3"
                        break;
                }
            }
        }
        private static void ActuallyDateAndTime()
        {
            WriteLine(DateTime.Now);        // Wyświetla aktualną datę i godzinę
        }

        private static void StopWatch()
        {
            WriteLine("Podaj ile sekund mam odmierzac");
            int time = Int32.Parse(ReadLine());
            int i = 0;
            do
            {
                Clear();                                    // Przy każdym obrocie pętli czyści nam konsolę (uzyskujemy efekt zmieniającej się wartości liczby, a nie wypisywania wartości jedna pod drugą)
                WriteLine(i++);                             // Wypisuję wartość i i jednocześnie tuż po wypisaniu zwiększam ją o 1
                System.Threading.Thread.Sleep(1000);        // Pozwala nam uśpić działanie programu na czas 1 sekundy (1000 milisekund) przez co mamy odliczanie co 1 sekundę
            } while (i <= time);
        }

        private static void EggTimer()
        {
            WriteLine("Na ile sekund chcesz ustawić minutnik?");
            int seconds = Int32.Parse(ReadLine());

            for (int i = seconds; i >= 0; i--)
            {
                Clear();
                WriteLine(i);
                System.Threading.Thread.Sleep(1000);
            }
            WriteLine("Czas minął!");
        }

        private static void ExitProgram()
        {
            Environment.Exit(1);
        }






    }
}