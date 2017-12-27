namespace _05.Mordor_s_Cruelty_Plan.Models
{
    public abstract class Mood
    {
        protected Mood(string moodName)
        {
            this.MoodName = moodName;
        }

        public string MoodName { get; set; }

        public override string ToString()
        {
            return this.MoodName;
        }
    }
}

