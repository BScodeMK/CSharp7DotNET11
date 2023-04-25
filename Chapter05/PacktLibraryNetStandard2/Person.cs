using System;
using System.Collections.Generic;
using System.Text;

namespace Packt.Shared
{
    public class Person : object
    {
        public string? Name;
        public DateTime dateOfBitrth;
        public WondersOfTheAncientWorld FavoriteAncientWonder;
        public List<Person> Children = new List<Person>();
    }
}
