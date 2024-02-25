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
    //Se supone a partir de una respuesta simple de Y o N se va calificando si
    //es buen pretendiente o no a partir de eso (modifique la N por Y y los > por <
    // para que funcione bien )

        // Append to array
        // if (Console.ReadLine() == "Y")
        // {
        //     Console.Write("Escribe la propiedad: ");
        //     qualities = qualities.Append(Console.ReadLine()).ToArray();
        // }

        // Print array
        // Console.WriteLine("Quealities:");
        // foreach (var quality in qualities)
        // {
        //     Console.WriteLine(quality);
        // }

        // While loop
        // bool flag = true;
        // while (flag)
        // {
        //     Console.Write("Deseas agregar más condiciones? (Y/N): ");
        //     if (Console.ReadLine() == "Y")
        //     {
        //         Console.Write("Escribe la propiedad: ");
        //         qualities = qualities.Append(Console.ReadLine()).ToArray();
        //     }
        //     else
        //     {
        //         flag = false;
        //     }
        // }
        // Console.WriteLine("Quealities:");
        // foreach (var quality in qualities)
        // {
        //     Console.WriteLine(quality);
        // }
    }
}
