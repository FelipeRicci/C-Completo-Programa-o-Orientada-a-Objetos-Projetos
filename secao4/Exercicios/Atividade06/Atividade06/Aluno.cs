using System.Globalization;

namespace Ativiade06
{
    class Aluno
    {
        public string nome;
        public double nota1;
        public double nota2;
        public double nota3;

        public double media()
        {
            double mediaFinal = nota1 + nota2 + nota3;
            if (mediaFinal >= 60)
            {
                Console.WriteLine($"NOTA FINAL = {mediaFinal.ToString("F2", CultureInfo.InvariantCulture)}\n" +
                                  $"APROVADO");
            } else
            {
                double diferenca = 60 - mediaFinal;
                Console.WriteLine($"NOTA FINAL = {mediaFinal.ToString("F2", CultureInfo.InvariantCulture)}\n" +
                                  $"REPROVADO\n" +
                                  $"FALTARAM {diferenca.ToString("F2", CultureInfo.InvariantCulture)} PONTOS");
            }

            return double.Parse(mediaFinal.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}