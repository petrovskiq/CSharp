using MyLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Classes
{
    public class Song
    {
        public Song(string title, int length, Genre genre)
        {
            Title = title;
            Length = length;
            Genre = genre;
        }

        public string Title { get; set; }
        public int Length { get; set; }
        public Genre Genre { get; set; }
    }

    
}
