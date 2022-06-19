using System.Globalization;

namespace Atividade04
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return 2 * (Largura + Altura);
        }

        public double Diagonal()
        {
            return ((Largura + Largura) + Altura) / 2;
        }

        public override string ToString()
        {
            return $"Area = {Area().ToString("F2", CultureInfo.InvariantCulture)}\n" +
                   $"Perímetro = {Perimetro().ToString("F2", CultureInfo.InvariantCulture)}\n" +
                   $"Diagonal = {Diagonal().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
