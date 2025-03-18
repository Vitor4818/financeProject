namespace financeProject
{
    public class Categoria
    {
        public string Nome { get; set; }
        public double Limite { get; set; }
        public double Saldo { get; private set; }

        public Categoria(string nome, double limite)
        {
            Nome = nome;
            Limite = limite;
            Saldo = 0;
        }

        public void AtualizarSaldo(double valor)
        {
            Saldo += valor;
        }
    }
}