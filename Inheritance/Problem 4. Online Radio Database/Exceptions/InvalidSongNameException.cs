namespace Problem_4.Online_Radio_Database.Exceptions
{
    public class InvalidSongNameException : InvalidSongException
    {
        public InvalidSongNameException()
            : base()
        {
        }

        public InvalidSongNameException(string message)
            : base(message)
        {
        }

        public InvalidSongNameException(int minSongLength, int maxSongLength)
            : base($"ong name should be between {minSongLength} and {maxSongLength} symbols.")
        {
        }
    }
}
