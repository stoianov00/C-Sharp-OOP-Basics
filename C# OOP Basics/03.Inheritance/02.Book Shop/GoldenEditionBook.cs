﻿namespace _02.Book_Shop
{
    public class GoldenEditionBook : Book
    {
        public GoldenEditionBook(string title, string author, decimal price)
            : base(title, author, price)
        {

        }

        public override decimal Price
        {
            get { return base.Price * 1.3m; }
        }


    }
}
