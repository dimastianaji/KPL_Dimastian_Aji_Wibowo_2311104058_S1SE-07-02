using System;
using System.Text;

namespace MatematikaLibraries
{
    public class Matematika
    {
        public int FPB(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public int KPK(int a, int b)
        {
            return (a * b) / FPB(a, b);
        }

        public string Turunan(int[] koefisien)
        {
            StringBuilder hasil = new StringBuilder();
            int pangkat = koefisien.Length - 1;

            for (int i = 0; i < koefisien.Length - 1; i++)
            {
                int koef = koefisien[i];
                int pangkatBaru = pangkat - 1;

                if (koef == 0) continue;

                int koefTurunan = koef * pangkat;

                if (hasil.Length > 0 && koefTurunan > 0)
                    hasil.Append(" + ");

                if (koefTurunan < 0)
                    hasil.Append(" - ");

                hasil.Append(Math.Abs(koefTurunan));
                if (pangkatBaru > 0)
                {
                    hasil.Append("x");
                    if (pangkatBaru > 1)
                        hasil.Append(pangkatBaru);
                }

                pangkat--;
            }

            return hasil.ToString().Trim();
        }

        public string Integral(int[] koefisien)
        {
            StringBuilder hasil = new StringBuilder();
            int pangkat = koefisien.Length;

            for (int i = 0; i < koefisien.Length; i++)
            {
                int koef = koefisien[i];
                int pangkatBaru = pangkat - 1 + 1;

                double hasilKoef = (double)koef / pangkatBaru;

                if (hasil.Length > 0 && hasilKoef > 0)
                    hasil.Append(" + ");

                if (hasilKoef < 0)
                    hasil.Append(" - ");

                hasil.Append($"{Math.Abs(hasilKoef)}x");
                if (pangkatBaru > 1)
                    hasil.Append(pangkatBaru);

                pangkat--;
            }

            hasil.Append(" + C");
            return hasil.ToString();
        }
    }
}
