using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmicsDeLaMusicaClassLibrary.Src.Musician
{
    public class Musician
    {
        public int Id { get; set; }

        public override string ToString()
        {
            return Id.ToString();
            //return name;
        }

    }
}
