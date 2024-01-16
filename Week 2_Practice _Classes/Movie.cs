using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Week_2_Practice__Classes
{
    public class Movie
    {
        string _name;
        string _genre;
        int _year;
        string _age;

        public Movie(string name, string genre, int year, string age)
        {
            Name=name;
            Genre=genre;
            Year=year;
            Age=age;
        }

        public string Name { get => _name; set => _name=value; }
        public string Genre { get => _genre; set => _genre=value; }
        public int Year { get => _year; set => _year=value; }
        public string Age { get => _age; set => _age=value; }
    }
}
