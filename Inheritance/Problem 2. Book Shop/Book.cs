using System;
using System.Text;

public class Book
{
    private const int MinTitleLength = 3;
    private const decimal MinPrice = 1;

    private string title;
    private string author;
    private decimal price;

    public Book(string author, string title, decimal price)
    {
        this.Author = author;
        this.Title = title;
        this.Price = price;
    }

    public string Author
    {
        get { return this.author; }
        set
        {
            var nameInfo = value.Split(new char[] { ' '}, StringSplitOptions.RemoveEmptyEntries);
            if (nameInfo.Length >= 2)
            {
                var secondName = nameInfo[1];
                if (char.IsDigit(secondName[0]))
                {
                    throw new ArgumentException("Author not valid!");
                }
            }
            this.author = value;
        }
    }

    public string Title
    {
        get { return this.title; }
        set
        {
            if (value.Length < MinTitleLength)
            {
                throw new ArgumentException("Title not valid!");
            }

            this.title = value;
        }
    }

    public virtual decimal Price
    {
        get { return this.price; }
        set
        {
            if (value < MinPrice)
            {
                throw new ArgumentException("Price not valid!");
            }

            this.price = value;
        }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("Type: ").AppendLine(this.GetType().Name)
            .Append("Title: ").AppendLine(this.Title)
            .Append("Author: ").AppendLine(this.Author)
            .Append("Price: ").Append($"{this.Price:f1}")
            .AppendLine();

        return sb.ToString();
    }

}
