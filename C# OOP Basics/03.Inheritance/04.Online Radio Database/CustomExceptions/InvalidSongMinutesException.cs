namespace _04.Online_Radio_Database.CustomExceptions
{
    class InvalidSongMinutesException : InvalidSongLengthException
    {

        public InvalidSongMinutesException() : base()
        {

        }

        public InvalidSongMinutesException(string message) : base(message)
        {

        }

        public InvalidSongMinutesException(int minSongMinutes, int msxSongMinutes)
            : base($"Song minutes should be between {minSongMinutes} and {msxSongMinutes}.")
        {

        }
    }
}
