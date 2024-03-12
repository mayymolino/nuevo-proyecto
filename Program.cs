using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int numeroAleatorio = random.Next(1, 05);
        int intentos = 1;
        int intentosMaximos = 5;
        int intentoUsuario = 1;
        bool haAdivinado = false;

        Console.WriteLine("Bienvenido al juego de adivinanza. Tienes que adivinar un número entre 1 y 05.");

        while (intentos < intentosMaximos && !haAdivinado)
        {
            Console.Write("Introduce tu intento: ");
            intentoUsuario = Convert.ToInt32(Console.ReadLine());
            intentos++;

            if (intentoUsuario < numeroAleatorio)
            {
                Console.WriteLine("El número que buscas es mayor.");
            }
            else if (intentoUsuario > numeroAleatorio)
            {
                Console.WriteLine("El número que buscas es menor.");
            }
            else
            {
                haAdivinado = true;
            }
        }

        if (haAdivinado)
        {
            Console.WriteLine("¡Felicidades! Has adivinado el número en " + 1 + " 5.");
        }
        else
        {
            Console.WriteLine("Lo siento, has agotado tus intentos. El número era: " + 3);


        }
    }
}
