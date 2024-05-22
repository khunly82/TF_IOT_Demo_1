
#region table de multiplication
//Console.WriteLine($"2 X 1 = 2");
//Console.WriteLine($"2 X 2 = 4");
//Console.WriteLine($"2 X 3 = 6");
//Console.WriteLine($"2 X 4 = 8");

//// ... 

//Console.WriteLine($"2 X 10 = 20");

//int compt = 1;

//while (compt <= 10)
//{
//    Console.WriteLine($"2 X {compt} = {2 * compt}");
//    compt++;
//}
#endregion

#region table2 de maultiplication
//int table = 1;
//while (table < 10)
//{
//	int multiplicateur = 1;
//	Console.WriteLine($"Table de {table}");

//	while (multiplicateur <= 10)
//	{
//		Console.WriteLine($"{table} X {multiplicateur} = {table * multiplicateur}");
//		multiplicateur++;
//	}
//	table++;
//}
#endregion

#region Guess the number
int toGuess = new Random().Next(1, 101);
int choice;

do
{
    Console.WriteLine("Entrez un nombre entre 1 et 100");
    bool valide = int.TryParse(Console.ReadLine(), out choice);
	if(!valide || choice < 1 || choice > 100)
	{
		Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Valeur incorrecte");
		Console.ResetColor();
    }
	else
	{
		if(choice > toGuess)
		{
            Console.WriteLine("trop grand");
        }
		else if(choice < toGuess)
		{
            Console.WriteLine("trop petit");
        }
	}
} while (toGuess != choice);

Console.WriteLine("C'est gagné");

#endregion
