
using System.Runtime.Intrinsics.X86;

namespace ScreenSound.FormasGeometricas;

/*Uma classe abstrata em é uma classe que não pode ser instanciada diretamente,
 * mas serve como modelo para outras classes que a herdam.
*/
abstract class FormaGeometrica
{
    public abstract double CalcularArea();
    public abstract double CalcularPerimetro();
}
