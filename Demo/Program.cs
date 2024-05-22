#region Variables
//// déclaration d'une variable
//int number;

//// affection d'une variable 
//number = 42;

//// déclarer et affecter une variable
//string prenom = "Khun";
//char lettre = 'a';

//// déclaration multiple
//int variable1, 
//    variable2, 
//    variable3; 
#endregion

#region Output
// cw -> tab
////Console.WriteLine("Hello\nworld\n!");
////Console.WriteLine(@"Hello
////world
////!");

//Console.WriteLine("Hello " + prenom + " !");
//Console.WriteLine($@"Hello
//{prenom}
//!");
#endregion

#region Correction Swap variables

//int a = 5,
//    b = 7;

//Console.WriteLine($"a: {a}; b: {b}");

////int temp = a;
////a = b;
////b = temp;
//(a, b) = (b, a);

//Console.WriteLine($"a: {a}; b: {b}");
#endregion

#region Input
//Console.WriteLine("Entrer votre prénom");
//// input lire la ligne entrée
//string prenom = Console.ReadLine();
//Console.WriteLine($"Bonjour Monsieur {prenom} !!");

//Console.WriteLine("Entrer un nombre");
//string input = Console.ReadLine();

//// conversion d'un chaine en entier
//int nombre = int.Parse(input);
//Console.WriteLine($"Ce nombre au carré = {nombre * nombre}");

// conversion d'une chaine en date
//Console.WriteLine("Entrer votre date de naissance");

//string input = Console.ReadLine();
//DateTime date = DateTime.Parse(input);
//Console.WriteLine($"Vous êtes nés, il y {(DateTime.Now - date).TotalDays} jours");
#endregion

#region Opérateurs
//int nb1 = 5;
//int nb2 = 42;

//Console.WriteLine($"{nb2} + {nb1} = {nb2 + nb1}");
//Console.WriteLine($"{nb2} - {nb1} = {nb2 - nb1}");
//Console.WriteLine($"{nb2} * {nb1} = {nb2 * nb1}");

//// division entière
//Console.WriteLine($"{nb2} / {nb1} = {nb2 / nb1}");

//// division
//Console.WriteLine($"{nb2} / {nb1} = {nb2 / (double)nb1}");

//// modulo
//Console.WriteLine($"{nb2} % {nb2} = {nb2 % nb1}");

//// concaténation

//string prenom = "Khun";
//Console.WriteLine("Hello " + prenom + "!");

#endregion

#region Correction Convertisseur secondes
//int secondesTotales, 
//    secondes, 
//    minutes, 
//    heures, 
//    jours;

//Console.WriteLine("Entrer le nombre de secondes pour la conversion");
//secondesTotales = int.Parse(Console.ReadLine());

//secondes = secondesTotales % 60;
//minutes = secondesTotales / 60 % 60;
//heures = secondesTotales / 3600 % 24;
//jours = secondesTotales / 864000;

//Console.WriteLine($"jours : {jours}\nheures : {heures}\nminutes : {minutes}\nsecondes : {secondes}");
#endregion

#region Booléens
//bool flag = false;

//int age = 42;
//bool estMajeur = age >= 18;
// égal → == 
// différent → !=
// plus petit → <
// plus petit ou égal → <=
// plus grand → >
// plus grand ou égal → >=


// XOR
// Console.WriteLine(true ^ true);

#endregion

#region Structures conditionnelles
//bool estAutorise = true;
//// (cond à vérifier)
//if(estAutorise)
//{
//    // ensemble des instructions qui seront éxecutées si vrai
//    Console.WriteLine("Est affiché si autorisé est vrai");
//}
//else
//{
//    // ensemble des instructions qui seront éxecutées sinon
//    Console.WriteLine("Est affiché si pas autorisé");
//}

//int age = 42;
//if(age < 12)
//{
//    Console.WriteLine("Enfant");
//}
//else if(age < 18)
//{
//    Console.WriteLine("Ado");
//}
//else
//{
//    Console.WriteLine("Adulte");
//}

//int jourSemaine = 5;

//switch(jourSemaine)
//{
//    case 1:
//        Console.WriteLine("Lundi");
//        break;
//    case 2:
//        Console.WriteLine("Mardi");
//        break;
//    case 3:
//        Console.WriteLine("Mercredi");
//        break;
//    case 4:
//        Console.WriteLine("Jeudi");
//        break;
//    case 5:
//        Console.WriteLine("Vendredi");
//        break;
//    case 6:
//        Console.WriteLine("Samedi");
//        break;
//    case 7:
//        Console.WriteLine("Dimanche");
//        break;
//    default:
//        Console.WriteLine("Ce n'est un jour de la semaine !!");
//        break;
//}

//int age = 14;

// Opérateur ternaire
//string categorie = age < 18 ? "enfant" : "adulte";
// <=>
//string categorie;
//if(age < 18)
//{
//    categorie = "enfant";
//}
//else
//{
//    categorie = "adulte";
//}

//int? promo = 25;
//decimal prix = 14;
//decimal prixPromo;

//prixPromo = prix - (prix * (promo ?? 0) / 100);
//Console.WriteLine(prixPromo);

//int jours = 42;
////string j = jours == 1 ? "Lundi" : jours == 2 ? "Mardi" : jours == 3 ? "Mercredi": "Jeudi";//...
//string j = jours switch
//{
//    1 => "Lundi",
//    2 => "Mardi",
//    3 => "Mercredi",
//    4 => "Jeudi",
//    _ => "Jour inconnu"
//};
//Console.WriteLine(j);

#endregion

#region Boucles

//int selection;
//Console.WriteLine("Entrez un nombre entre 1 et 10");
//selection = int.Parse(Console.ReadLine());

//while (selection < 1 || selection > 10)
//{
//    Console.WriteLine("Valeur incorrecte");
//    selection = int.Parse(Console.ReadLine());
//}

//Console.WriteLine("Vous êtes sorti de la boucle");

//double selection;
//Console.WriteLine("Entrez un nombre entre 1 et 10");
//do
//{
//    selection = double.Parse(Console.ReadLine());
//}
//while (selection < 1 || selection > 10);

//Console.WriteLine("Vous êtes sorti de la boucle");

//int selection;
//string message = "Entrez un nombre entre 1 et 10";
//do
//{
//    Console.WriteLine(message);
//    message = "Valeur incorrecte";
//} while (!int.TryParse(Console.ReadLine(), out selection) || selection > 10 || selection < 1);

//int selection;
//Console.WriteLine("Entre une valeur entre 1 et 10");
//bool valide = int.TryParse(Console.ReadLine(), out selection);

//while(!valide || selection < 1 || selection > 10)
//{
//    Console.WriteLine("Valeur incorrecte");
//    valide = int.TryParse(Console.ReadLine(), out selection);
//}
//Console.WriteLine("Valeur correcte");
#endregion

//using System.Text;

//Console.OutputEncoding = Encoding.UTF8;
//Console.SetCursorPosition(10, 10);
//Console.ForegroundColor = ConsoleColor.Red;
//Console.Write("♥");