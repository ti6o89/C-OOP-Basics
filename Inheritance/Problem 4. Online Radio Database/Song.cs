using Problem_4.Online_Radio_Database.Exceptions;

public class Song
{
    private const int ArtistNameMinLength = 3;
    private const int ArtistNameMaxLength = 20;
    private const int SongNameMinLength = 3;
    private const int SongNameMaxLength = 30;
    private const int MinMinutes = 0;
    private const int MaxMinutes = 14;
    private const int MinSeconds = 0;
    private const int MaxSeconds = 59;

    private string artostName;
    private string songName;
    private int songMinutes;
    private int songSeconds;

    public Song(string artistName, string songName, int songMinutes, int songSecunds)
    {
        this.ArtistName = artistName;
        this.SongName = songName;
        this.SongMinutes = songMinutes;
        this.SongSeconds = songSecunds;
    }

    private string ArtistName
    {
        set
        {
            if (value.Length < ArtistNameMinLength || ArtistNameMaxLength < value.Length)
            {
                throw new InvalidArtistNameException(ArtistNameMinLength, ArtistNameMinLength);
            }
            this.artostName = value;
        }
    }

    private string SongName
    {
        set
        {
            if (value.Length < SongNameMinLength || SongNameMaxLength < value.Length)
            {
                throw new InvalidSongNameException(SongNameMinLength, SongNameMaxLength);
            }
            this.songName = value;
        }
    }

    public int SongMinutes
    {
        get { return this.songMinutes; }
        set
        {
            if (value < MinMinutes || MaxMinutes < value)
            {
                throw new InvalidSongMinutesException(MinMinutes, MaxMinutes);
            }
            this.songMinutes = value;
        }
    }

    public int SongSeconds
    {
        get { return this.songSeconds; }
        set
        {
            if (value < MinSeconds || MaxSeconds < value)
            {
                throw new InvalidSongSecondsException(MinSeconds, MaxSeconds);
            }
            this.songSeconds = value;
        }
    }
}
