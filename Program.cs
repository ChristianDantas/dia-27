using System;

namespace dia_27
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] promo1=new string[2];
            string sim;
            int contador=0;
            int escolha;
            
            string[] Nome=new string[2];
            int[]preco=new int[2];
            
        Console.WriteLine("--------------------------------------------------------------------------------");
        Console.WriteLine("Olá, sou o computador que registra os preços e promoçoes do mercado 'Preço bom' ");
        Console.WriteLine("--------------------------------------------------------------------------------");
        do{
            Console.WriteLine("Este é o menu principal");
            Console.WriteLine("gostaria de:");
            Console.WriteLine("[1] Registrar produtos");
            Console.WriteLine("[2] Listar produtos");
            Console.WriteLine("[3] Ir para seu gerenciamento");
            Console.WriteLine("[0] sair");
            escolha =int.Parse(Console.ReadLine());
             switch(escolha){
                 case 1:
                 
                  do
                  {
                  if(contador<2){
                      Console.WriteLine($"Digite o nome do {contador+1}°");
                      Nome[contador]=Console.ReadLine();
                      
                      Console.WriteLine($"digite o preço do produto");
                      preco[contador]=int.Parse(Console.ReadLine());
                      
                       Console.WriteLine($"Este produto está em promoção?");
                       promo1[contador]=Console.ReadLine();
                     contador++;
                  }else{
                      Console.WriteLine("O limite de produtos foi excedido");
                      break;
                  }
                    Console.WriteLine("gostaria de continuar? s/n");
                    sim = Console.ReadLine();
                    }while (sim.ToUpper() =="S");
                  break;

                 case 2:
                    for (var i = 0; i < contador; i++)
                    {
                        Console.WriteLine("Nome: " + Nome[i]);
                        Console.WriteLine("Preço: " + preco[i]);
                        Console.WriteLine("Preço: " + promo[i]);
                    }
                 break;

                 case 3:
                  Console.WriteLine("Está pagina ainda está em desenvolvimento!");
                 break;

                default:
                    Console.WriteLine("Opcao invalida");
                break;
             }
        }while(escolha != 0);

        }
    }
}
