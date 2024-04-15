namespace ContaCorrente.ConsoleApp;

public class ContaCorrente
{
    public Cliente titular = new Cliente();
    Movimentacao[] historico = new Movimentacao[10];

    public int numeroConta;
    public string tipoConta;

    public decimal saldo;
    public decimal limiteConta;


    public int contador;

    public void Saque(decimal valorSaque)
    {
        saldo -= valorSaque;
        Movimentacao novaMovimentacao = new Movimentacao();
        novaMovimentacao.tipo = "Debito";
        novaMovimentacao.valor = valorSaque;
        novaMovimentacao.horario = DateTime.Now.ToString();
        historico[contador] = novaMovimentacao;
        contador++;
    }

    public void Deposito(decimal valorDeposito)
    {
        saldo += valorDeposito;
        Movimentacao novaMovimentacao = new Movimentacao();
        novaMovimentacao.tipo = "Credito";
        novaMovimentacao.valor = valorDeposito;
        novaMovimentacao.horario = DateTime.Now.ToString();
        historico[contador] = novaMovimentacao;
        contador++;
    }

    public void VisualizarExtrato()
    {
        Console.WriteLine($"Tipo: {tipoConta}");
        Console.WriteLine($"Saldo: {saldo}");
        Console.WriteLine($"Limite disponivel: {limiteConta}");
        Console.WriteLine("\nHistorico de operacoes");

        for (int i = 0; i < historico.Length; i++)
        {
            if (historico[i] != null)
                Console.WriteLine(historico[i].valor + " , " + historico[i].tipo + " , " + historico[i].horario);

        }
    }

    public void Transferencia(decimal valorTransferencia, ContaCorrente ContaDestino)
    {
        this.saldo -= valorTransferencia;
        ContaDestino.saldo += valorTransferencia;

    }

}
