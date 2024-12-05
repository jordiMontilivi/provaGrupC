//Declaracio de variables
int numCares, numero;
Random random = new Random();

//Valors entrada
Console.Write("Digues el nombre de cares del dau: ");
numCares = Convert.ToInt32(Console.ReadLine());

//Calculs
numero = random.Next(1, numCares);

//Mostrar els resultats
Console.WriteLine($"Al tirar un dau de {numCares} cares ha sortit un {numero}");