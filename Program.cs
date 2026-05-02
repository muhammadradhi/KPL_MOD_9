using System;
using static Program;
using System.Text.Json;
using System.Numerics;
using System.Net.Sockets;
using Modul9_103022400055;

internal class Program
{
    public static void Main(string[] args)
    {
        BankTransferConfig config = new BankTransferConfig();
        if (config.config.lang == "en")
        {
            Console.WriteLine("Please insert the amount of money to transfer:");
        } else if (config.config.lang == "id")
        {
            Console.WriteLine("Masukkan jumlah uang yang akan di transfer:");
        }

        double input2 = Convert.ToInt32(Console.ReadLine());
        double total;
    }
}