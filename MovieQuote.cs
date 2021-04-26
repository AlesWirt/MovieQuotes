using System;
using static System.Console;

namespace MovieQuote
{
    public class MovieQuote
    {
        private string QuoteText;
        private string Movie;
        private int Year;
        private double Imdb;
        private int RottenTomatos;
        public MovieQuote(string quote, string movie, int year)
        {
            QuoteText = quote;
            Movie = movie;
            Year = year;
        }
        public MovieQuote(string quote, string movie, int year, double imdb, int rotTom)
        {
            QuoteText = quote;
            Movie = movie;
            Year = year;
            Imdb = imdb;
            RottenTomatos = rotTom;
        }
        public void Display()
        {
            WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            WriteLine($"\n\"{QuoteText}\"");
            WriteLine($"\t- {Movie} ({Year})\n");
            WriteLine($"\nIMDB: {Imdb}/10");
            WriteLine($"RottenTomatos: {RottenTomatos}%\n");
            WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }
        
    }
}
