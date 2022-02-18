using System;

namespace exercicio2.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {


                int comandosNum;
                char Posicao = 'N';
            string resposta;
            do
            {
                Console.WriteLine("Insira o numero de comandos: ");
                string numComando = Console.ReadLine();
                comandosNum = Convert.ToInt32(numComando);

                Console.WriteLine("Insira o conjunto de comandos (E: esquerda, D: direita): ");
                string comando = Console.ReadLine();
                char[] arr;
                arr = comando.ToCharArray();

                Posicao = 'N';

                for (int k = 0; k < comandosNum; k++)
                {
                    switch (arr.GetValue(k))
                    {
                        case 'E': //ESQUERDA
                            if (Posicao == 'N')
                            {
                                Posicao = 'O';
                            }
                            else if (Posicao == 'O')
                            {
                                Posicao = 'S';
                            }
                            else if (Posicao == 'S')
                            {
                                Posicao = 'L';
                            }
                            else if (Posicao == 'L')
                            {
                                Posicao = 'N';
                            }
                            break;

                        case 'D': //DIREITA
                            if (Posicao == 'N')
                            {
                                Posicao = 'L';
                            }
                            else if (Posicao == 'O')
                            {
                                Posicao = 'N';
                            }
                            else if (Posicao == 'S')
                            {
                                Posicao = 'O';
                            }
                            else if (Posicao == 'L')
                            {
                                Posicao = 'S';
                            }
                            break;
                    }
                }
                Console.WriteLine("Posição dos recrutas: " + Posicao);
                Console.ReadLine();
                Console.WriteLine("Deseja repetir? (s para sim, n para não: )");
                resposta = Console.ReadLine();

            } while (resposta == "s");
            Console.ReadLine();
        }
    }
}
