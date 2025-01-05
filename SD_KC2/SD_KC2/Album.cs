using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_KC2
{
    internal class Album : MyClass
    {
        public string Artist { get; set; }
        public int Year { get; set; }

        public override string ToString()
        {
            return $"Ablum: {MyProperty}, Artist: {Artist}, Year: {Year}";
        }

    }
}
