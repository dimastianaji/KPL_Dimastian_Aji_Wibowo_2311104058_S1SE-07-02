using System;
using tpmodul2_2311104058;

class Program
{
    static void Main()
    {
        HurufChecker hurufChecker = new HurufChecker();
        AngkaGenapPrinter angkaGenapPrinter = new AngkaGenapPrinter();

        hurufChecker.CekHuruf();
        angkaGenapPrinter.CetakAngkaGenap();
    }
}


