class Program
{
    static void Main()
    {
        // Введення довжин сторін від користувача
        Console.Write("Введіть довжину першої сторони прямокутника: ");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть довжину другої сторони прямокутника: ");
        double side2 = Convert.ToDouble(Console.ReadLine());

        // Створення об'єкта класу Rectangle
        Rectangle rectangle = new Rectangle(side1, side2);

        // Виведення периметру та площі на екран
        Console.WriteLine($"Периметр прямокутника: {rectangle.Perimeter}");
        Console.WriteLine($"Площа прямокутника: {rectangle.Area}");
    }
}