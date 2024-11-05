namespace ScreenSound.ContasBancarias;

internal class ContaPoupanca: ContasBancarias
{
    private double TaxaRendimento { get; set; }

    public override double CalcularSaldo()
    {
        return base.CalcularSaldo() * (1 + TaxaRendimento);
    }
}
