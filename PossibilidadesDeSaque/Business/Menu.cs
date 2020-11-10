using System;

namespace PossibilidadesDeSaque.Business
{
    public class Menu
    {
        public static void MenuEntrada()
        {
            do
            {
                Console.Clear();

                Console.Write("Digite o valor do saque: ");
                int vlrSaque = int.Parse(Console.ReadLine());


                Console.Write("Valor da nota R$ ");
                int n1 = int.Parse(Console.ReadLine());

                Console.Write("Valor da nota R$ ");
                int n2 = int.Parse(Console.ReadLine());

                Console.Write("Valor da nota R$ ");
                int n3 = int.Parse(Console.ReadLine());

                Console.Write("Valor da nota R$ ");
                int n4 = int.Parse(Console.ReadLine());

                Console.Write("Valor da nota R$ ");
                int n5 = int.Parse(Console.ReadLine());

                Console.WriteLine("##########################################");

                QtdNotas.ContaNotas(vlrSaque, n5, n4, n3, n2, n1);

            } while (true);
        }
    }
}
