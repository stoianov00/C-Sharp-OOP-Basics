﻿using System;
namespace _04.Pizza_Calories
{
    class Dough
    {
        private string flourType;
        private string bakingTechnique;
        private double weight;

        private const int MinWeight = 1;
        private const int MaxWeight = 200;

        public Dough(string flourType, string bakingTechnique, double weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
        }

        public string FlourType
        {
            get { return this.flourType; }
            set
            {
                if (value.ToLower() != "white" && value.ToLower() != "wholegrain")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.flourType = value;
            }
        }

        public string BakingTechnique
        {
            get { return this.bakingTechnique; }
            set
            {
                if (value.ToLower() != "crispy" && value.ToLower() != "chewy" && value.ToLower() != "homemade")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.bakingTechnique = value;
            }
        }

        public double Weight
        {
            get { return this.weight; }
            set
            {
                if (value < MinWeight || value > MaxWeight)
                {
                    throw new ArgumentException($"Dough weight should be in the range [{MinWeight}..{MaxWeight}].");
                }
                this.weight = value;
            }
        }


        public double GetCalories()
        {
            return 2 * this.Weight * this.GetTechMode() * this.GetTypeMode();
        }

        private double GetTypeMode()
        {
            if (this.FlourType.ToLower() == "white")
            {
                return 1.5;
            }
            return 1;
        }

        private double GetTechMode()
        {
            if (this.BakingTechnique.ToLower() == "crispy")
            {
                return 0.9;
            }
            else if (this.BakingTechnique.ToLower() == "chewy")
            {
                return 1.1;
            }
            return 1;
        }

    }
}