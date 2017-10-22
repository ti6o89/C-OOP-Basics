﻿namespace Problem_4.Online_Radio_Database.Exceptions
{
    public class InvalidArtistNameException : InvalidSongException
    {
        public InvalidArtistNameException()
            : base()
        {
        }

        public InvalidArtistNameException(string message)
            : base(message)       
        {
        }

        public InvalidArtistNameException(int nameMingLength, int nameMaxLength)
            : base($"Artist name should be between {nameMingLength} and {nameMaxLength} symbols.")
        {
        }
    }
}
