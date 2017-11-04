using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            string bin;
            bool operacao=false;
            int s, n;
            int calc;
            Console.ForegroundColor = ConsoleColor.DarkGreen;







            do
            {
               
                Console.WriteLine("\n\n\n insira um numero para escolher a operação a efectuar, este ciclo acaba com o valor -1"+"\n\n--------------------------------------------------------------------------------------");
                Console.Write(" 1 - soma;"); Console.Write("\t\t2 - subtração;"); Console.Write(" \t\t\t     3 - multiplicação;");
                Console.Write("\n\n 4 - divisão;"); Console.Write("\t\t 5 - quadrado do numero;"); Console.Write("\t\t 6 - cubo de um numero;");
                Console.Write("\n\n 7 - elevar à potência; "); Console.Write(" 8 - Inverso do numero;"); Console.Write("\t\t\t 9 - Percentagem do numero;");
                Console.Write("\n\n 10 - raiz quadrada;"); Console.Write("\t 11 - seno ;"); Console.Write("\t\t\t\t12 - cosseno;");
                Console.Write("\n\n 13 - tangente"); Console.Write("\t\t 14 - conversao decimal para binario"); Console.Write("\t 15 - conversao binario para decimal");
                Console.Write("\n\n 16 - Resto da divisao inteira"); Console.Write("\t 17 - Quociente da divisão inteira\n\n");
                calc = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (calc)
                {
                    
                    case 1:
                        Console.WriteLine("insira os 2 numeros para a soma");
                        x = double.Parse(Console.ReadLine()); y = double.Parse(Console.ReadLine());
                        Console.WriteLine("\n\n  igual a " + (x + y));
                        break;
                        

                    case 2:
                        Console.WriteLine("insira os 2 numeros para a subtracao");
                        x = double.Parse(Console.ReadLine()); y = double.Parse(Console.ReadLine());
                        Console.WriteLine("\n\n  e igual a " + (x - y));
                        break;

                    case 3:
                        Console.WriteLine("insira os 2 numeros para a multiplicacao");
                        x = double.Parse(Console.ReadLine()); y = double.Parse(Console.ReadLine());
                        Console.WriteLine("\n\n igual a " + (x * y));
                        break;
                    case 4:
                        Console.WriteLine("insira os 2 numeros para a divisao");
                        x = double.Parse(Console.ReadLine()); y = double.Parse(Console.ReadLine());
                        if (y == 0) { Console.WriteLine("\n\n erro o denominador é igual a 0"); break; }
                        Console.WriteLine("\n\n igual a " + (x / y));
                        break;
                    case 5:
                        Console.WriteLine("insira o numero para calcular o seu  quadrado");
                        x = double.Parse(Console.ReadLine());
                        Console.WriteLine("\n\n igual a " + (x * x));
                        break;
                    case 6:
                        Console.WriteLine("insira o numero para calcular o seu cubo");
                        x = double.Parse(Console.ReadLine());
                        Console.WriteLine("\n\n igual a " + (x * x * x));
                        break;
                    case 7:
                        Console.WriteLine("insira dois numeros para efectuar a potência do primeiro inserido");
                        x = double.Parse(Console.ReadLine()); y = double.Parse(Console.ReadLine());
                        Console.WriteLine("\n\n igual a " + Math.Pow(x, y));
                        break;
                    case 8:
                        Console.WriteLine("insira um numero para calcular o seu inverso");
                        x = double.Parse(Console.ReadLine());
                        Console.WriteLine("\n\n igual a " + (1 / x));
                        break;

                    case 9:
                        Console.WriteLine("insira dois numeros para calcular a percentagem sendo o primeiro dos numeros a percentagem pretendida");
                        x = double.Parse(Console.ReadLine()); y = double.Parse(Console.ReadLine());
                        Console.WriteLine("\n\n igual a " + (x / y) * 100);
                        break;
                    case 10:
                        Console.WriteLine("insira um numero para calcular a sua raiz quadrada");
                        x = double.Parse(Console.ReadLine());
                        Console.WriteLine("\n\n igual a " + Math.Sqrt(x));
                        break;
                    case 11:
                        Console.WriteLine("insira um numero para calcular  o seno");
                        x = double.Parse(Console.ReadLine());
                        Console.WriteLine("\n\n igual a " + Math.Sin((Math.PI*x)/180));
                        break;
                    case 12:
                        Console.WriteLine("insira um numero para calcular o cosseno");
                        x = double.Parse(Console.ReadLine());
                        Console.WriteLine("\n\n igual a " + Math.Cos((Math.PI * x) / 180));
                        break;
                    case 13:
                        Console.WriteLine("insira um numero para calcular a Tangente");
                        x = double.Parse(Console.ReadLine());
                        Console.WriteLine("\n\n igual a " + Math.Tan((Math.PI * x) / 180)); ;
                        break;
                    case 14:
                        Console.WriteLine("insira um numero para converter de decimal para binario ");
                        x = double.Parse(Console.ReadLine());
                        bin = Convert.ToString((int)x, 2);
                        Console.WriteLine("igual a " + bin);
                        break;
                    case 15:
                        Console.WriteLine("insira um numero para converter de binario para decimal");
                        bin = Console.ReadLine();
                        long dec = Convert.ToInt64(bin, 2);
                        Console.WriteLine("igual a " + dec);
                        break;
                    case 16:
                        Console.WriteLine("insira dois valores para obter o resto da divisao inteira");
                        x = double.Parse(Console.ReadLine()); y = double.Parse(Console.ReadLine());
                        Console.WriteLine("\n\n igual a " + (x % y));
                        break;
                    case 17:
                        Console.WriteLine("insira um numero para obter o quociente da divisão inteira");
                        x = double.Parse(Console.ReadLine());
                        Console.WriteLine("\n\n igual a " + (x / 10));
                        break;



                        

                }
                
            }
            while (calc != -1) ;
                    
           
            



        }
    }
}
