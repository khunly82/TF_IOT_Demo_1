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

const int TAILLE = 10;
int[] tab = new int[TAILLE];
int nbElem, index;

tab[0] = 2;
nbElem = 1;

while (nbElem < TAILLE)
{
    tab[nbElem] = tab[nbElem - 1] * 2;
    nbElem++;
}

index = 0;
while (index < nbElem)
{
    Console.WriteLine(tab[index]);
    index++;
}

#endregion