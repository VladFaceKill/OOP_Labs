using System;

namespace LABwork5
{
    sealed class Developer
    {
        string name;
        string surname;
        byte age;
        public static int taskCounter = 0;
        public Developer(string name="Vlad", string surname="Berinchik", byte age=19)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public string Surname
        {
            get
            {
                return surname;
            }
        }

        public byte Age
        {
            get
            {
                return age;
            }
        }


        public void ShowDevInfo() => Console.WriteLine($"Prod. by {name} {surname}");
        public void SetWork() => taskCounter++;
        public void GetDevLoad()
        {
            if(taskCounter < 2)
            {
                Console.WriteLine("Dev is almost free");
            }
            else if(taskCounter < 7)
            {
                Console.WriteLine("Dev has a lot of work");
            }
            else
            {
                Console.WriteLine("Press F to pay respect");
            }
        }

        public override string ToString()
        {
            string forReturn = $"Current developer is {name} {surname}";
            return forReturn;
        }
    }
}