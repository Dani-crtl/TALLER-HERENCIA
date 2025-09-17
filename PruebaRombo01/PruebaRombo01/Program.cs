using System;

class Rombo
{
    public int Tamaño { get; private set; }

    public Rombo(int tamaño)
    {
        if (tamaño < 1 || tamaño % 2 == 0)
            throw new ArgumentException("El tamaño debe ser un número impar mayor que 0.");

        Tamaño = tamaño;
    }

    public void Dibujar()
    {
        // Parte superior
        for (int i = 1; i <= Tamaño; i += 2)
        {
            Console.WriteLine(new string(' ', (Tamaño - i) / 2) + new string('#', i));
        }

        // Parte inferior
        for (int i = Tamaño - 2; i >= 1; i -= 2)
        {
            Console.WriteLine(new string(' ', (Tamaño - i) / 2) + new string('#', i));
        }
    }
}
