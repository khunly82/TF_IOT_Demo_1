
#region Exo 1
//int somme = 0;

//Console.WriteLine("Entrez un nombre de 1 à 10");
//int nbJoueurs = int.Parse(Console.ReadLine());

//for (int i = 1; i < nbJoueurs + 1; i++)
//{
//    Console.WriteLine($"Entrez le score du joueur {i}");
//    somme += int.Parse(Console.ReadLine());
//}

//Console.WriteLine($"Moyenne : {somme / (double)nbJoueurs:F2}");
#endregion

#region Exo 2
//int[] valeurs = new int[10];
//for (int i = 0; i < valeurs.Length; i++)
//{
//    int.TryParse(Console.ReadLine(), out valeurs[i]);
//}

//int min = valeurs[0];
//int max = valeurs[0];

//for (int i = 1; i < valeurs.Length; i++)
//{
//    if (valeurs[i] > max)
//    {
//        max = valeurs[i];
//    }
//    if (valeurs[i] < min)
//    {
//        min = valeurs[i];
//    }
//}

//Console.WriteLine($"min: {min}");
//Console.WriteLine($"max: {max}");

#endregion

#region Exo 3
// int[] valeurs = [42,55,66,17,33,7,6];
//bool exist = false;



//for (int i = 0; i < valeurs.Length && !exist; i++)
//{
//    Console.WriteLine(i);
//    if (valeurs[i] == 66)
//    {
//        exist = true;
//    }
//}

//bool exist = valeurs.Contains(42);

// bool exist = valeurs.Any(v => v == 42);

//string[] strings = ["riri", "fifi", "loulou"];
//bool exist = strings.Any(s => s.StartsWith("lou"));

//Console.WriteLine(exist);

#endregion

#region exo 3
//bool[] cases = new bool[10];
//int position = 0;

//cases[position] = true;

//ConsoleKey key = ConsoleKey.Spacebar;

//while (key != ConsoleKey.Q)
//{
//    Console.Clear();
//    // afficher le tableau
//    for (int i = 0; i < cases.Length; i++)
//    {
//        Console.Write(cases[i] ? "*" : " ");
//    }


//    key = Console.ReadKey(true).Key;

//    cases[position] = false;
//    if(key == ConsoleKey.G/* && position > 0*/)
//    {
//        // se déplacer à gauche
//        position = (position - 1 + cases.Length) % cases.Length;
//    }

//    if(key == ConsoleKey.D/* && position < 9*/)
//    {
//        // se déclacer à droite
//        position = (position + 1) % cases.Length;
//    }
//    cases[position] = true;

//}
#endregion


// initialisation des tableaux
int[] tab1 = [42, 17, 14, 33, 99, 12];
int[] tab2 = [14, 32, 15, 14];

//List<int> list = new List<int>();

//list.AddRange(tab1);
//list.AddRange(tab2);
//list.Sort();

//int[] tab3 = list.ToArray();

// création du tableau qui contiendra les données fusionnées
int[] tab3 = new int[tab1.Length + tab2.Length];

// nombre d'éléments trouvés
int foundInTab1 = 0;
int foundInTab2 = 0;

// indices à exclure dans les tableaux
int?[] indices1 = new int?[tab1.Length];
int?[] indices2 = new int?[tab2.Length];

for (int i = 0; i < tab3.Length; i++)
{
    // recherche du plus petit en excluant les éléménts déjà ajoutés
    int tab = 1;
    int indice = 0;
    int min = int.MaxValue;
    for (int j = 0; j < tab1.Length; j++)
    {
        if(!indices1.Contains(j))
        {
            if (tab1[j] < min)
            {
                min = tab1[j];
                tab = 1;
                indice = j;
            }
        }

    }
    for (int j = 0; j < tab2.Length; j++)
    {
        if(!indices2.Contains(j))
        {
            if (tab2[j] < min)
            {
                min = tab2[j];
                tab = 2;
                indice = j;
            }
        }
    }
    tab3[i] = min;

    // ajout de l'indice à exclure dans la prochaine recherche
    if(tab == 1)
    {
        indices1[foundInTab1] = indice;
        foundInTab1++;
    } 
    else
    {
        indices2[foundInTab2] = indice;
        foundInTab2++;
    }
}


for (int i = 0; i < tab3.Length; i++)
{
    Console.WriteLine(tab3[i]);
}