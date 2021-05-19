using System;

namespace CelularPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            bool verificando;
            string mensagem;
            Celular iphone = new Celular();
            iphone.corCelular = "Prata";
            iphone.modeloCelular = "Iphone 7";
            iphone.tamanhoCelular = 4.7;

            Console.WriteLine("O celular se encontra desligado, deseja liga-lo? y/n");
            string condicao = Console.ReadLine().ToLower();
            bool tratando = condicao == "y" ? iphone.ligar() : iphone.desligar();

            do
            {
                if (iphone.estadoCelular == true ){
                    Console.WriteLine(iphone.menu(iphone.modeloCelular));
                    Console.Write("Escolha uma das opções: ");
                    int opcao = int.Parse(Console.ReadLine());

                    switch (opcao)
                    {
                        case 1:
                            Console.Write(" Digite para quem deseja ligar: ");
                            string pessoa = Console.ReadLine();

                            Console.WriteLine(iphone.fazerLigacao(pessoa));
                            break;
                            
                        case 2:
                            Console.Write(" Digite para quem deseja mandar mensagem: ");
                            string pessoa2 = Console.ReadLine();

                            do
                            {
                                Console.Write(" Digite sua mensagem: ");
                                mensagem = Console.ReadLine();
                                int tamanho = mensagem.Length;

                                if (tamanho <= 20){
                                    verificando = true;
                                }
                                else
                                {
                                    Console.WriteLine("Mensagem invalida, o limite de caracter eh 20, mais que isso manda por carta");
                                    verificando = false;
                                }
                                
                            } while (verificando == false);

                            Console.WriteLine(iphone.enviarMensagem(mensagem, pessoa2));

                            break;
                        
                        case 3:
                            iphone.desligar();
                            break;

                        default:
                        Console.WriteLine("Opção invalida!!!");
                            break;
                    }
                    
                }
                else{}
                Console.ReadLine();
            } while (iphone.estadoCelular == true);


        }
    }
}
