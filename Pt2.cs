
using System;
using System.Text.Json;
using System.Text.Json.Serialization;

//Камерджиев Даниил ИУ6-74Б
//Домашнее задание часть 2 (F2)

namespace Kamerdzhiev
{
    public class Compositor
    {
        public string Name { get; set; }
        public string Surname {get; set;}

        /*public Compositor() //конструктор по умолчанию
        { 
            Name = "Неизвестно"; 
            Surname = "Неизвестно";
            Console.WriteLine("Имя: {0}\nФамилия: {1}\n", Name, Surname);
        }
        public Compositor(string name,string surname) //конструктор по умолчанию
        {
            Name = name;
            Surname = surname;
            Console.WriteLine("Имя: {0}\nФамилия: {1}\n", Name, Surname);
        }
        public string Represent()
        {
            string author = Name + ' ' + Surname;
            return author;
        }*/
    }
    public class Album
    {
        public string Name { get; set; }
        public int Year { get; set; }

        /*public Album() //конструктор по умолчанию
        {
            Name = "Неизвестно";
            Year =  0;
            Console.WriteLine("Название: {0}\nГод: {1}\n", Name, Year);
        }
        public Album(string name, int year)
        {
            Name = name;
            Year = year;
            Console.WriteLine("Название: {0}\nГод: {1}\n", Name, year);
        }
        public string Represent()
        {
            string album = Name + " Год: " + Year.ToString();
            return album;
        }*/
    }
    public class Song
    {
        public string Name { get; set; }
        public string Gener { get; set; }
        public int Year { get; set; }
        public Compositor[] Authors { get; set; }
        //public Compositor Author1, Author2, Author;
        public Album Album_s { get; set; }
        /*public Song() //конструктор по умолчанию
        {
            Name = "Неизвестно";
            Gener = "Неизвестно";
            Year = 0;
            Console.WriteLine("Название: {0}\nЖанр: {1}\nГод: {2}\n", Name, Gener,"Неизвесто");
        }
        public Song(string name,string gener, int year) //нет композитора
        {
            Name = name;
            Gener = gener;
            Year = year;
            Console.WriteLine("Название: {0}\nЖанр: {1}\nГод: {2}\n", Name, Gener, Year);
        }
        public Song(string name, string gener, int year, Compositor author) //композитор
        {
            Name = name;
            Gener = gener;
            Year = year;
            Author = author;
            Console.WriteLine("Название: {0}\nЖанр: {1}\nГод: {2}\nАвтор: {3}\n", Name, Gener, Year, Author.Represent());

      }
        public Song(string name, string gener, int year, Compositor author1, Compositor author2)//два композитора
        {
            Name = name;
            Gener = gener;
            Year = year;
            Author1 = author1;
            Author2 = author2;
            Console.WriteLine("Название: {0}\nЖанр: {1}\nГод: {2}\nАвторs: {3}, {4}\n", Name, Gener, Year, Author1.Represent(), Author2.Represent());

        }
        public Song(string name, string gener, int year, Compositor author, Compositor author1, Compositor author2)//три композитора
        {
            Name = name;
            Gener = gener;
            Year = year;
            Author = author;
            Author1 = author1;
            Author2 = author2;
            Console.WriteLine("Название: {0}\nЖанр: {1}\nГод: {2}\nАвторs: {3}, {4}, {5}\n", Name, Gener, Year, Author.Represent(), Author1.Represent(), Author2.Represent());

        }
        //с албомом
        public Song(string name, string gener, int year,Album album) //нет композитора
        {
            Name = name;
            Gener = gener;
            Year = year;
            Album_s = album;
            Console.WriteLine("Название: {0}\nЖанр: {1}\nГод: {2}\nАльбом: {3}\n", Name, Gener, Year, Album_s.Represent()); ;
        }
        public Song(string name, string gener, int year, Compositor author, Album album) //композитор
        {
            Name = name;
            Gener = gener;
            Year = year;
            Author = author;
            Album_s = album;
            Console.WriteLine("Название: {0}\nЖанр: {1}\nГод: {2}\nАвтор: {3}\nАльбом: {4}\n", Name, Gener, Year, Author.Represent(), Album_s.Represent());

        }
        public Song(string name, string gener, int year, Compositor author1, Compositor author2, Album album)//два композитора
        {
            Name = name;
            Gener = gener;
            Year = year;
            Author1 = author1;
            Author2 = author2;
            Album_s = album;
            Console.WriteLine("Название: {0}\nЖанр: {1}\nГод: {2}\nАвторs: {3}, {4}\nАльбом: {5}\n", Name, Gener, Year, Author1.Represent(), Author2.Represent(), Album_s.Represent());

        }
        public Song(string name, string gener, int year, Compositor author, Compositor author1, Compositor author2, Album album)//три композитора
        {
            Name = name;
            Gener = gener;
            Year = year;
            Author = author;
            Author1 = author1;
            Author2 = author2;
            Album_s = album;
            Console.WriteLine("Название: {0}\nЖанр: {1}\nГод: {2}\nАвторs: {3}, {4}, {5}\nАльбом: {6}\n", Name, Gener, Year, Author.Represent(), Author1.Represent(), Author2.Represent(), Album_s.Represent());

        }*/


}
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Compositor DA = new Compositor("Die", "Antwoord");
            Compositor MM = new Compositor("Marylin", "Menson");
            Compositor BS = new Compositor("Britney", "Spears");
            Compositor AG = new Compositor("Ariana", "Grande");
            Compositor BP = new Compositor("Black", "Pink");
            Album tPE = new Album("The Pale Emperor", 2015);
            Song HOTC = new  Song("Deep Six","Rock",2015, MM, DA, tPE);
            Song Txx = new Song("Toxic","Pop", 2003, BS);
            */
            Compositor LDR = new Compositor
            {
                Name = "Lana",
                Surname = "Del Rey"

            };
            Compositor WD = new Compositor
            {
                Name = "Weekend",
                Surname = " "

            };
            Album LFLA = new Album
            {
                Name = "Lust for Life",
                Year = 2017,
            };
            Song LFL = new Song
            {
                Name = "Lust for Life",
                Year = 2017,
                Gener = "Indie",
                Authors = new Compositor[] { LDR, WD },
                Album_s = LFLA

            };

            
            string json = JsonSerializer.Serialize<Song>(LFL);
            Console.WriteLine(json);
            Console.ReadKey();
        }
    }
}
