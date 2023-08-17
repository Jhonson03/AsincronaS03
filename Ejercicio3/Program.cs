//Ejercicio3

using System.Threading.Tasks;
String[] Palabras = { "Perro", "Casa", "Cebra", "Tortuga", 
    "Burro", "Mar", "Dedo", "Tasa", "Nube", "Sol" };

Console.WriteLine("Arreglo sin ordenar: ");
for(int i = 0; i < Palabras.Length; i++)
{
    Console.WriteLine($"Posicion {i+1}: {Palabras[i]}");
}

Array.Sort(Palabras);

Console.WriteLine("\nArreglo ordenado: ");

foreach(string i in Palabras)
{
    Console.WriteLine(i);
}