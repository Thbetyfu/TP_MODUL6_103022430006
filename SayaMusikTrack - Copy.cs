using System;

namespace TP_MODUL6_103022430006
{
    public class SayaMusicTrack
    {
        private int id;
        private int playCount;
        private string title;

        public SayaMusicTrack(string title)
        {
            this.title = title;
            Random random = new Random();
            this.id = random.Next(10000, 100000);
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            this.playCount += count;
        }
        public void PrintTrackDetails()
        {
            Console.WriteLine("Detail Lagu:");
            Console.WriteLine($"ID         : {this.id}");
            Console.WriteLine($"Judul      : {this.title}");
            Console.WriteLine($"Play Count : {this.playCount}");
            Console.WriteLine("---------------------------");
        }
    }
}