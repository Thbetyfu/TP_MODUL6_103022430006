using System;
using TP_MODUL6_103022430006;

namespace TP_MODUL6_NIM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Test 1: Penambahan Normal ---");
            SayaMusicTrack laguNormal = new SayaMusicTrack("Ghost - Justin Bieber");
            laguNormal.IncreasePlayCount(5000000);
            laguNormal.PrintTrackDetails();

            //pengujian 2: Memicu Overflow
            Console.WriteLine("\n--- Test 2: Memicu Overflow ---");
            for (int i = 0; i < 220; i++)
            {
                laguNormal.IncreasePlayCount(10000000);
            }
            laguNormal.PrintTrackDetails();

            // PENGUJIAN 3: Memicu Precondition
            Console.WriteLine("\nProgram selesai. Tekan sembarang tombol untuk keluar...");
            Console.ReadKey();
        }
    }
}