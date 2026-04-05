using System;
using TP_MODUL6_103022430006;

namespace TP_MODUL6_103022430006
{
    class Program
    {
        static void Main(string[] args)
        {
            SayaMusicTrack laguThoriq = new SayaMusicTrack("GENJER-GENJER - Justin Bieber");
            laguThoriq.IncreasePlayCount(500);
            laguThoriq.PrintTrackDetails();

            Console.WriteLine("Tekan sembarang tombol untuk keluar...AHIHIHI");
            Console.ReadKey();
        }
    }
}