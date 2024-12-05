//Declaracio de variables
int golsGirona, golsPSG;
Random random = new Random();

//Valors entrada

//Calculs
golsGirona = random.Next(0, 7);
golsPSG = random.Next(0, 7);

//Mostrar els resultats
Console.WriteLine($"El resultat del partit Girona - Paris Sant Germain es");
Console.WriteLine($"Girona {golsGirona} - {golsPSG} Paris Sant Germain");