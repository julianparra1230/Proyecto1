// See https://aka.ms/new-console-template for more information

 /* tipos de datos:
  * Int Numeros enteros
  * Float Numeros Decimales
  * Bool Verdadero o falso
  * String textos
  * var (no es buena practica)
  * char caracter $
  * Declarar una variable (Tipo de dato, nombre, y valor)
  */ // Const deja de ser variable para no poderse modificar, en ves de un tipo de dato se coloca const
//declarar una variable ejemplo: int edad = 23;

string nombre;

Console.WriteLine("¿Cual es tu nombre?");
nombre = Console.ReadLine();

Console.Clear(); // limpia la consola

int edad;

Console.WriteLine("¿Cuantos años tienes?");
edad = int.Parse(Console.ReadLine()); // Int.parse me permite cambiar el tipo de dato en este caso de string a entero (int)

Console.WriteLine("Jugador " + nombre + ".");
Console.WriteLine("tiene " + edad + " años.");