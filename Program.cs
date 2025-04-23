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
Console.Clear();

//Vamos a hacer un adivina el numero
//Generar un numero aleatorio entre 1 y 100
Random rdm = new Random();
int numeroOculto = rdm.Next(1, 101); // el 101 no se incluye
int intentos = 0;
int numeroJugador = 0;
int intentosMaximos = 5;
Console.WriteLine($"{nombre}, Adivina el numero!!");
Console.WriteLine("Entre el 1 y el 100");
Console.WriteLine($"tienes {intentosMaximos} intentos para adivinar el numero!!");
do
{
   numeroJugador = int.Parse(Console.ReadLine());
    intentos++;

    if (numeroJugador < numeroOculto)
        Console.WriteLine("El Numero es mas Alto!");
    else if (numeroJugador > numeroOculto)
        Console.WriteLine("El numero es mas Bajo!");
    else
    { 
        Console.WriteLine($"Felicitaciones {nombre}, Adivinaste el numero en " + intentos + " intentos");
    break; //si adivina termina el juego
    }

    if (intentos == intentosMaximos && numeroJugador != numeroOculto)
    {
    Console.WriteLine($"Perdisteeee {nombre}, el numero era {numeroOculto}");
    }
}
while (intentos < intentosMaximos && numeroJugador != numeroOculto);

// De esta forma realizando un bucle y con Random generamos un juego de adivina el numero.