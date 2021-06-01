using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Program {
        //private List<Song> songs = new List<Song>();
        static void Main(string[] args) {


            var songs = new Song[] {
                new Song("A","あ",300),
                new Song("B", "い", 800),
                new Song("C", "う", 700),
            };
            PrintSongs(songs);
        }
        private static void PrintSongs(Song[] songs) {
            foreach (var song in songs) {
                Console.WriteLine(@"{0},{1},{2:m\:ss}",
                    song.Title,song.ArtistName,TimeSpan.FromSeconds(song.Length));
            }                       
        }
    }
}
