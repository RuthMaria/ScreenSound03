
namespace ScreenSound.ContasBancarias;

internal class ContasBancarias
{
    protected double Saldo { get; set; }
    
    // virtual para o método poder ser sobrescrito
    public virtual void Depositar(double valor)
    {
        Saldo += valor;
    }

    public virtual void Sacar(double valor)
    {
        Saldo -= valor;
    }

    public virtual double CalcularSaldo()
    {
        return Saldo;
    }
}
