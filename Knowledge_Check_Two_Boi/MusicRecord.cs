using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knowledge_Check_Two_Boi
{
    internal class MusicRecord : Record
    {
        public string Genre { get; set; }
        public int Year { get; set; }
        public override string ToString()
        {
            return $"Title: {Title}, Artist: {Artist}, Genre: {Genre}, Year: {Year}"; ;
        }
    }
}
