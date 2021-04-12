using System;
using System.Windows.Forms;

namespace lyricsGetter {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {

            // Gets the content of the song and artists text box as array (split by new line)
            string[] songsAndArtists = songAndArtistTxt.Text.Split('\n');

            // Calls getLyrics method for each song
            foreach(string song in songsAndArtists) {
                Console.WriteLine("Getting lyrics for " + song);
                GetLyrics.getLyrics(song, directoryTxt.Text);
            }

        }
    }
}
