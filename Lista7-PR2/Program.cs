using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista7_PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("   Menu");
            Console.WriteLine("exercício1");
            Console.WriteLine("exercício2");
            Console.WriteLine("exercício3");
            Console.WriteLine("exercício4");
            Console.WriteLine("exercício5");
            Console.WriteLine("exercício6");
            Console.WriteLine("exercício7");
            int exec = int.Parse(Console.ReadLine());

            switch (exec)
            {
                case 1:
                    int quantidadeTotal = 0;
                    decimal valorTotal = 0;

                    while (true)
                    {
                        Console.Write("Digite a quantidade de itens adquiridos (ou <= 0 para encerrar): ");
                        int quantidade = int.Parse(Console.ReadLine());

                        if (quantidade <= 0)
                            break;

                        Console.Write("Digite o preço do produto: ");
                        decimal preco = decimal.Parse(Console.ReadLine());

                        quantidadeTotal += quantidade;
                        valorTotal += quantidade * preco;
                    }

                    Console.WriteLine($"Quantidade total de itens adquiridos: {quantidadeTotal}");
                    Console.WriteLine($"Valor total da compra: R${valorTotal}");
                    break;

                case 2:
                    string nomeProduto;
                    int quantidade;
                    decimal preco;
                    decimal maiorInvestimento = decimal.MinValue;
                    decimal menorInvestimento = decimal.MaxValue;
                    string nomeProdutoMaiorInvestimento = "";
                    string nomeProdutoMenorInvestimento = "";

                    while (true)
                    {
                        Console.Write("Digite o nome do produto (ou 'parar' para encerrar): ");
                        nomeProduto = Console.ReadLine();

                        if (nomeProduto.ToLower() == "parar")
                            break;

                        Console.Write("Digite a quantidade de itens: ");
                        quantidade = int.Parse(Console.ReadLine());

                        Console.Write("Digite o preço de compra: ");
                        preco = decimal.Parse(Console.ReadLine());

                        decimal investimentoTotal = quantidade * preco;

                        if (investimentoTotal > maiorInvestimento)
                        {
                            maiorInvestimento = investimentoTotal;
                            nomeProdutoMaiorInvestimento = nomeProduto;
                        }

                        if (investimentoTotal < menorInvestimento)
                        {
                            menorInvestimento = investimentoTotal;
                            nomeProdutoMenorInvestimento = nomeProduto;
                        }
                    }

                    Console.WriteLine($"Produto com maior investimento: {nomeProdutoMaiorInvestimento}, Valor: R${maiorInvestimento}");
                    Console.WriteLine($"Produto com menor investimento: {nomeProdutoMenorInvestimento}, Valor: R${menorInvestimento}");

                    break;

                case 3:
                    Console.Write("Digite o número de avaliações: ");
                    int numeroAvaliacoes = int.Parse(Console.ReadLine());

                    decimal somaPesos = 0;

                    for (int i = 1; i <= numeroAvaliacoes; i++)
                    {
                        Console.Write($"Digite o peso da avaliação {i}: ");
                        decimal peso = decimal.Parse(Console.ReadLine());
                        somaPesos += peso;
                    }

                    if (somaPesos < 100)
                    {
                        Console.WriteLine("Soma dos pesos é insuficiente (inferior a 100).");
                    }
                    else if (somaPesos > 100)
                    {
                        Console.WriteLine("Soma dos pesos é excedente (superior a 100).");
                    }
                    else
                    {
                        Console.WriteLine("Soma dos pesos é adequada (igual a 100).");
                    }

                    break;

                case 4:
                    Console.Write("Digite a sigla do estado: ");
                    string sigla = Console.ReadLine();

                    switch (sigla.ToUpper())
                    {
                        case "SP":
                            Console.WriteLine("São Paulo");
                            break;
                        case "RJ":
                            Console.WriteLine("Rio de Janeiro");
                            break;
                        case "MG":
                            Console.WriteLine("Minas Gerais");
                            break;
                        // adicione mais casos para outros estados...
                        default:
                            Console.WriteLine("Sigla de estado inválida.");
                            break;
                    }
                    break;

                case 5:
                    Console.Write("Digite um número inteiro entre 1 e 12: ");
                    int mes = int.Parse(Console.ReadLine());

                    switch (mes)
                    {
                        case 1:
                        case 2:
                            Console.WriteLine("Verão");
                            break;
                        case 3:
                        case 4:
                        case 5:
                            Console.WriteLine("Outono");
                            break;
                        case 6:
                        case 7:
                        case 8:
                            Console.WriteLine("Inverno");
                            break;
                        case 9:
                        case 10:
                        case 11:
                            Console.WriteLine("Primavera");
                            break;
                        case 12:
                            Console.Write("Digite '1' para Hemisfério Norte ou '2' para Hemisfério Sul: ");
                            int hemisferio = int.Parse(Console.ReadLine());

                            if (hemisferio == 1)
                                Console.WriteLine("Inverno");
                            else if (hemisferio == 2)
                                Console.WriteLine("Verão");
                            else
                                Console.WriteLine("Opção inválida.");
                            break;
                        default:
                            Console.WriteLine("Mês inválido.");
                            break;
                    }
                    break;

                case 6:
                    while (true)
                    {
                        Console.Write("Digite seu peso (em kg) ou 'parar' para encerrar: ");
                        string inputPeso = Console.ReadLine();

                        if (inputPeso.ToLower() == "parar")
                            break;

                        Console.Write("Digite sua altura (em metros): ");
                        double altura = double.Parse(Console.ReadLine());

                        double peso = double.Parse(inputPeso);
                        double imc = peso / (altura * altura);

                        Console.Write("Seu IMC é {0:f2}. ", imc);

                        if (imc < 18.5)
                            Console.WriteLine("Abaixo do peso.");
                        else if (imc < 25)
                            Console.WriteLine("Peso normal.");
                        else if (imc < 30)
                            Console.WriteLine("Sobrepeso.");
                        else if (imc < 35)
                            Console.WriteLine("Obesidade grau 1.");
                        else if (imc < 40)
                            Console.WriteLine("Obesidade grau 2.");
                        else
                            Console.WriteLine("Obesidade grau 3 (mórbida).");
                    }
                    break;
                case 7:
                    Console.Write("Digite um número maior que zero: ");
                    int numero = int.Parse(Console.ReadLine());

                    int divisor = 1;

                    while (divisor <= numero)
                    {
                        if (numero % divisor == 0)
                            Console.WriteLine(divisor);

                        divisor++;
                    }
                    break;
            }

        }
    }
}
