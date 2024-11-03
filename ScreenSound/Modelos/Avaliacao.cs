
namespace ScreenSound.Modelos;

// internal é  usado para a visibilidade de uma classe.
// quando declaramos uma classe como internal (interna), ela será vista apenas pelo projeto.
internal class Avaliacao
{
    public Avaliacao(int nota)
    {
        Nota = nota;

        if (Nota <= 0)
        {
            Nota = 0;
        }
        else if (Nota >= 10)
        {
            Nota = 10;
        }

    }

    public int Nota { get; }

    // métodos estáticos podem ser chamados sem precisar criar um objeto da classe, são chamados através do nome da classe, Ex.: Avaliacao.Parse("12")
    public static Avaliacao Parse(string texto) {
        int nota = int.Parse(texto);

        return new Avaliacao(nota);
    }
}
