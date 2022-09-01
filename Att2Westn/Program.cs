using Att2Westn;

internal class Program
{
    private static void Main(string[] args)
    {
        Aluno aluno1 = new Aluno();
        Professor professor1 = new Professor();
        Avaliacao av1 = new Avaliacao();
        Disciplina disciplina1 = new Disciplina();

        List<Aluno> listaAlunos = new List<Aluno>();
        List<Professor> listaProfessors = new List<Professor>();
        List<Avaliacao> listaAvaliacao = new List<Avaliacao>();
        List<Disciplina> listaDisciplinas = new List<Disciplina>();

        int escolha = 0;
        int serieAluno = 0;
        int condicao = 0;

do{
    System.Console.WriteLine("1 - Cadastrar aluno\n2 - Cadastrar professor\n3 - Cadastrar disciplina\n4 - Cadastrar avaliação");
        escolha = Int32.Parse(Console.ReadLine());

        switch (escolha){
            case 1:
                System.Console.WriteLine("Insira o nome do Aluno:");
                aluno1.Nome = Console.ReadLine();
                System.Console.WriteLine("Insira a série do Aluno:");
                aluno1.Serie = Int32.Parse(Console.ReadLine());
                System.Console.WriteLine("Insira a matricula do Aluno:");
                aluno1.Matricula = Int32.Parse(Console.ReadLine());

                listaAlunos.Add(aluno1);

                System.Console.WriteLine("\n Aluno cadastrado com sucesso: \n");
                foreach (Aluno aluno in listaAlunos)
                {
                    System.Console.WriteLine("Nome Aluno:");
                    System.Console.WriteLine(aluno1.Nome);
                    System.Console.WriteLine("Série Aluno:");
                    System.Console.WriteLine(aluno1.Serie);
                    System.Console.WriteLine("Matrícula Aluno:");
                    System.Console.WriteLine(aluno1.Matricula);
                }
                    System.Console.WriteLine("\n");
                    System.Console.WriteLine("MENU - 1 // SAIR - 0");
                    condicao = Int32.Parse(Console.ReadLine());
            break;
            case 2:
                System.Console.WriteLine("Insira o nome do Professor:");
                professor1.Nome = Console.ReadLine();
                System.Console.WriteLine("Insira o título do Professor:");
                professor1.Titulo = Console.ReadLine();

                listaProfessors.Add(professor1);

                System.Console.WriteLine("\n Professor cadastrado com sucesso: \n");
                foreach (Professor professor in listaProfessors)
                {
                    System.Console.WriteLine("Nome Professor:");
                    System.Console.WriteLine(professor1.Nome);
                    System.Console.WriteLine("Título:");
                    System.Console.WriteLine(professor1.Titulo);
                }
                    System.Console.WriteLine("\n");
                    System.Console.WriteLine("MENU - 1 // SAIR - 0");
                    condicao = Int32.Parse(Console.ReadLine());
            break;
            case 3:
                System.Console.WriteLine("Insira o nome da Disciplina:");
                disciplina1.Nome = Console.ReadLine();
                System.Console.WriteLine("Insira a carga horária da Disciplina:");
                disciplina1.Carga = Int32.Parse(Console.ReadLine());

                listaDisciplinas.Add(disciplina1);

                System.Console.WriteLine("\n Disciplina cadastrada com sucesso: \n");
                foreach (Disciplina disciplina in listaDisciplinas)
                {
                    System.Console.WriteLine("Nome:");
                    System.Console.WriteLine(disciplina1.Nome);
                    System.Console.WriteLine("Carga horária:");
                    System.Console.WriteLine(disciplina1.Carga);
                }
                    System.Console.WriteLine("\n");
                
                System.Console.WriteLine("MENU - 1 // SAIR - 0");
                condicao = Int32.Parse(Console.ReadLine());
            break;
            case 4:
                System.Console.WriteLine("Insira o nome da Avaliacao:");
                av1.NomeAvaliacao = Console.ReadLine();
                System.Console.WriteLine("Insira a série da Avaliação:");
                av1.Serie = Int32.Parse(Console.ReadLine());
                System.Console.WriteLine("Insira a nota da Avaliação:");
                av1.Nota = Int32.Parse(Console.ReadLine());
                System.Console.WriteLine("Insira a disciplina da Avaliação:");
                av1.DisciplinaAv = Console.ReadLine();
                System.Console.WriteLine("Insira o nome do aluno desta Avaliação:");
                av1.NomeAluno = Console.ReadLine();
                System.Console.WriteLine("Insira a série do aluno:");
                serieAluno = Int32.Parse(Console.ReadLine());
                System.Console.WriteLine("Insira o nome do professor desta Avaliação:");
                av1.NomeProfessor = Console.ReadLine();

                if (serieAluno == av1.Serie){
                    listaAvaliacao.Add(av1);
                    System.Console.WriteLine("\n Avaliação cadastrada com sucesso: \n");
                    foreach (Avaliacao avaliacao in listaAvaliacao)
                    {
                        System.Console.WriteLine("Nome Avaliação:");
                        System.Console.WriteLine(av1.NomeAvaliacao);
                        System.Console.WriteLine("Série Avaliação:");
                        System.Console.WriteLine(av1.Serie);
                        System.Console.WriteLine("Nota Avaliação:");
                        System.Console.WriteLine(av1.Nota);
                        System.Console.WriteLine("Disciplina Avaliação:");
                        System.Console.WriteLine(av1.DisciplinaAv);
                        System.Console.WriteLine("Nome do aluno:");
                        System.Console.WriteLine(av1.NomeAluno);
                        System.Console.WriteLine("Nome do professor:");
                        System.Console.WriteLine(av1.NomeProfessor);
                    }
                        System.Console.WriteLine("\n");
                }
                else {
                    System.Console.WriteLine("A série do aluno não corresponde com a série da avaliação.");
                    condicao = 0;
                }
            System.Console.WriteLine("MENU - 1 // SAIR - 0");
            condicao = Int32.Parse(Console.ReadLine());
            break;
        }
}while(condicao == 1);
        
        System.Console.WriteLine("Até breve!");
        
    }
}