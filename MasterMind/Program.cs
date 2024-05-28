// Rouge : 1
// Rose : 2
// Vert : 3
// Bleu : 4
// Jaune : 5
// Cyan: 6

int nbEssai = 0;
bool trouve = false;

// Créer une combinaison secrete
int[] secret = CreateSecret();

// Tant que pas trouvé et suffisament d'essais
while (!trouve && nbEssai < 12)
{
    nbEssai++;
    // Demander 4 couleurs
    int[] essai = AskColors();

    // Afficher les indices
    DisplayClues(secret, essai);

    // Si Bonne combinaison
    if (IsSame(secret, essai))
    {
        // gagné et sortir de la boucle
        trouve = true;
    }
}

void DisplayColor(int color)
{
    Console.ForegroundColor = color switch
    {
        // Rouge : 1
        // Rose : 2
        // Vert : 3
        // Bleu : 4
        // Jaune : 5
        // Cyan: 6
        1 => ConsoleColor.Red,
        2 => ConsoleColor.Magenta,
        3 => ConsoleColor.Green,
        4 => ConsoleColor.Blue,
        5 => ConsoleColor.Yellow,
        6 => ConsoleColor.Cyan,
        _ => ConsoleColor.Black,
    };
    Console.Write("■");
    Console.ResetColor();
}

bool IsSame(int[] secret, int[] essai)
{
    // return secret.SequenceEqual(essai);
    if(secret.Length != essai.Length)
    {
        return false;
    }
    for(int i = 0; i < secret.Length; i++)
    {
        if (secret[i] != essai[i])
        {
            return false;
        }
    }
    return true;
}

void DisplayClues(int[] secret, int[] essai)
{
    int bienPlace = 0;
    int malPlace = 0;
    int?[] indices1 = new int?[secret.Length];
    int?[] indices2 = new int?[secret.Length];

    // comptabilisation des biens placées
    for (int i = 0;i < secret.Length;i++)
    {
        if (secret[i] == essai[i])
        {
            indices1[bienPlace] = i;
            indices2[bienPlace] = i;
            bienPlace++;
        }
    }

    // comptabilisation des mal placées
    for (int i = 0; i < secret.Length; i++)
    {
        if(!indices1.Contains(i))
        {
            for(int j = 0; j < essai.Length; j++) 
            {
                if(!indices2.Contains(j) && essai[j] == secret[i])
                {
                    indices1[bienPlace + malPlace] = i;
                    indices2[bienPlace + malPlace] = j;
                    malPlace++;
                    break;
                }
            }
        }
    }
    Console.WriteLine($" B: {bienPlace} M: {malPlace} ");
}

int[] AskColors(int nb = 4)
{
    int[] result = new int[nb];
    for(int i = 0;i < nb; i++) 
    {
        int value;
        do
        {
            string key = Console.ReadKey(true).KeyChar.ToString();
            int.TryParse(key, out value);
        } while (value < 0 || value > 6);
        result[i] = value;
        DisplayColor(result[i]);
    }
    return result;
}

int[] CreateSecret(int nb = 4)
{
    int[] result = new int[nb];
    Random random = new Random();
    for (int i = 0;i < result.Length;i++)
    {
        result[i] = random.Next(1, 7);
    }
    return result;
}