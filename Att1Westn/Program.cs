using Att1Westn;

internal class Program
{
    private static void Main(string[] args)
    {
        Pessoa pessoa1 = new Pessoa();
        Evento evento1 = new Evento();

        List<Pessoa> listaPessoas = new List<Pessoa>();
        List<Evento> listaEventos = new List<Evento>();

        int condicao = 0;
        int condicaodo = 10;
        string eventopago;

        do{

            Console.Write("\nMENU:\n");
            System.Console.WriteLine("1 - CADASTRAR EVENTO\n2 - CADASTRAR PESSOAS\n3 - VISUALIZAR PESSOAS\n4 - VISUALIZAR EVENTOS\n0 - SAIR DO PROGRAMA");
            condicao = Int32.Parse(Console.ReadLine());

            switch (condicao){

                case 0:
                    condicaodo = 5;
                break;
                case 1:
                    Console.WriteLine("\nNome do evento:");
                    evento1.NomeEvento = Console.ReadLine();
                    Console.WriteLine("Endereço do evento:");
                    evento1.EnderecoEvento = Console.ReadLine();
                    Console.WriteLine("O evento será pago? sim ou não");
                    eventopago = Console.ReadLine();

                    if (eventopago == "sim"){
                        System.Console.WriteLine("\nInsira o valor do evento:");
                        evento1.ValorEvento = Int32.Parse(Console.ReadLine());
                    }
                    else{
                        evento1.ValorEvento = 0;
                    }

                    listaEventos.Add(evento1);

                    System.Console.WriteLine("Voltar ao Menu: 10");
                    condicaodo = Int32.Parse(Console.ReadLine());
                break;

                case 2:

                if (listaPessoas.Count > 20){
                    System.Console.WriteLine("MUITAS PESSOAAAAAAS");
                    System.Console.WriteLine("\nVoltar ao Menu: 10");
                    condicaodo = Int32.Parse(Console.ReadLine());
                } else {

                Console.WriteLine("\nNome da pessoa:");
                pessoa1.Nome = Console.ReadLine();
                Console.WriteLine("Endereço:");
                pessoa1.Endereco = Console.ReadLine();
                Console.WriteLine("Idade:");
                pessoa1.Idade = Int32.Parse(Console.ReadLine());
                listaPessoas.Add(pessoa1);

                }
                
                System.Console.WriteLine("\nVoltar ao Menu: 10");
                condicaodo = Int32.Parse(Console.ReadLine());
                break;
                case 3:
                    foreach (Pessoa pessoa in listaPessoas){
                        Console.Write("\n"+"Nome: ");
                        Console.Write(pessoa.Nome);
                        Console.Write("\n"+"Endereço: ");
                        Console.Write(pessoa.Endereco);
                        Console.Write("\n"+"Idade: ");
                        Console.Write(pessoa.Idade);
                        Console.Write("\n");
                    }
                    System.Console.WriteLine("\nVoltar ao Menu: 10");
                    condicaodo = Int32.Parse(Console.ReadLine());
                break;
                case 4:
                    foreach (Evento evento in listaEventos){
                        Console.Write("\n"+"Nome do Evento: ");
                        Console.Write(evento.NomeEvento);
                        Console.Write("\n"+"Endereço do Evento: ");
                        Console.Write(evento.EnderecoEvento);
                        Console.Write("\n"+"Valor do Evento: ");
                        Console.Write(evento.ValorEvento);
                        Console.Write("\n");
                    }

                    System.Console.WriteLine("\nVoltar ao Menu: 10");
                    condicaodo = Int32.Parse(Console.ReadLine());
                break;
            }

        }while(condicaodo == 10);
            
            System.Console.WriteLine("\nProgama encerrado com sucesso!");
  
    }
}


