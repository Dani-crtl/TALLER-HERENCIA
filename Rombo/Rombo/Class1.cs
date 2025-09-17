using System;

namespace Rombo
{
    class FiguraRombo
    {
        public int Tamaño { get; private set; }

        public FiguraRombo(int tamaño)
        {
            if (tamaño < 1 || tamaño % 2 == 0)
                throw new ArgumentException("El tamaño debe ser un número impar mayor que 0.");

            Tamaño = tamaño;
        }

        public void Dibujar()
        {
            for (int i = 1; i <= Tamaño; i += 2)
            {
                Console.WriteLine(new string(' ', (Tamaño - i) / 2) + new string('#', i));
            }

            for (int i = Tamaño - 2; i >= 1; i -= 2)
            {
                Console.WriteLine(new string(' ', (Tamaño - i) / 2) + new string('#', i));
            }
        }
    }

    public class Program
    {
        // Este es el punto de entrada válido
        public static void Main(string[] args)
        {
            Console.Write("Ingrese el tamaño del rombo: ");
            if (int.TryParse(Console.ReadLine(), out int tamaño))
            {
                try
                {
                    FiguraRombo rombo = new FiguraRombo(tamaño);
                    rombo.Dibujar();
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Debe ingresar un número entero.");
            }
        }
    }
}