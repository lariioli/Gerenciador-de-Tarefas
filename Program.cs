using Layout;
using GerenciarTarefa;
using Tarefa;

class Program
{
    static void Main()
    {
        while (true)
        {
            Formatacao.ImprimirCabecalho();
            Formatacao.Cor("\n1 - Adicionar Tarefa", ConsoleColor.White);
            Formatacao.Cor("2 - Listar Tarefas", ConsoleColor.White);
            Formatacao.Cor("3 - Concluir Tarefa", ConsoleColor.White);
            Formatacao.Cor("4 - Remover Tarefa", ConsoleColor.White);
            Formatacao.Cor("0 - Sair", ConsoleColor.White);
            Formatacao.Cor("\nEscolha uma opção: ");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                Formatacao.Cor("\nDigite a descrição da Tarefa: ", ConsoleColor.White);
                string descricao = Console.ReadLine
                GerenciadorTarefas.AdicionarTarefa(descricao);
                break;

                case "2":
                Formatacao.Cor("\nTarefas: \n", ConsoleColor.White);
                GerenciadorTarefas.ListarTarefas();
                break;

                case "3":
                Formatacao.Cor("\nDigite o Id da Tarefa que deseja concluir: ", ConsoleColor.White);
                if (int.TryParse(Console.ReadLine(), out int idConcluir))
                GerenciadorTarefas.ConcluirTarefa(idConcluir);
                break;

                case "4":
                Formatacao.Cor("\nDigite o ID da Tarefa a remover: ", ConsoleColor.White);
                if (int.TryParse(Console.ReadLine(), out int idRemover))
                GerenciadorTarefas.RemoverTarefa(idRemover);
                break;

                case "0":
                Formatacao.Cor("\nSaindo...\n", ConsoleColor.Red);
                return;
                default:

                Formatacao.Cor("\nOpção inválida, tente novamente.\n", ConsoleColor.Red);
                break;
            }
            Formatacao.Cor("\nPressione Enter para continuar...", ConsoleColor.Green);
            Console.ReadLine();

        }
    }
}