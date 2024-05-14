using bytebank.Modelos.ADM.Funcionarios;
using bytebank_ATENDIMENTO.bytebank.Atendimento;
Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");
new ByteBankAtendimento().AtendimentoCliente();

public class estagiario : Funcionario
{
    public estagiario(double salario, string cpf) : base(salario, cpf)
    {
    }

    public override void AumentarSalario()
    {
        throw new NotImplementedException();
    }

    protected override double GetBonificacao()
    {
        throw new NotImplementedException();
    }
}

