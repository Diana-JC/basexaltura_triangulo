// See https://aka.ms/new-console-template for more information
Console.WriteLine("");

// triangulo


//b= es la base
//h= es la altura


Console.WriteLine("Ingrese su base:");
double b = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese su altura:");
double h = Convert.ToDouble(Console.ReadLine());

Console.WriteLine();
Console.WriteLine();

double area = calculo(b, h);
Console.WriteLine(area);

static double calculo(double b, double h)

{

    double area = b * h / 2;
    return area;

}

