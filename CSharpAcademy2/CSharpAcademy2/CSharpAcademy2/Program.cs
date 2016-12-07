using System;
using static System.Console;        // Pozwala nam opuścić każdorazowe pisanie słowa Console w takich aspektach jak: Console.Writeline(), Console.Write(), Console.ReadKey() itp.


namespace CSharpAcademy2
{
    class Program
    {
        static void Main(string[] args)
        {

            /* ---------------------- Hello World - Na dobry początek i sprawdzenie poprawności działania projektu  ---------------------- */

            WriteLine("Hello World!");





            /* ----------------------Różnice między postinkrementacją, a preinkrementacją ---------------------- */

//            int value = 5;              // Ustawiamy wartość zmiennej na 5
//            WriteLine(value);           // Wyświetli się: 5
//
//            value = 5;                  // Przywracamy wartość 5 dla zmiennej value
//            WriteLine(++value);         // Wyświetli się: 6
//            WriteLine(value);           // Wyświetli się: 6
//
//            value = 5;                  // Przywracamy wartość 5 dla zmiennej value
//            WriteLine(value++);         // Wyświetli się: 5
//            WriteLine(value);           // Wyświetli się: 6




            /* ---------------------- Pobranie liczby od użytkownika - wykorzystamy ją dla przykładów If i else, switch oraz for (dla tych przykładów musi być odkomentowane ---------------------- */

//            WriteLine("Podaj liczbę z zakresu 0 - 7");
//            string numberAsString = ReadLine();
//            int number = Int32.Parse(numberAsString);

            //  int number = Int32.Parse(ReadLine());   // Całą operację (linia 39, 40) możemy zrobić oczywiście w jednej linii





            /* ---------------------- If, else if, else ---------------------- */

//            WriteLine("\nDziś jest " + number + " dzień tygodnia. \n");
//
//            if (number == 6 || number == 7) // Jeśli number jest równy 6 lub 7 wykonaj następujący blok instrukcji
//            {
//                WriteLine("Weekend mamy, więc odpoczywamy!\n");
//                if (number == 7)
//                    WriteLine("Dziś jest niedziela!");
//                        // Jeśli dodatkowo liczba ta jest równa 7 wyświetl również ten komunikat
//            }
//            // Jeśli nie 6 lub 7 natomiast większe lub równe 1 i mniejsze lub równe 5 wykonaj tę instrukcję
//            else if (number >= 1 && number <= 5) WriteLine("Tydzień trwa, więc student na uczelnię gna!\n");
//
//            // W każdym innym przypadku wykonaj tę instrukcję
//            else WriteLine("Oznacza to, że coś poszło źle, widocznie melanż wykończył mnie!\n");





            /* ----------------------Instrukcja wyboru switch ---------------------- */

//            string weekDay; // Deklarujemy zmienną
//
//            switch (number) // switch(warunek)
//            {
//                case 1:
//                    // Jeżeli warunek (w tym przypadku 'number' równy jest 1, zainicjuj zmienną weekDay wartością Poniedziałek
//                    weekDay = "Poniedziałek";
//                    break; // Zawsze konieczny na końcu danego "case", inaczej program się nie skompiluje
//                case 2:
//                    weekDay = "Wtorek";
//                    break;
//                case 3:
//                    weekDay = "Środa";
//                    break;
//                case 4:
//                    weekDay = "Czwartek";
//                    break;
//                case 5:
//                    weekDay = "Piątek";
//                    break;
//                case 6:
//                    weekDay = "Sobota";
//                    break;
//                case 7:
//                    weekDay = "Niedziela";
//                    break;
//                default: // Wartość domyślna jeśli żaden inny warunek (z powyższych) nie zostanie spełniony
//                    weekDay = "Błąd!";
//                    break;
//            }
//            WriteLine(number + " dzień tygodnia to " + weekDay + "\n");





            /* ----------------------Pętla for ---------------------- */
           
//        for (int i = 0; i <= number; i++)       // for(inicjalizacja zmiennej licznikowej; warunek wykonywania pętli; co ma się wydarzyć po wykonaniu jednego obiegu pętli, w typ wypadku zwiększenie licznika o 1)
//        {
//            WriteLine("Otwieram szufladkę numer: " + i);
//        }
//
//        // Przypadek, który został poruszony na zajęciach podczas tego ćwiczenia
//        int a = 4;
//        int b = 5;
//        WriteLine("\n\nOtwieram szufladkę numer: " + (a + b));      // Najpierw wykona się zadanie w nawiasach (jak w matematyce), czyli dodatnie dwóch liczb, a następnie wyświetlenie
//                                                                // Rezultatem będzie wypisanie na konsoli: Otwieram szufladkę numer: 9
//
//        WriteLine("Otwieram szufladkę numer: " + a + b);        // Od razu zostanie wyświetlony komunikat (liczby nie zostaną do siebie dodane), który będzie wyglądał następująco:
//                                                                // Otwieram szufladkę numer: 45           





            /* ----------------------Pętla while oraz do while ---------------------- */

//            bool endLoop = true;        // Wartość logiczna (tak lub nie) -- należy ją zmieniać odpalając program i testując jak się zachowują pętle (ustawiać true lub false)
//
//            while (!endLoop)            // while(warunek == true)
//            {
//                WriteLine("\nCzy mam zakończyć działanie programu z pętlą While? (y - Tak, n - Nie)\n");
//                char key = ReadKey().KeyChar;       // Pobranie jednego znaku od użytkownika z konsoli i przekonwertowanie (.KeyChar) na typ char
//                if (key == 'y') endLoop = true;     // Porównanie czy pobrany znak 'key' jest identyczny jak znak 'y'
//                else endLoop = false;
//            }
//
//            do
//            {
//                WriteLine("\nCzy mam zakończyć działanie programu z pętlą While? (y - Tak, n - Nie)\n");
//                char key = ReadKey().KeyChar;
//                if (key == 'y') endLoop = true;
//                else endLoop = false;
//            } while (!endLoop);


            ReadKey();      // Czekamy na wpisanie dowolnego znaku od użytkownika po zakończeniu wszystkich działań programu. Ma to na celu powstrzymanie konsoli przed zamknięcie
                            // Gdyby tego nie było, po wykonaniu wszystkich zadań konsola natychmiast by się zamknęła, a my nie zauważlibyśmy rezultatów
                            // Alternatywą tego wpisu jest naciskanie skrótu ctrl + F5 w celu uruchomienia programu (jednak należy to czynić za każdym razem, gdy startujemy nasz program
        }
    }
}