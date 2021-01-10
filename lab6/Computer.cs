using System;
using System.Collections.Generic;
using System.Text;
using LABwork5.SoftwarePlace;

namespace LABwork5
{
    namespace PC
    {
        class Computer : Software
        {
            string name;
            string model;

            public Computer(string name, string model, string soft) : base(soft)
            {
                this.name = name;
                this.model = model;
                _container = new List<object>();
            }

            private List<object> _container;

            public object this[int index]
            {
                get
                {
                    return _container[index];
                }
                set
                {
                    _container[index] = value;
                }
            }

            public void Add(Software soft) => _container.Add(soft);
            public void Remove(Software soft) => _container.Remove(soft);
            public void ShowList()
            {
                foreach(var i in _container)
                {
                    Console.WriteLine(i);
                }
            }

            public override string ToString()
            {
                string forReturn = $"Current computer is {name}. It model - {model}";
                return forReturn;
            }
        }
    }
}
