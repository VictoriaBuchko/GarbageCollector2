using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollector
{
    class Play
    {
        private string? title;
        private string? author;
        private string? genre;
        private int year;

        public Play()
        {
            title = "Untitled Play";
            author = "Unknown Author";
            genre = "Unknown Genre";
            year = 0;
        }

        public Play(string title, string author, string genre, int year)
        {
            Title = title;
            Author = author;
            Genre = genre;
            Year = year;
        }

        public string? Title
        {
            get { return title; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    title = value;
                }
                else
                {
                    throw new ArgumentException("Назва п'єси не може бути пустою");
                }
            }
        }

        public string? Author
        {
            get { return author; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    author = value;
                }
                else
                {
                    throw new ArgumentException("Автор не може бути пустим");
                }
            }
        }

        public string? Genre
        {
            get { return genre; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    genre = value;
                }
                else
                {
                    throw new ArgumentException("Жанр не може бути пустим");
                }
            }
        }

        public int Year
        {
            get { return year; }
            set
            {
                if (value > 0)
                {
                    year = value;
                }
                else
                {
                    throw new ArgumentException("Рік має бути більшим за 0");
                }
            }
        }

        ~Play()
        {
            Console.WriteLine($"П'єса {Title} видалена з пам'яті");
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Назва: {Title}\nАвтор: {Author}\nЖанр: {Genre}\nРік: {Year}\n");
        }
    }
}
