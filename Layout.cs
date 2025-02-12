
namespace Layout
{
    class Formatacao
    {
        public static void Cor(string mensagem, ConsoleColor cor)
        {
            Console.ForegroundColor = cor;
            Console.Write(mensagem);
            Console.ResetColor();
        }
        public static void ImprimirCabecalho()
        {

            string titulo = "GERENCIADOR DE TAREFAS";
            int largura = 40;
            string borda = new string('=', largura);
            int posicaoInicial = (Console.WindowWidth - largura - 2) / 2;


            string linhaBorda = new string(' ', posicaoInicial) + "╔" + borda + "╗";
            string linhaTitulo = new string(' ', posicaoInicial) + "║" + titulo.PadLeft((largura + titulo.Length) / 2).PadRight(largura) + "║";
            string linhaInferior = new string(' ', posicaoInicial) + "╚" + borda + "╝";

            Console.WriteLine(linhaBorda);
            Console.WriteLine(linhaTitulo);
            Console.WriteLine(linhaInferior);

        }
    }
}