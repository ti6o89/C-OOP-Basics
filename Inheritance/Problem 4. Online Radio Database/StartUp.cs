using Problem_4.Online_Radio_Database.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;;

namespace Problem_4.Online_Radio_Database
{
    class StartUp
    {
        static void Main()
        {
            var songNumber = int.Parse(Console.ReadLine());
            var songs = new List<Song>();

            for (int i = 0; i < songNumber; i++)
            {
                var songDetails = Console.ReadLine().Split(';');

                try
                {
                    var indexOfMinuteSecondSeparation = songDetails[2].IndexOf(':');

                    if (songDetails.Length < 3 || indexOfMinuteSecondSeparation < 1 ||
                        indexOfMinuteSecondSeparation > songDetails[2].Length - 2)
                    {
                        throw new InvalidSongException();
                    }

                    var artist = songDetails[0];
                    var songName = songDetails[1];
                    var songMinutes = int.Parse(songDetails[2].Substring(0, indexOfMinuteSecondSeparation));
                    var songSeconds = int.Parse(songDetails[2].Substring(indexOfMinuteSecondSeparation + 1));

                    songs.Add(new Song(artist, songName, songMinutes, songSeconds));
                    Console.WriteLine("Song added.");
                }
                catch (InvalidSongException ise)
                {
                    Console.WriteLine(ise.Message);
                }
                catch (FormatException fex)
                {
                    Console.WriteLine("Invalid song length.");
                }             
            }
            Console.WriteLine($"Songs added: {songs.Count}");

            var totalSeconds = songs.Select(s => s.SongSeconds).Sum();
            var secondsToMinutes = totalSeconds / 60;
            var seconds = totalSeconds % 60;

            var totalMinutes = songs.Select(s => s.SongMinutes).Sum() + secondsToMinutes;
            var minutesToHours = totalMinutes / 60;
            var minutes = totalMinutes % 60;

            var hours = minutesToHours;

            Console.WriteLine($"Playlist length: {hours}h {minutes}m {seconds}s");
        }
    }
}
