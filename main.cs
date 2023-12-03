using System;

class Rectangle
{
    private double side1;
    private double side2;

    // Конструктор класу
    public Rectangle(double side1, double side2)
    {
        this.side1 = side1;
        this.side2 = side2;
    }

    // Метод для обчислення площі прямокутника
    public double CalculateArea()
    {
        return side1 * side2;
    }

    // Метод для обчислення периметру прямокутника
    public double CalculatePerimeter()
    {
        return 2 * (side1 + side2);
    }

    // Властивість для отримання площі (з методом доступу get)
    public double Area
    {
        get { return CalculateArea(); }
    }

    // Властивість для отримання периметру (з методом доступу get)
    public double Perimeter
    {
        get { return CalculatePerimeter(); }
    }
}
