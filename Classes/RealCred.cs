using System;
using System.IO;
using Projeto_PI___REALCRED;
using Projeto_PI___REALCRED.Classes;
using Projeto_PI___REALCRED.obj;

namespace Projeto_PI__REALCRED
{
    class Program
    {


        public static void Main(string[] args)
        {
            string? menuPrincipal, menuEmpresa, menuPessoa;
            do
            {
                Console.Clear();
                Console.WriteLine("--- [ BEM VINDO(A) À REALCRED ] ---");
                Console.WriteLine("     1. Nossa Empresa");
                Console.WriteLine("     2. Nossos Produtos");
                Console.WriteLine("     3. Cadastrar Cliente");
                Console.WriteLine("     4. Simular Empréstimo");
                Console.WriteLine("     *5. Sair \n");
                Console.Write("*Digite uma opçâo entre 1 - 5: ");
                menuPrincipal = Console.ReadLine();
                Console.WriteLine();
                switch (menuPrincipal)
                {
                    ///////////// MENU DE APRESENTAÇÃO DA EMPRESA
                    case "1":
                        Console.Clear();
                        Empresa REALCRED = new Empresa(); // criação do objeto REALCRED da classe EMPRESA
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("[ Menu: NOSSA EMPRESA ] \n");
                            Console.WriteLine("1. Quem somos?");
                            Console.WriteLine("2. Missâo");
                            Console.WriteLine("3. Visão");
                            Console.WriteLine("4. Valores");
                            Console.WriteLine("*5. Retornar \n");
                            Console.Write("*Digite uma opçâo entre 1 - 5: ");
                            menuEmpresa = Console.ReadLine();
                            if (menuEmpresa == "1")
                            {
                                Console.WriteLine("\n QUEM SOMOS: " + REALCRED.getQuemSomos() + "\n");
                                Console.WriteLine("Pressione qualquer tecla para continuar . . .");
                                Console.ReadLine();
                            }
                            else if (menuEmpresa == "2")
                            {
                                Console.WriteLine("\n NOSSA MISSÃO: " + REALCRED.getMissao() + "\n");
                                Console.WriteLine("Pressione qualquer tecla para continuar . . .");
                                Console.ReadLine();
                            }
                            else if (menuEmpresa == "3")
                            {
                                Console.WriteLine("\n NOSSA VISÃO: " + REALCRED.getVisao() + "\n");
                                Console.WriteLine("Pressione qualquer tecla para continuar . . .");
                                Console.ReadLine();
                            }
                            else if (menuEmpresa == "4")
                            {
                                Console.WriteLine("\n NOSSOS VALORES: " + REALCRED.getValores() + "\n");
                                Console.WriteLine("Pressione qualquer tecla para continuar . . .");
                                Console.ReadLine();
                            }
                        } while (menuEmpresa != "5");
                        break;

                    /////////////  MENU DE APRESENTAÇÃO DOS PRODUTOS
                    case "2":
                        Console.WriteLine("[ Menu: NOSSOS PRODUTOS ]");
                        Produto PROD1 = new Produto("Empréstimo Consignado", "Aposentados", 1.05);
                        Produto PROD2 = new Produto("Empréstimo com desconto em folha", "Servidores públicos", 1.3);
                        Produto PROD3 = new Produto("Empréstimo Consignado", "Aposentados", 1.8);

                        PROD1.imprimir();
                        PROD2.imprimir();
                        PROD3.imprimir();

                        Console.WriteLine("\n Pressione qualquer tecla para continuar . . .");
                        Console.ReadLine();

                        break;

                    /////////////  MENU DE APRESENTAÇÃO DE CADASTRO DE CLIENTES (PF X PJ)
                    case "3":

                        do
                        {
                            Console.Clear();
                            Console.WriteLine(" [Menu: CADASTRAR CLIENTE ]");
                            Console.WriteLine("1. Pessoa Físiva");
                            Console.WriteLine("2. Pessoa Juidica");
                            Console.WriteLine("*3. Retornar \n");
                            menuPessoa = Console.ReadLine();
                            if (menuPessoa == "1")
                            {

                                Console.WriteLine(" Digite o CPF do novo cliente: \n");
                                String? cpf = Console.ReadLine();
                                DadosCadastrais dc = new DadosCadastrais();
                                PessoaFisica pf = new PessoaFisica();

                                Console.WriteLine("Digite o nome do cliente: ");
                                menuPessoa = Console.ReadLine();

                                Console.WriteLine("Digite o CPF do cliente: ");

                                Console.WriteLine("Rua: ");
                                menuPessoa = Console.ReadLine();

                                Console.WriteLine("Número: ");
                                menuPessoa = Console.ReadLine();

                                Console.WriteLine("Bairro: ");
                                menuPessoa = Console.ReadLine();

                                Console.WriteLine("Cidade: ");
                                menuPessoa = Console.ReadLine();

                                Console.WriteLine("Estado: ");
                                menuPessoa = Console.ReadLine();





                                Console.WriteLine("Cliente cadastrado cm sucesso! Pressione ENTER para continuar");
                                Console.ReadLine();
                            }
                            else if (menuPessoa == "2")
                            {
                                // PessoaJuridica PJ = new PessoaJuridica();   
                            }
                        } while (menuPessoa != "3");
                        break;
                    /////////////  MENU DE SIMULAÇÃO DE EMPRÉSTIMO ()
                    case "4":


                        Console.Clear();
                        Console.WriteLine(" [Menu: SIMULAR EMPRÉSTIMO ]");
                        Console.Write("Digite o valor desejado: R$ ");
                        double valor = double.Parse(Console.ReadLine());

                        Console.Write("Digite a quatidade de parcelas: ");
                        double parcelas = double.Parse(Console.ReadLine());

                        Console.WriteLine("\nTipo do produto: [Empréstimo Consignado]");
                        Console.WriteLine("Taxa de juros mensal (por parcela)  0,5% a.m.");
                        Console.WriteLine("Valor Solicitado: R$ " + Math.Round(valor, 2));
                        Console.WriteLine("Valor TOTAL do emprestimo: R$ " + Math.Round(valor * 1.05,2));
                        Console.WriteLine("Valor das "+parcelas+" parcelas: R$ " + Math.Round((valor * 1.05) / parcelas),2);

                        Console.WriteLine("\nTipo do produto: [Empréstimo com desconto em folha]");
                        Console.WriteLine("Taxa de juros mensal (por parcela)  1,3% a.m.");
                        Console.WriteLine("Valor Solicitado: R$ " + Math.Round(valor), 2);
                        Console.WriteLine("Valor TOTAL do emprestimo: R$ " + Math.Round(valor * 1.3), 2);
                        Console.WriteLine("Valor das "+parcelas+" parcelas: R$ " + Math.Round((valor * 1.3) / parcelas), 2);


                        Console.WriteLine("\nTipo do produto: [Empréstimo Consignado]");
                        Console.WriteLine("Taxa de juros mensal (por parcela)  1,8% a.m.");
                        Console.WriteLine("Valor Solicitado: R$ " + Math.Round(valor), 2);
                        Console.WriteLine("Valor TOTAL do emprestimo: R$ " + Math.Round(valor * 1.8, 2));
                        Console.WriteLine("Valor das "+parcelas+" parcelas: R$ " + Math.Round((valor * 1.8) / parcelas), 2);

                        Console.WriteLine("\n Pressione qualquer tecla para continuar . . .");
                        Console.ReadLine();



                        break;

                    ///////////// SAÍDA DO PROGRAMA
                    case "5":
                        Console.WriteLine("Até logo!!! \n\n A Realcred agradece a sua visita! \n");
                        break;
                }
            } while (menuPrincipal != "5");
        }
    }
}