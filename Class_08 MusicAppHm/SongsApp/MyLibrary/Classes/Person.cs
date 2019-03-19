using MyLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary.Enums;

namespace MyLibrary.Classes
{
    public class Person
    {
       

        public Person(string firstname, string lastname, int age, Genre genre)
        {
            FirstName = firstname;
            LastName = lastname;
            Age = age;
            Genre = genre;
        }


        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Genre Genre { get; }
        public Genre FavoriteMusicType { get; set; }
        public List<Song> FavoriteSongs { get; set; }

        public string GetFavSongs()
        {
            if (FavoriteSongs.Count == 0)
            {
                return "Empty List";
            }
            else
            {
                foreach (var item in FavoriteSongs)
                {
                    return item.Title;
                }
            }
            return "";
        }
    }
}
