using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Lb8
{

    public enum Month
    {
        January = 1, February, March, April, May, June, July, August, September, October, November, December
    }

    public struct ReleaseDate
    {
        public int day;
        public int month;
        public int year;
        public string GetDate()
        {
            return day + "." + month + "." + year;
        }
    }
}
    
    

   