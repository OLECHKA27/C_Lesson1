internal class Program
{
    private static void Main(string[] args)
    {
        // Гири
        int G1 = 5;
        int G2 = 4;
        int maxG = 0; // Объявляем переменную для хранения максимального веса

        if (G1 > G2)
        {
            Console.WriteLine($"Максимальный вес: G1 = {G1}");
            maxG = G1;
        }
        else
        {
            Console.WriteLine($"Максимальный вес: G2 = {G2}");
            maxG = G2;
        }

        int G3 = 9;
        int G4 = 25;

        if (G3 > G4)
        {
            Console.WriteLine($"Максимальный вес: G3 = {G3}");
            if (G3 > maxG)
            {
                Console.WriteLine($"Новый максимальный вес: {G3}");
                maxG = G3;
            }
        }
        else
        {
            Console.WriteLine($"Максимальный вес: G4 = {G4}");
            if (G4 > maxG)
            {
                Console.WriteLine($"Новый максимальный вес: {G4}");
                maxG = G4;
            }
        }

        // Выводим итоговый максимальный вес
        Console.WriteLine($"Итоговый максимальный вес: {maxG}");
    }
}
