using System;
namespace _05.Football_Team_Generator
{
    class Player
    {
        private string name;
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;

        private const int MinRange = 0;
        private const int MaxRange = 100;

        // constructor
        public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            this.Name = name;
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                this.name = value;
            }
        }
        
        public int Endurance
        {
            get { return this.endurance; }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException($"Endurance should be between {MinRange} and {MaxRange}.");
                }
                this.endurance = value;
            }
        }

        public int Sprint
        {
            get { return this.sprint; }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException($"Sprint should be between {MinRange} and {MaxRange}.");
                }
                this.sprint = value;
            }
        }

        public int Dribble
        {
            get { return this.dribble; }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException($"Dribble should be between {MinRange} and {MaxRange}.");
                }
                this.dribble = value;
            }
        }

        public int Passing
        {
            get { return this.passing; }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException($"Passing should be between {MinRange} and {MaxRange}.");
                }
                this.passing = value;
            }
        }

        public int Shooting
        {
            get { return this.shooting; }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException($"Shooting should be between {MinRange} and {MaxRange}.");
                }
                this.shooting = value;
            }
        }

        public int Skill()
        {
            return (int)Math.Round((this.passing + this.shooting + this.sprint + this.dribble + this.endurance) / 5.0);
        }


    }
}