using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAlong09._12._24
{
    internal class Animal
    {
        private string Type;
        private string Sound;


        //ctor
        public Animal( string type, string sound)
        {
            Type = type;
            Sound = sound;
        }

        public string ReturnType()
        {
            return Type;
        }

        public string ReturnSound()
        {
            return Sound;
        }

    }
}