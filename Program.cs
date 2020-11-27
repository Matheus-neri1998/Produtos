using System;

namespace Produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            /* O sistema deverá ter as seguintes funções:

            - CadastrarProduto
            - ListarProdutos
            - MostrarMenu */

            // Declarações de variáveis
            string [] nome = new string[10];
            float [] preço = new float [10];
            string [] promocao;
            float [] preco;
            int contador = 0;
            // int login;
            // string loginadm;
            // string loginfun;
            string option;
            string resposta;
            bool senhaValida;
            bool Efetuarlogin;




                Console.Clear();
                Console.WriteLine("-------------------");
                Console.WriteLine("Sistema de Produtos");
                Console.WriteLine("-------------------");

                // Login
                do
                {
                    Console.WriteLine("Digite a senha para acesso ao sistema: ");
                    string password = (Console.ReadLine());
                    senhaValida = Efetuarlogin(password);

                }while (!senhaValida);

                 // Menu
                    do
                    {
                        
                        Console.WriteLine("Menu principal");
                        Console.WriteLine("Mostar opções: ");
                        Console.WriteLine("[1] - Cadastar produto");
                        Console.WriteLine("[2] - Listar produtos");
                        Console.WriteLine("[3] - Mostrar Menu");

                        switch (option)
                        { // Cadastar produtos
                        case 1:
                        Console.WriteLine("Cadastar produtos");
                        do
                        {
                           if (contador < 10)
                           {
                             Console.WriteLine($"Digite um {contador + 1} produtos");
                             nome[contador] = Console.ReadLine();  
                             Console.WriteLine($"Digite o preço de {contador + 1} produto");
                             preço [contador] = int.Parse (Console.ReadLine());
                             Console.WriteLine("Produto possui promoções? S/N");
                             resposta = Console.ReadLine();
                           }else
                           {
                            Console.WriteLine("Produto não cadastrado");
                            break;   
                           }
                       
                        } while (true);

                        break;

                        default: 

                        break;

                    }  // fim de switch

                    } while (true); // fim de menu (do-while)
                    
                
                } // fim de do-while

            // Declarar funções
            bool Promocoes(string promocao){
                if (promocao == "s")
                {
                    Console.WriteLine("Produto está em promoção");
                    return true;
                }else
                {
                    Console.WriteLine("Produto não está em promoção");
                    return false;
                }

            
            bool Efetuarlogin (string password){

                if (password == "1998"){
                return true;

                }else
                {
                    Console.WriteLine("Senha de acesso negada");
                    return false;
                }
            }
            }

        } // fim de Main
    }

