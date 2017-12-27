﻿using System;

namespace _03.Mankind
{
    class Human
    {
        private string firstName;
        private string lastName;

        //constructor
        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public virtual string FirstName
        {
            get { return this.firstName; }
            protected set
            {
                if (!char.IsUpper(value[0]))
                {
                    throw new ArgumentException("Expected upper case letter! Argument: firstName");
                }
                this.firstName = value;
            }
        }

        public virtual string LastName
        {
            get { return this.lastName; }
            protected set
            {
                if (!char.IsUpper(value[0]))
                {
                    throw new ArgumentException("Expected upper case letter! Argument: lastName");
                }
                this.lastName = value;
            }
        }


    }
}