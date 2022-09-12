using ATT4WESTN;

Artigos artigo = new Artigos();
Autores autor = new Autores();

string titulo;
string palavra;
string instituicao;

System.Console.WriteLine("BEM VINDO!");
System.Console.WriteLine("Insira o título do artigo: ");
titulo = Console.ReadLine();
System.Console.WriteLine("Insira uma palavra chave para o artigo: ");
palavra = Console.ReadLine();
System.Console.WriteLine("Insira o nome da instituição: ");
instituicao = Console.ReadLine();

System.Console.WriteLine("CADASTRO DOS AUTORES");

System.Console.WriteLine("Insira o nome do autor: ");
autor.nomeautor = Console.ReadLine();

System.Console.WriteLine("Insira o e-mail do autor: ");
autor.email = Console.ReadLine();

artigo.Cadastrar_Artigo(autor,titulo,palavra,instituicao);

System.Console.WriteLine("Insira uma palavra chave cadastrada: ");
string palavrapesquisa = Console.ReadLine();

if (palavrapesquisa == artigo.palavrachaveart){
    artigo.Exibir_Artigos(artigo.palavrachaveart);
}

