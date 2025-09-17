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