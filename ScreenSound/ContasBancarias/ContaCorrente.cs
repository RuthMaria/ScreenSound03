
namespace ScreenSound.ContasBancarias;

internal class ContaCorrente: ContasBancarias
{
    private double TaxaManutencao { get; set; }

    public override void Sacar(double valor)
    {
        base.Sacar(valor + TaxaManutencao);
    }
}
