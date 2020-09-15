using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services
{
    public class AttrEmail
    {
        public string mail = "gepengdika333@gmail.com";
        public string pass = "kanawaadi100%";
    }

    public class RandomDigit
    {
        public Random _random = new Random();
        public string GenerateRandom()
        {
            return _random.Next(0, 999).ToString("D4");
        }
    }
}
