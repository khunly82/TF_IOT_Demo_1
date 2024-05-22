# CSharp

## Raccourcis Visual Studio

- Commenter CTRL + (k → c)
- Décommenter CTRL + (k → u)
- Entourer CTRL + (k → s)
- Réindenter CTRL + (k → d)
- Dupliquer une ligne CTRL + d
- Copier une ligne CTRL + c
- Couper une ligne CTRL + x
- Coller une ligne CTRL + v
- Renommer une variable, une classe, ... CTRL + (r → r)
- Démarrer F5
- Démarrer sans debug CTRL + F5
- Remonter 1 ligne ALT + ▲
- Descendre 1 ligne ALT + ▼
- Ecrire dans la console cw → TAB


## Déclaration et affectation de variables

- Déclaration

type nomVariable;

```cs
int nombre;
string nom;

bool flag1,
     flag2;
```

- Affectation

```cs
int nombre1;
nombre1 = 42;
// ou
int nombre2 = 42
```

- Swap

```cs
int a = 5, b = 7;
(a, b) = (b, a);
```

- Types intégrés
    - byte → entier
    - short → entier
    - int → entier
    - long → entier
    - decimal → nombre décimal
    - float → nombre à virgule
    - double → nombre à virgule
    - bool → booléen (vrai ou faux)
    - char → charactère
    - string → chaîne de charactères
    - DateTime → Date (+ heure)
    - object → objet

## Input / Ouptut

- Écrire dans la console
```cs
// avec retour à la ligne
Console.WriteLine("");

// sans retour à la ligne
Console.Write("");

// vider la console
Console.Clear();
```

- Lire dans la console
```cs
string input = Console.ReadLine();
```

## Convertir un string

```cs
// Convertir en entier
int nb = int.Parse("42");

// Convertir en Date
DateTime date = DateTime.Parse("1982-05-06");
```

## Opérateurs

- Arithmétique
    - addition → +
    - soustraction → -
    - multiplication → *
    - division → /
    - modulo → %
- Logique
    - égal → ==
    - différent → !=
    - plus petit → <
    - plus petit ou égal → <=
    - plus grand → >
    - plus grand ou égal → >=
    - et → &&
    - ou (inclusif) → ||
    - ou (exclusif) → ^
- Concaténation
    - concaténer → +
    - interpolation → $"hello {prenom}"

## Structures conditionnelles

- if
```cs
if(condition) {
    // instructions si cond
}
```

- if - else
```cs
if(condition) {
    // instructions si condition
}
else {
    // instructions sinon
}
```

- if - else if - else
```cs
if(condition) {
    // instructions si condition
}
else if(autreCondition) {
    // instructions si autreCondition
}
else {
    // instructions sinon
}
```

- switch
```cs
switch(variable) {
    case 1:
        // instructions si variable == 1
        break;
    case 2:
        // instructions si variable == 2
        break;
    default:
        // instructions sinon
        break;
}
```

- Ternaire
```cs
var variable = condition ? valeurSiCondition : valeurSinon; 
```

- Switch expression
```cs
var variableAAffecter = variableAComparer switch {
    valeurComparee1 => valeur1,
    valeurComparee2 => valeur2,
    _ => valeurSinon
}; 
```

