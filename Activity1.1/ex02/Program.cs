//Declaracio de variables
char lletraAleatoria;
Random random = new Random();

//Valors entrada

//Calculs
lletraAleatoria = (char)(random.Next('A', 'Z' + 1));

//Mostrar els resultats
Console.WriteLine($"La lletra majuscula aleatoria es {lletraAleatoria}");