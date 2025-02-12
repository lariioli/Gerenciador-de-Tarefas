
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
            string espacos = new string(' ', (largura - titulo.Length) / 2);

            Console.WriteLine("╔" + borda + "╗");
            Console.WriteLine("║" + espacos + titulo + espacos + (largura % 2 == 0 ? "" : " ") + "║");
            Console.WriteLine("╚" + borda + "╝");

        }
    }
}