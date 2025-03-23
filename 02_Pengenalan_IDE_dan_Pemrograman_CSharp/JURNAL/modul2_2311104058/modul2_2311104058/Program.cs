using modul2_2311104058;

class Program
{
    static void Main()
    {
        Salam salam = new Salam();
        salam.InputNama();
        salam.TampilkanSalam();

        ArrayProcessor arrayProcessor = new ArrayProcessor();
        arrayProcessor.PrintArray();

        PrimeChecker primeChecker = new PrimeChecker();
        primeChecker.CheckPrime();
    }
}
