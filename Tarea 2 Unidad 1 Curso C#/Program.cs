using System.Threading.Channels;

Console.WriteLine("Un programa que divida dos números");
Console.WriteLine("Escriba el primer número");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Escriba el segundo número");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine($"{num1} / {num2} = {num1/num2}");
Console.WriteLine("");

Console.WriteLine("Un programa que multiplique dos números");
Console.WriteLine("Escriba el primer número");
num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Escriba el segundo número");
num2 = int.Parse(Console.ReadLine());
Console.WriteLine($"{num1} x {num2} = {num1 * num2}");
Console.WriteLine("");

Console.WriteLine("ResolverCuadratica");
Console.WriteLine("Escriba el primer número");
num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Escriba el segundo número");
num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Escriba el tercer número");
int num3 = int.Parse(Console.ReadLine());
double discriminante = num2 * num2 - 4 * num1 * num3;

if (discriminante < 0)
{
   Console.WriteLine("No hay soluciones reales"); // No hay soluciones reales
}
else
{
    double sqrtDiscriminante = Math.Sqrt(discriminante);
    double x1 = (-num2 + sqrtDiscriminante) / (2 * num1);
    double x2 = (-num2 - sqrtDiscriminante) / (2 * num1);
    Console.WriteLine($"Resultado = {x1} y {x2}");
}
Console.WriteLine("");

Console.WriteLine("Programa que imprima los numeros impares del 1 al 30");
for (int i = 1; i < 30; i+= 2)
{
    Console.Write($"{i} ");
}
Console.WriteLine("");
Console.WriteLine("");


Console.WriteLine("Desarrollar un programa que imprima los números de la serie Fibonacci del 1 al 50");
int numero = 0, numContener = 1, resultado = 0;
while (resultado < 50)
{
    Console.WriteLine(resultado);
    resultado = numero + numContener;
    numero = numContener;
    numContener = resultado;
}

