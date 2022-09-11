using Att3Westn;

Dono dono1 = new Dono("Júlio","RJ",32);
Dono dono2 = new Dono("Lola","SP",22);

cachorro cachorro1 = new cachorro(15,"Não","Leleco","Viralata","Médio");
dono1.listaCachorro.Add(cachorro1);

gato gato1 = new gato(12,"Sim","Mia","Desconhecida");
dono2.listaGato.Add(gato1);

 System.Console.WriteLine("Dono 1:");
 System.Console.WriteLine(dono1.ToString());
 System.Console.WriteLine("\nSeu pet:");
 System.Console.WriteLine(cachorro1.ToString());

  System.Console.WriteLine("\nDono 2:\n");
 System.Console.WriteLine(dono2.ToString());
 System.Console.WriteLine("\nSeu pet:");
 System.Console.WriteLine(gato1.ToString());


 System.Console.WriteLine("\nLista de cachorros cadastrados: ");
 foreach (var item in dono1.listaCachorro)
 {
    System.Console.WriteLine(item.ToString());
 }

System.Console.WriteLine("\nLista de gatos cadastrados: ");
foreach (var itemgato in dono2.listaGato)
 {
    System.Console.WriteLine(itemgato.ToString());
 }


