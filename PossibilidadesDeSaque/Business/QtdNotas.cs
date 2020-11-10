using System;

namespace PossibilidadesDeSaque.Business
{
    public class QtdNotas
    {
        public static void ContaNotas(int valor, int n5, int n4, int n3, int n2, int n1)
        {
            int[] nota = { n5, n4, n3, n2, n1 };

            int vlr = valor;
            string result = "";
            int i = 0;

            while (vlr != 0)
            {
                try
                {
                    int notas = vlr / nota[i];
                    if (notas != 0)
                    {
                        result = Convert.ToString((notas + " nota(s) de R$ " + nota[i]));
                        vlr = vlr % nota[i];
                        Console.WriteLine(result);
                    }
                    i = i + 1;
                    
                }
                catch (Exception)
                {
                    Console.WriteLine("O valor não pode ser sacado integralmente, por falta de notas disponíveis!");
                    Console.WriteLine("Pressione ENTER para escolher um novo valor.");
                    Console.ReadLine();
                    Menu.MenuEntrada();
                }
            }

            Console.WriteLine("Pressione ENTER para continuar...");
            Console.ReadLine();
            Menu.MenuEntrada();
        }
    }
}
