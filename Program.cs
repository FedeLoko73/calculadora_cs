using System;
using System.Collections.Generic;
using System.Text;

namespace calculadora_errores
{
    class Program
    {
        static void Main(string[] args)
        {
            string Cadena;
float Num1, Num2;
char Oper;
float Resultado;
Console.WriteLine("Ingrese Primer Numero");
Cadena = Console.ReadLine();
Num1 = float.Parse(Cadena);
Console.WriteLine("Ingrese Segundo Numero");
Cadena = Console.ReadLine();
Num2 = float.Parse(Cadena);
Console.WriteLine("Ingrese Operador");
Cadena = Console.ReadLine();
Oper = char.Parse(Cadena);
switch (Oper)
{
case '+':
{
Resultado = Sumar(Num1,Num2);
Console.WriteLine("El Resultado es: {0}", Resultado);
break;
}
case '-':
{
Resultado = Restar(Num1, Num2);
Console.WriteLine("El Resultado es: {0}", Resultado);
break;
}
case '*':
{
Resultado = Multiplicar(Num1, Num2);
Console.WriteLine("El Resultado es: {0}", Resultado);
break;
}
case '/':
{
try
{
Resultado = Dividir(Num1, Num2);
Console.WriteLine("El Resultado es: {0}", Resultado);
}
catch (Exception e)
{
Console.WriteLine("Error: {0}", e.Message);
Console.WriteLine("Por ayuda recurrir a: {0}", e.HelpLink);
Console.WriteLine("Software que genero el error: {0}", e.Source);
}
break;
}
}
Console.ReadKey();
}
static float Sumar(float N1, float N2)
{
return N1 + N2;
}
static float Restar(float N1, float N2)
{
return N1 - N2;
}
static float Multiplicar(float N1, float N2)
{
return N1 * N2;
}
static float Dividir(float N1, float N2)
{
if (N2 != 0)
{
return N1 / N2;
}
else
{
Exception Excep = new Exception("Intento de division por cero.");
Excep.HelpLink = "Consultar Fundamentos Matematicos.";
Excep.Source = "Programa Calculadora";
throw Excep;
}
}

            
}
        }
    


