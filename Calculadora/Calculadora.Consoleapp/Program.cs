using System;

namespace Calculadora.ConsoleApp
{
    class Program
    {
        #region Requisito 01 [OK]
        //Nossa calculadora deve ter a possibilidade de somar dois números
        #endregion

        #region Requisito 02 [OK]
        //Nossa calculadora deve ter a possibilidade fazer várias operações de soma
        #endregion

        #region Requisito 03 [OK]
        //Nossa calculadora deve ter a possibilidade fazer várias operações de soma e de subtração
        #endregion

        #region Requisito 04 [OK]
        //Nossa calculadora deve ter a possibilidade fazer as quatro operações básicas da matemática
        #endregion

        #region Requisito 05 [OK]
        //Nossa calculadora deve validar a opções do menu [OK]
        #endregion

        #region BUG 01 [OK]
        //Nossa calculadora deve realizar as operações com "0"
        #endregion

        #region Requisito 06 [OK]
        /** Nossa calculadora deve permitir visualizar as operações já realizadas
         *  Critérios:
         *      1 - A descrição da operação realizada deve aparecer assim, exemplo:
         *          2 + 2 = 4
         *          10 - 5 = 5
         */
        #endregion

        static void Main(string[] args)
        {
            string[] operacoesRealizadas = new string[100];
            string opcao = "";
            int contadorOperacoesRealizadas = 0;
            double primeiroNumero, segundoNumero;
            double resultado = 0;
            string simboloOperacao = "";

            while(true)
            {
                Console.WriteLine(".................Calculadora Tabajara 1.6.1...................");

                Console.WriteLine();

                Console.WriteLine("Digite 1 para somar...........................................");

                Console.WriteLine("Digite 2 para subtrair........................................");

                Console.WriteLine("Digite 3 para multiplicação...................................");

                Console.WriteLine("Digite 4 para divisão.........................................");

                Console.WriteLine("Digite 5 para visualizar o histórico das operações realizadas.");

                Console.WriteLine("Digite 6 para sair............................................");

                opcao = Console.ReadLine();


                if (opcao != "1" && opcao != "2" && opcao != "3"
                    && opcao != "4" && opcao != "5"
                    && opcao != "6") //AND 
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Opção inválida! Tente novamente");

                    Console.ResetColor();

                    Console.ReadLine();

                    Console.Clear();

                    continue;
                }

                if(opcao == "6")
                {
                    break;
                }

                if (opcao == "5")
                {
                    Console.WriteLine();
                    if (contadorOperacoesRealizadas == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Não há histórico de operações realizadas");
                        Console.ResetColor();
                    }
                    else
                    {
                        for (int i = 0; i < operacoesRealizadas.Length; i++)
                        {
                            if (operacoesRealizadas != null)
                            {
                                Console.WriteLine(operacoesRealizadas[i]);
                            }
                        }
                    }
                    Console.ReadLine();
                    Console.Clear();
                    continue;

                }

                Console.Clear();
                Console.Write("Digite o primeiro número: ");
                primeiroNumero = Convert.ToDouble(Console.ReadLine());

                do
                {
                    Console.Write("Digite o segundo número: ");
                    segundoNumero = Convert.ToDouble(Console.ReadLine());

                    if (opcao == "4" && segundoNumero == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("Segundo número inválido! Tente novamente");

                        Console.ResetColor();

                        Console.ReadLine();
                    }

                } while (opcao == "4" && segundoNumero == 0);


                switch (opcao)
                {
                    case "1":
                        resultado = primeiroNumero + segundoNumero;
                        simboloOperacao = "+";
                        break;

                    case "2":
                        resultado = primeiroNumero - segundoNumero;
                        simboloOperacao = "-";
                        break;

                    case "3":
                        resultado = primeiroNumero * segundoNumero;
                        simboloOperacao = "*";
                        break;

                    case "4":
                        resultado = primeiroNumero / segundoNumero;
                        simboloOperacao = "/";
                        break;

                    default:
                        break;
                }

                string operacaoRealizada = primeiroNumero.ToString() + " " + simboloOperacao + " " + segundoNumero.ToString() + " = " + resultado.ToString();
                operacoesRealizadas[contadorOperacoesRealizadas] = operacaoRealizada;
                contadorOperacoesRealizadas++;


                Console.WriteLine(resultado);

                Console.WriteLine();

                Console.WriteLine(operacaoRealizada);

                Console.ReadLine();

                Console.Clear();

            } 
        } 
    }
}
