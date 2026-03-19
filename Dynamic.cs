using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr1
{
    public class Dynamic
    {
        public delegate bool Validator(string word);
        public static Validator GetValidator(int minLength)
        {
            return (words) => words.Length > minLength;
        }
    }
}