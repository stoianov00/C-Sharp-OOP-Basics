using System;
using System.Collections.Generic;
using System.Linq;
namespace _05.Football_Team_Generator
{
    class Team
    {
        private string name;
        private List<Player> players;

        // constructor
        public Team(string name)
        {
            this.Name = name;
            this.players = new List<Player>();
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

        public int Rating()
        {
            if (this.players.Count == 0)
            {
                return 0;
            }
            return (int)Math.Round(this.players.Select(p => p.Skill()).Sum() / (double)this.players.Count);
        }

        public void AddPlayer(Player player)
        {
            this.players.Add(player);
        }

        public void RemovePlayer(string playerName)
        {
            bool containsPlayer = this.players.Any(p => p.Name == playerName);
            if (!containsPlayer)
            {
                throw new ArgumentException($"Player {playerName} is not in {this.Name} team.");
            }
            var player = this.players.First(p => p.Name == playerName);
            this.players.Remove(player);
        }




    }
}