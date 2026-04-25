namespace Conta_bancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var minhaConta = new ContaBancaria(100m);
            var menu = new MenuConta(minhaConta);
            menu.Exibir();
        }
    }
}
