#region Différence temps ABS
// déclarer les variables qui vont contenir les différentes valeurs encodées

int nbJours1,
    nbHeures1,
    nbMinutes1,
    nbSecondes1,
    nbJours2,
    nbHeures2,
    nbMinutes2,
    nbSecondes2,
    duree1,
    duree2;

// récupération des données encodées
Console.WriteLine("Entrer le nombre de jours de la première durée");
nbJours1 = int.Parse(Console.ReadLine());
Console.WriteLine("Entrer le nombre de heures de la première durée");
nbHeures1 = int.Parse(Console.ReadLine());
Console.WriteLine("Entrer le nombre de minutes de la première durée");
nbMinutes1 = int.Parse(Console.ReadLine());
Console.WriteLine("Entrer le nombre de secondes de la première durée");
nbSecondes1 = int.Parse(Console.ReadLine());

Console.WriteLine("Entrer le nombre de jours de la seconde durée");
nbJours2 = int.Parse(Console.ReadLine());
Console.WriteLine("Entrer le nombre de heures de la seconde durée");
nbHeures2 = int.Parse(Console.ReadLine());
Console.WriteLine("Entrer le nombre de minutes de la seconde durée");
nbMinutes2 = int.Parse(Console.ReadLine());
Console.WriteLine("Entrer le nombre de secondes de la seconde durée");
nbSecondes2 = int.Parse(Console.ReadLine());

// conversion des données en secondes
duree1 = nbSecondes1 + (60 * nbMinutes1) + (3600 * nbHeures1) + (86400 * nbJours1);
duree2 = nbSecondes2 + (60 * nbMinutes2) + (3600 * nbHeures2) + (86400 * nbJours2);

// calcul de la différence
int difference = Math.Abs(duree1 - duree2);

Console.WriteLine($"La différence est de {difference} secondes");
#endregion

#region Année bissextile
//int annee;
//annee = int.Parse(Console.ReadLine());

//if(annee % 4 == 0 && annee % 100 != 0 || annee % 400 == 0)
//{
//    Console.WriteLine("L'année es bissextile");
//}
//else
//{
//    Console.WriteLine("L'année n'est pas bissextile");
//}
// 1996 vrai
// 2000 vrai
// 2100 faux
// 1197 faux

#endregion

