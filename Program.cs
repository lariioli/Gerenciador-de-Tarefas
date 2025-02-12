using Layout;
using GerenciarTarefa;
using Tarefas;

class Program
{
    static void Main()
    {

        Gerenciador gerenciador = new Gerenciador();

        while (true)
        {
            Console.Clear();

            gerenciador.ListarTarefas();

            Formatacao.ImprimirCabecalho();
            Formatacao.Cor("\n1 - Adicionar Tarefa\n", ConsoleColor.White);
            Formatacao.Cor("2 - Listar Tarefas\n", ConsoleColor.White);
            Formatacao.Cor("3 - Concluir Tarefa\n", ConsoleColor.White);
            Formatacao.Cor("4 - Remover Tarefa\n", ConsoleColor.White);
            Formatacao.Cor("0 - Sair\n", ConsoleColor.White);
            Formatacao.Cor("\nEscolha uma opção:\n", ConsoleColor.White);

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Clear();
                    Formatacao.Cor("\nDigite a descrição da Tarefa: ", ConsoleColor.White);
                    string descricao = Console.ReadLine();
                    gerenciador.AdicionarTarefa(descricao);
                    break;

                case "2":
                    gerenciador.ListarTarefas();
                    break;

                case "3":
                    Console.Clear();
                    gerenciador.ListarTarefas();
                    Formatacao.Cor("\nDigite o Id da Tarefa que deseja concluir:\n", ConsoleColor.White);
                    if (int.TryParse(Console.ReadLine(), out int idConcluir))
                        gerenciador.ConcluirTarefa(idConcluir);
                    else
                        Formatacao.Cor("ID inválido!\n", ConsoleColor.Red);
                    break;

                case "4":
                    Console.Clear();
                    gerenciador.ListarTarefas();
                    Formatacao.Cor("\nDigite o ID da Tarefa a remover:\n", ConsoleColor.White);
                    if (int.TryParse(Console.ReadLine(), out int idRemover))
                        gerenciador.RemoverTarefa(idRemover);
                    else
                        Formatacao.Cor("ID inválido!\n", ConsoleColor.Red);
                    break;

                case "0":
                    Formatacao.Cor("\nSaindo...\n", ConsoleColor.Red);
                    return;

                default:

                    Formatacao.Cor("\nOpção inválida, tente novamente.\n", ConsoleColor.Red);
                    break;
            }
            Formatacao.Cor("\nPressione Enter para continuar...", ConsoleColor.White);
            Console.ReadLine();
        }
    }
}
