﻿using System;
using System.Text;
namespace _02.Book_Shop
{
    public class Book
    {
        private string title;
        private string author;
        private decimal price;

        public Book(string author, string title, decimal price)
        {
            this.SetAuthor(author);
            this.SetTitle(title);
            this.SetPrice(price);
        }

        public virtual string Title
        {
            get
            {
                return this.title;
            }

            protected set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Title not valid!");
                }
                this.title = value;
            }
        }

        public virtual string Author
        {
            get { return this.author; }

            protected set
            {
                string[] names = value.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (names.Length > 1)
                {
                    if (char.IsDigit(names[1][0]))
                    {
                        throw new ArgumentException("Author not valid!");
                    }
                }
                this.author = value;
            }
        }

        public virtual decimal Price
        {
            get { return this.price; }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price not valid!");
                }
                this.price = value;
            }
        }

        private void SetAuthor(string author)
        {
            this.Author = author;
        }

        private void SetTitle(string title)
        {
            this.Title = title;
        }

        private void SetPrice(decimal price)
        {
            this.Price = price;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("Type: ").Append(this.GetType().Name)
                .Append(Environment.NewLine)
                .Append("Title: ").Append(this.Title)
                .Append(Environment.NewLine)
                .Append("Author: ").Append(this.Author)
                .Append(Environment.NewLine)
                .Append($"Price: {this.Price:F1}")
                .Append(Environment.NewLine);

            return sb.ToString();
        }


    }
}