using System.Net;
using System.IO;
using System.Text.RegularExpressions;

namespace lyricsGetter {
    class GetLyrics {

        public static StreamWriter output;

        public static void getLyrics(string songsAndArtists, string directory) {
            
            // Gets the song and artist
            MatchCollection songNameMatch = Regex.Matches(songsAndArtists, ".* -");
            MatchCollection artistNameMatch = Regex.Matches(songsAndArtists, "- .*");
            
            string song = songNameMatch[0].ToString().Replace(" -", "");
            string artist = artistNameMatch[0].ToString().Replace("- ", "");

            // Gets the source code of the song's lyrics website
            string url = "https://www.azlyrics.com/lyrics/" + artist.Replace(" ", "").ToLower() + "/" + song.Replace(" ", "").ToLower() + ".html";
            url = url.Replace("\r", "");
            string sourceCode;

            System.Console.WriteLine(song);
            System.Console.WriteLine(artist);
            System.Console.WriteLine(url);

            HttpWebRequest request = (HttpWebRequest) WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse) request.GetResponse();

            StreamReader sr = new StreamReader(response.GetResponseStream());
            sourceCode = sr.ReadToEnd();

            // Gets the song from the page source
            MatchCollection match = Regex.Matches(sourceCode, @"Usage.*((\n.*<br>)*)\n.*\n.*");
            string lyrics = match[0].ToString().Replace("</div>", "").Replace("<br>", "").Replace("Usage of azlyrics.com content by any third-party lyrics provider is prohibited by our licensing agreement. Sorry about that. -->", "");

            saveLyrics(song, lyrics, directory);

        }

        public static void saveLyrics(string songName, string lyrics, string directory) {

            // Makes sure the directory ends in a backslash
            if(!directory.EndsWith("\\")) {
                directory = directory + '\\';
            }

            //Outputs the lyrics to a file with the same name as the song
            using (output = new StreamWriter(directory + songName + ".txt")) {
                output.WriteLine(lyrics);
            }

        }

    }
}
