using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Pojazdy
{
    public abstract class ABook
    {
        protected static int ID = 0;

        private string _name;
        private string _genre;
        private DateTime _releaseDate;
        private string _autor;
        private decimal _price;

        public string name 
        { 
            get => _name;
            set
            {
                if (string.IsNullOrEmpty(value)) throw new ArgumentNullException("Error: name can't be Null or Empty");
                if (value.Length <= 3) throw new ArgumentNullException("Error: The name of title can't be less than 3 letters");
                _name = value.ToUpper();
            }
        }
        public string genre
        {
            get => _genre;
            set
            {
                if (string.IsNullOrEmpty(value)) throw new ArgumentNullException("Error: genre can't be Null or Empty");
                if (value.Length <= 3) throw new ArgumentNullException("Error: The name of genre can't be less than 3 letters");
                _genre = value.ToUpper();
            }
        }
        public DateTime releaseDate 
        {
            get => _releaseDate;
            set
            {
                if (value > DateTime.Now) throw new ArgumentOutOfRangeException("Error: Date of release can't be later than today's date");
                _releaseDate = value;
            }
        }
        public string autor 
        {
            get => _autor;
            set
            {
                if (string.IsNullOrEmpty(value)) throw new ArgumentNullException("Error: autor can't be Null or Empty");
                if (value.Length <= 3) throw new ArgumentNullException("Error: The Autor's name can't be less than 3 letters");
                _autor = value.ToUpper();
            } 
        }
        public decimal price
        {
            get => _price;
            set
            {
                if (value <= 0) throw new ArgumentOutOfRangeException("Error: Price should be more than 0");
                _price = value;
            }
        }
        public abstract void ShowInfo();
    }

    internal class Czasopismo : ABook
    {
        private int _id;
        private string _theme;
        public string theme
        {
            get=> _theme;
            set
            {
                if (string.IsNullOrEmpty(value)) throw new ArgumentNullException("Error: there can't be Null or Empty");
                if (value.Length <= 3) throw new ArgumentNullException("Error: theme can't be less than 3 letters");
                _theme = value.ToUpper();
            }
        }
        public Czasopismo() : base()
        {
            _id = ID;
            ID++;
        }
        public override void ShowInfo() => Console.WriteLine($"Name of the book: {name} (ID:{_id})\nGenre: {genre}\nTheme: {theme}\n" +
            $"Date of release: {releaseDate:yyyy-MM-dd}\nThe autor: {autor}\nPrice of the book: {price:f2}$\n");
    }

    internal class Podrecznik : ABook
    {
        private int _id;
        private string _subject;
        private string _level;
        private string _language;

        public string language
        {
            get => _language;
            set
            {
                if (string.IsNullOrEmpty(value)) throw new ArgumentNullException("Error: language can't be Null or Empty");
                if (value.Length <= 3) throw new ArgumentNullException("Error: languge can't be less than 3 letters");
                _language = value.ToUpper();
            }
        }
        public string level
        {
            get => _level;
            set
            {
                if (string.IsNullOrEmpty(value)) throw new ArgumentNullException("Error: level can't be Null or Empty");
                if (value.Length <= 3) throw new ArgumentNullException("Error: level can't be less than 3 letters");
                _level = value.ToUpper();
            }
        }
        public string subject
        {
            get => _subject;
            set
            {
                if (string.IsNullOrEmpty(value)) throw new ArgumentNullException("Error: field can't be Null or Empty");
                if (value.Length <= 3) throw new ArgumentNullException("Error: field can't be less than 3 letters");
                _subject = value.ToUpper();
            }
        }
        public Podrecznik() : base()
        {
            _id = ID;
            ID++;
        }
        public override void ShowInfo() => Console.WriteLine($"Name of the book: {name} (ID:{_id})\nSubject: {subject}\nLevel: {level}\nLanguage: {language}\n" +
            $"Date of release: {releaseDate:yyyy-MM-dd}\nThe autor: {autor}\nPrice of the book: {price:f2}$\n");
    }

    internal class Powiesc : ABook
    {
        private int _id;
        private int _pagesCount;
        public int pagesCount
        {
            get => _pagesCount;
            set
            {
                if (value <= 0) throw new ArgumentException("Error: Count of pages can be only higher than 0");
                _pagesCount = value;
            }
        }
        
        public Powiesc() : base()
        {
            _id = ID;
            ID++;
        }
        public override void ShowInfo() => Console.WriteLine($"Name of the book: {name} (ID:{_id})\nGenre: {genre}\nPages count: {pagesCount}\n" +
            $"Date of release: {releaseDate:yyyy-MM-dd}\nThe autor: {autor}\nPrice of the book: {price:f2}$\n");
    }
}