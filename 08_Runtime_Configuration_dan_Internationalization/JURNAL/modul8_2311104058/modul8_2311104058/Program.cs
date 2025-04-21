using modul8_2311104058;
using System;

class Program
{
    static void Main(string[] args)
    {
        BankTransferConfig config = new BankTransferConfig();
        string lang = config.lang;

        Console.WriteLine(lang == "en"
            ? "Please insert the amount of money to transfer:"
            : "Masukkan jumlah uang yang akan di-transfer:");
        int amount = int.Parse(Console.ReadLine());

        int fee = (amount <= config.transfer.threshold) ? config.transfer.low_fee : config.transfer.high_fee;
        int total = amount + fee;

        if (lang == "en")
        {
            Console.WriteLine($"Transfer fee = {fee}");
            Console.WriteLine($"Total amount = {total}");
        }
        else
        {
            Console.WriteLine($"Biaya transfer = {fee}");
            Console.WriteLine($"Total biaya = {total}");
        }

        Console.WriteLine(lang == "en" ? "Select transfer method:" : "Pilih metode transfer:");
        for (int i = 0; i < config.methods.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {config.methods[i]}");
        }

        int methodChoice = int.Parse(Console.ReadLine());

        string confirmWord = lang == "en" ? config.confirmation.en : config.confirmation.id;
        Console.WriteLine(lang == "en"
            ? $"Please type \"{confirmWord}\" to confirm the transaction:"
            : $"Ketik \"{confirmWord}\" untuk mengkonfirmasi transaksi:");
        string userInput = Console.ReadLine();

        if (userInput.Equals(confirmWord, StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine(lang == "en" ? "The transfer is completed" : "Proses transfer berhasil");
        }
        else
        {
            Console.WriteLine(lang == "en" ? "Transfer is cancelled" : "Transfer dibatalkan");
        }
    }
}