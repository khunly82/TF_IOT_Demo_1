//Exercices sur les tableaux

#region Tableau de 6

//const int TAILLE = 6;
//int[] tab = new int[TAILLE];
//int stock, i;

//stock = 0;
//while (stock < TAILLE)
//{
//    tab[stock] = int.Parse(Console.ReadLine());
//    stock++;
//}

//i = 0;
//while (i < stock)
//{
//    Console.WriteLine("La case n°" + (i + 1) + " de mon tableau vaut " + tab[i]);
//    i++;
//}

#endregion

#region Tableau pré-rempli

//const int TAILLE = 10;
//int[] tab = new int[TAILLE];
//int nbElem, index;

//tab[0] = 2;
//nbElem = 1;

//while (nbElem < TAILLE)
//{
//    tab[nbElem] = tab[nbElem - 1] * 2;
//    nbElem++;
//}

//index = 0;
//while (index < nbElem)
//{
//    Console.WriteLine(tab[index]);
//    index++;
//}

#endregion

#region Tableau de scores V1

//const int TAILLE = 10;

//int[] scores = new int[TAILLE];

//int nbJoueur;
//double moyenne;

//do
//{
//    Console.WriteLine($"Veuillez indiquer le nombre de joueurs (entre 2 et {TAILLE}):");
//} while (!int.TryParse(Console.ReadLine(), out nbJoueur) || nbJoueur < 2 || nbJoueur > TAILLE);

//for (int i = 0; i < nbJoueur; i++)
//{
//	do
//	{
//        Console.WriteLine($"Veuillez indiquer le score du joueur {i+1} :");
//    } while (!int.TryParse(Console.ReadLine(), out scores[i]));
//}

//moyenne = 0;
//for (int i = 0; i < nbJoueur; i++)
//{
//    moyenne += scores[i];
//}
//moyenne /= nbJoueur;

//Console.WriteLine($"La moyenne des scores est {moyenne}.");

#endregion

#region Tableau de scores V2

const int TAILLE = 10;

int nbJoueur;
double moyenne;

do
{
    Console.WriteLine($"Veuillez indiquer le nombre de joueurs (entre 2 et {TAILLE}):");
} while (!int.TryParse(Console.ReadLine(), out nbJoueur) || nbJoueur < 2 || nbJoueur > TAILLE);

int[] scores = new int[nbJoueur];

for (int i = 0; i < nbJoueur; i++)
{
    do
    {
        Console.WriteLine($"Veuillez indiquer le score du joueur {i + 1} :");
    } while (!int.TryParse(Console.ReadLine(), out scores[i]));
}

moyenne = 0;
for (int i = 0; i < nbJoueur; i++)
{
    moyenne += scores[i];
}
moyenne /= nbJoueur;

Console.WriteLine($"La moyenne des scores est {moyenne}.");

#endregion