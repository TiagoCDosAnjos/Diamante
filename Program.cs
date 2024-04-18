namespace DesafioDiamante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, espacos, x;

            Console.Write("Insira um número ímpar: ");
            numero = int.Parse(Console.ReadLine());

            if (numero % 2 != 0)
            {
                x = 1;
                espacos = (numero) / 2;

                for (int i = 1; espacos > 0; i++)
                {
                    for (int j = 1; j <= espacos; j++)
                    {
                        Console.Write(" ");
                    }

                    for (int k = 1; k <= x; k++)
                    {
                        Console.Write("X");
                    }

                    espacos--;
                    x += 2;
                    Console.WriteLine();
                }

                for (int i = 1; x > 0; i++)
                {
                    for (int j = 1; j <= espacos; j++)
                    {
                        Console.Write(" ");
                    }

                    for (int k = 1; k <= x; k++)
                    {
                        Console.Write("X");
                    }

                    espacos++;
                    x -= 2;
                    Console.WriteLine();
                }
            }

            else
            {
                Console.WriteLine("Não é ímpar!");
            }

            Console.ReadKey();
        }
    }
}

