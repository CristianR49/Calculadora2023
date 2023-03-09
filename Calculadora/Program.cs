namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)

        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("5 - Tabuada de um número");

                Console.WriteLine("s - Sair");

                string Operacao = Console.ReadLine();
                if (Operacao != "1" && Operacao != "2" && Operacao != "3" && Operacao != "4" && Operacao != "5" && Operacao != "s")
                {
                    Console.WriteLine("Opção inválida");
                    Console.ReadLine();
                    continue;
                }
                if (Operacao == "s")
                {
                    break;
                }

                if (Operacao == "5")
                {
                    Console.Write("Digite o número da tabuada: ");
                    int tabuada = Convert.ToInt32(Console.ReadLine());



                    for (int numero = 1; numero <= 10; numero++)
                    {
                        Console.WriteLine(numero + " X " + tabuada + " = " + numero * tabuada);
                    }
                    Console.ReadLine();
                    continue;
                }

                //if
                Console.WriteLine("Digite o primeiro numero");
                int PrimeiroN = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o segundo numero");
                int SegundoN = Convert.ToInt32(Console.ReadLine());
                int Resultado;



                if (Operacao == "1")
                {
                    Resultado = PrimeiroN + SegundoN;
                    Console.WriteLine("Resultado: " + Resultado);
                }
                if (Operacao == "2")
                {
                    Resultado = PrimeiroN - SegundoN;
                    Console.WriteLine("Resultado: " + Resultado);
                }
                if (Operacao == "3")
                {
                    Resultado = PrimeiroN * SegundoN;
                    Console.WriteLine("Resultado: " + Resultado);
                }
                if (Operacao == "4")
                {
                    if (SegundoN == 0)
                    {
                        Console.WriteLine("Numero inválido");
                        Console.ReadLine();
                        continue;
                    }

                    Decimal ResultadoDeci = Convert.ToDecimal(PrimeiroN) / Convert.ToDecimal(SegundoN);
                    Console.WriteLine("Resultado: " + Math.Round(ResultadoDeci, 2));
                }
                Console.ReadLine();
            }
        }
    }
}