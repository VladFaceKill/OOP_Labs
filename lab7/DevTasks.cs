using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LABwork7.UserExceptions;

namespace LABwork7
{
    namespace UserExceptions
    {
        class DevTasks
        {
            string[] tasks;
            int tasksCount;
            public DevTasks(int size)
            {
                tasksCount = size;
                tasks = new string[size];
            }

            public string this[int index]
            {
                get
                {
                    if (index < 0 || index >= tasksCount) throw new OutOfRangeException("Index out of range, careful", 363);
                    return tasks[index];
                }
            }
        }
    }
}
