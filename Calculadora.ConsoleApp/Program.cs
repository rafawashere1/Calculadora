namespace Calculadora.ConsoleApp
{
    public class Calculadora
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("--------- Calculadora Top 2023 ---------");
                Console.WriteLine(">> Digite 1 para somar");
                Console.WriteLine(">> Digite 2 para subtrair");
                Console.WriteLine(">> Digite 3 para multiplicar");
                Console.WriteLine(">> Digite 4 para dividir");
                Console.WriteLine(">> Digite 5 para criar uma tabuada");
                Console.WriteLine(">> Digite sair para fechar a calculadora");

                string operacao = Console.ReadLine().ToLower();

                if (operacao != "1" && operacao != "2" && operacao != "3" && operacao != "4" && operacao != "5" && operacao != "sair")
                {
                    Console.WriteLine(">> Comando inválido, pressione enter para voltar ao menu");
                    Console.ReadLine();
                    continue;
                }

                if (operacao == "sair")
                {
                    Console.WriteLine(">> Fechando a calculadora.");
                    break;
                }

                if (operacao == "5")
                {
                    Console.Clear();
                    Console.WriteLine("---------- Tabuada ---------");
                    Console.WriteLine();
                    Console.Write(">> Digite o número para gerar a tabuada: ");
                    int tabuada = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("---------- Tabuada ---------");
                    Console.WriteLine();

                    for (int i = 1; i <= 10; i++)
                    {
                        int resultadoMultiplicacao = tabuada * i;
                        Console.WriteLine($">> {tabuada} x {i} = {resultadoMultiplicacao}");
                    }
                    Console.WriteLine();
                    Console.WriteLine(">> Pressione enter para voltar ao menu.");
                    Console.ReadLine();
                    continue;
                }

                decimal resultado = 0;
                decimal primeiroNumero = 0;
                decimal segundoNumero = 0;

                switch (operacao)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("---------- Adição ---------");
                        Console.WriteLine();
                        Console.Write(">> Digite o primeiro número: ");

                        primeiroNumero = Convert.ToDecimal(Console.ReadLine());

                        Console.Write(">> Digite o segundo número: ");

                        segundoNumero = Convert.ToDecimal(Console.ReadLine());

                        resultado = primeiroNumero + segundoNumero;
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("---------- Subtração ---------");
                        Console.WriteLine();
                        Console.Write(">> Digite o primeiro número: ");

                        primeiroNumero = Convert.ToDecimal(Console.ReadLine());

                        Console.Write(">> Digite o segundo número: ");

                        segundoNumero = Convert.ToDecimal(Console.ReadLine());

                        resultado = primeiroNumero - segundoNumero;
                        break;
                   
                    case "3":
                        Console.Clear();
                        Console.WriteLine("---------- Multiplicação ---------");
                        Console.WriteLine();
                        Console.Write(">> Digite o primeiro número: ");

                        primeiroNumero = Convert.ToDecimal(Console.ReadLine());

                        Console.Write(">> Digite o segundo número: ");

                        segundoNumero = Convert.ToDecimal(Console.ReadLine());

                        resultado = primeiroNumero * segundoNumero;
                        break;
                   
                    case "4":
                        Console.Clear();
                        Console.WriteLine("---------- Divisão ---------");
                        Console.WriteLine();
                        Console.Write(">> Digite o primeiro número: ");

                        primeiroNumero = Convert.ToDecimal(Console.ReadLine());

                        Console.Write(">> Digite o segundo número: ");

                        segundoNumero = Convert.ToDecimal(Console.ReadLine());

                        while (segundoNumero == 0)
                        {
                            Console.Write(">> Segundo número não pode ser 0, digite outro: ");
                            segundoNumero = Convert.ToDecimal(Console.ReadLine());
                        }

                        resultado = primeiroNumero / segundoNumero;
                        break;

                    default:
                        break;
                }
                
                #region if-else 
                //if (operacao == "1")
                //{
                //    Console.Clear();
                //    Console.WriteLine("---------- Adição ---------");
                //    Console.WriteLine();
                //    Console.Write(">> Digite o primeiro número: ");

                //    decimal primeiroNumero = Convert.ToDecimal(Console.ReadLine());

                //    Console.Write(">> Digite o segundo número: ");

                //    decimal segundoNumero = Convert.ToDecimal(Console.ReadLine());

                //    resultado = primeiroNumero + segundoNumero;
                //}

                //else if (operacao == "2")
                //{
                //    Console.Clear();
                //    Console.WriteLine("---------- Subtração ---------");
                //    Console.WriteLine();
                //    Console.Write(">> Digite o primeiro número: ");

                //    decimal primeiroNumero = Convert.ToDecimal(Console.ReadLine());

                //    Console.Write(">> Digite o segundo número: ");

                //    decimal segundoNumero = Convert.ToDecimal(Console.ReadLine());

                //    resultado = primeiroNumero - segundoNumero;
                //}

                //else if (operacao == "3")
                //{
                //    Console.Clear();
                //    Console.WriteLine("---------- Multiplicação ---------");
                //    Console.WriteLine();
                //    Console.Write(">> Digite o primeiro número: ");

                //    decimal primeiroNumero = Convert.ToDecimal(Console.ReadLine());

                //    Console.Write(">> Digite o segundo número: ");

                //    decimal segundoNumero = Convert.ToDecimal(Console.ReadLine());

                //    resultado = primeiroNumero * segundoNumero;
                //}

                //else if (operacao == "4")
                //{
                //    Console.Clear();
                //    Console.WriteLine("---------- Divisão ---------");
                //    Console.WriteLine();
                //    Console.Write(">> Digite o primeiro número: ");

                //    decimal primeiroNumero = Convert.ToDecimal(Console.ReadLine());

                //    Console.Write(">> Digite o segundo número: ");

                //    decimal segundoNumero = Convert.ToDecimal(Console.ReadLine());

                //    while (segundoNumero == 0)
                //    {
                //        Console.Write(">> Segundo número não pode ser 0, digite outro: ");
                //        segundoNumero = Convert.ToDecimal(Console.ReadLine());
                //    }

                //    resultado = primeiroNumero / segundoNumero;
                //}
                #endregion

                decimal resultadoFormatado = Math.Round(resultado, 2);
                Console.WriteLine();
                Console.WriteLine(">> O resultado é: " + resultadoFormatado);
                Console.WriteLine();
                Console.WriteLine(">> Pressione enter para voltar ao menu.");
                Console.ReadLine();
            }
            while (true);

        }
    }
}