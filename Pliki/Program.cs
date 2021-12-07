// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

int counter = 0;
Console.WriteLine("=========================================================");
Console.WriteLine("Witaj w programie Operacje na Plikach");
Console.WriteLine("=========================================================");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("1. Wyświetl wszystkie osoby o imieniu Anna");
Console.WriteLine("2. Wyświetl 246 pozycję z listy");

Console.Write("Wybierz zadanie do wykonania: ");
int zadanie = int.Parse(Console.ReadLine());
if (zadanie == 1 | zadanie == 2 |zadanie == 0)
{
    switch (zadanie)
    {
        case 1:
            Console.Clear();
            //Definicja wzorca wyszukania
            string wzorzec = "Anna?\\s";
            //Pętla przeszukująca plik
            foreach (string line in System.IO.File.ReadLines(@".\Lista-imion-i-nazwisk.txt"))
            {
                //Warunek sprawdzający wzorzec (uwzględnia wielkość liter)
                if (System.Text.RegularExpressions.Regex.IsMatch(line, wzorzec))
                {

                    int count = counter + 1;
                    //Wyświetlanie linii wraz z numerem
                    Console.WriteLine(count + ". " + line);
                }

                counter++;
            }


            break;

        case 2:
            Console.Clear();
            foreach (string line in System.IO.File.ReadLines(@".\Lista-imion-i-nazwisk.txt"))
            {
                if (counter == 245)
                {
                    string count = counter.ToString();
                    Console.WriteLine("246. " + line);
                }

                
                counter++;
            }




            break;

       

        case 0:
            koniecProgramu(zadanie);
            break;

    }
}
static void koniecProgramu(int zadanie)
{
    Environment.Exit(0);
}
  
System.Console.ReadLine();
