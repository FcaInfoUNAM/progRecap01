using System;

class Program
{
    static void Main()
    {
        // Arrays declaration
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        string[] qualities = { "alto", "bronceado", "guapo", "rico", "sexy", "tierno", "rudo" };

        // Hello world
        Console.WriteLine("hello world");

        // For loop and if
        for (int i = 1; i <= 10; i++)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine($"{i} no es par");
                //PREGUNTA 1
                //no existe f de format en el print pero existe el simbolo
                //de pesos que es equivalente y da a entender la localizacion 
                //de variables a lo largo de la impresion para facilitar 
                //la lectura de codigo y variables a imprimir
            }
        }

    //For loop
        for (int i = 0; i < array.Length; i++)
        {
          if (array[i] % 2 != 0)
          {
            Console.WriteLine($"{array[i]} no es par");
          }
        }

    // Switch-like structure and read options
    static void cuestionar_cualidades(string[] qualities)
    {
        int score = 0;
        foreach (var quality in qualities)
        {
            Console.Write($"Es {quality}? (Y/N): ");
            char prompt = Console.ReadLine()[0];
            if (prompt == 'Y')
            {
                score =+ 1;   
            }    
        }
        if(score<4){
            Console.WriteLine("¡Apúrate o te lo ganan!");
        }
        else if (score<2)
        {
            Console.WriteLine("Maomeno");
        }
        else
        {
            Console.WriteLine("no te conviene");
        }
    }
    
    //PREGUNTA 2
    //Se supone a partir de una respuesta simple de Y o N se va calificando si
    //es buen pretendiente o no a partir de eso (modifique la N por Y y los > por <
    // para que funcione bien )

    // Append to array
    static void agregar_cualidades(ref string[] qualities){
        qualities = qualities.Append(Console.ReadLine()).ToArray();
    }
    
    //PREGUNTA 3
    //El arreglo que se utiliza, se declaro a inicio del codigo y el uso
    //de funciones nos ayuda a la comprension de codigo, ademas de una
    //sencilla o mas directa forma de implementar codigo que ya se hizo
    //o que nosotros creamos para su implementacion a lo largo de un
    //codigo
    //La variable flag tiene como objetivo cambiar el flujo del ciclo
    //para saber si sigue o no el ciclo while

    // Print array
    Console.WriteLine("Quealities:");
    foreach (var quality in qualities)
    {
        Console.WriteLine(quality);
    }

    // While loop
    bool flag = true;
    while (flag)
    {
        Console.Write("Deseas agregar más condiciones? (Y/N): ");
        if (Console.ReadLine() == "Y")
        {
            Console.Write("Escribe la propiedad: ");
            qualities = qualities.Append(Console.ReadLine()).ToArray();
        }
        else
        {
            flag = false;
        }
    }
    
    static void imprimir_cualidades(string[] qualities)
    {
        Console.WriteLine("Cualidades:");
        foreach (var quality in qualities)
        {
            Console.WriteLine(quality);
        }
    }

    static void calcular_score(string[] qualities)
    {
        int score = qualities.Length * 10; // Puntuación simple, 10 puntos por cada cualidad
        Console.WriteLine($"Tu score es: {score}");
    }

    static void dar_respuesta(int score)
    {
        Console.WriteLine($"Tu score es: {score}%");

        if (score == 100)
        {
            Console.WriteLine("Es perfecto.");
        }
        else if (score >= 80)
        {
            Console.WriteLine("Aplícate o te lo ganan.");
        }
        else if (score >= 60)
        {
            Console.WriteLine("Maomeno.");
        }
        else if (score >= 40)
        {
            Console.WriteLine("No te lo recomiendo.");
        }
        else
        {
            Console.WriteLine("Corre y no mires atrás.");
        }
    }

    }

}
