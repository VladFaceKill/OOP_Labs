using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LABwork7.UserExceptions;

namespace LABwork7
{
    namespace Dev
    {
        class Developer
        {
            int age;

            public Developer(int age)
            {
                if(age < 0) throw new AgeException("Invalid value: age less than zero", 404);
                this.age = age;
            }

            public int Age
            {
                get
                {
                    return age;
                }
                set
                {
                    if (value < 0) throw new AgeException("Invalid value: age less than zero", 404);
                    else age = value;
                }
            }
        }
    }
}
