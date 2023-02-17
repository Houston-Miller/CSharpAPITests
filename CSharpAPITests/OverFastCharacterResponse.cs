using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAPITests
{

    public class OverFastCharacterResponse
    {
        public string name { get; set; }
        public string description { get; set; }
        public string portrait { get; set; }
        public string role { get; set; }
        public string location { get; set; }
        public Ability[] abilities { get; set; }
        public Story story { get; set; }
    }

    public class Story
    {
        public string summary { get; set; }
        public Media media { get; set; }
        public Chapter[] chapters { get; set; }
    }

    public class Media
    {
        public string type { get; set; }
        public string link { get; set; }
    }

    public class Chapter
    {
        public string title { get; set; }
        public string content { get; set; }
        public string picture { get; set; }
    }

    public class Ability
    {
        public string name { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
    }

}
