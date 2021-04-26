using System;
using System.IO;
using System.Collections.Generic;
using static System.Console;

namespace MovieQuote
{
    public class MovieQuoteApp
    {
        private string QuotesFilePath = "MovieQuotesWithRatings.txt";
        private List<MovieQuote> movieQuotes = new List<MovieQuote>();

        public void Run()
        {
            Title = "Movie Quote of the Day";
            //Print all contents out in one string:
            //string contents = File.ReadAllText(QuotesFilePath);
            //WriteLine(contents);

            //string movieQuoteText = "I'm going to make him an offer he can't refuse.";
            //string movieInfo = "The Godfather, 1972";
            //string[] movieInfoParts = movieInfo.Split(',');
            //string movieName = movieInfoParts[0];
            //int year = Convert.ToInt32(movieInfoParts[1]);
            //MovieQuote godfatherQuote = new MovieQuote(movieQuoteText, movieName, year);
            //godfatherQuote.Display();


            string[] lines = File.ReadAllLines(QuotesFilePath);

            for(int i = 0; i < lines.Length; i += 3)
            {
                string quoteText = lines[i];
                string movieInfo = lines[i + 1];
                string[] movieInfoParts = movieInfo.Split(',');
                string movieName = movieInfoParts[0];
                int year = Convert.ToInt32(movieInfoParts[1]);
                double imdb = Convert.ToDouble(movieInfoParts[2]);
                int rotTom = Convert.ToInt32(movieInfoParts[3]);
                MovieQuote quote = new MovieQuote(quoteText, movieName, year, imdb, rotTom);
                movieQuotes.Add(quote);
            }
            PickRandomQuote(movieQuotes.Count);
            WaitForKey();
        }

        private void DisplayAllQuotes()
        {
            foreach (MovieQuote quote in movieQuotes)
            {
                quote.Display();
            }
        }
        private void PickRandomQuote(int maxValue)
        {
            Random random = new Random();
            int number = random.Next(maxValue);
            movieQuotes[number].Display();
        }
        private void WaitForKey()
        {
            ForegroundColor = ConsoleColor.DarkGray;
            WriteLine("(Press any key)");
            ReadKey(true);
        }
    }
}
