using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    delegate string StringModifier(string str);
    delegate void Squeeze(int сoefficient);                 
    delegate void Move(int xCoordinate, int yCoordinate);

    class Program
    {
        static void Main()
        {
            Character human = new Character("Vlad", 100, 100);

            Event myEvent = new Event();

            myEvent.MoveEvent += (x, y) => human.MoveCharacter(x, y);
            myEvent.SqueezeEvent += s => human.ShrinkCharacter(s);

            human.CharacterInfo();

            myEvent.CallMove(3,5);

            human.CharacterInfo();

            myEvent.CallSqueeze(3);

            human.CharacterInfo();


            StringModifier modifier;
            StringModifier delPunctuationMark = s =>
            {
                string temp = "";
                string marks = ",.:;-()";

                bool isMark = false;

                for (int i = 0; i < s.Length; i++)
                {
                    isMark = false;

                    for (int j = 0; j < marks.Length; j++)
                    {
                        if (s[i] == marks[j])
                        {
                            isMark = true;
                            break;
                        }
                    }

                    if (isMark == false) temp += s[i];

                }

                Console.WriteLine(temp);

                return temp;
            };
            StringModifier reverseString = s =>
            {
                string temp = " ";

                for (int j = 0, i = s.Length - 1; i >= 0; i--, j++)
                {
                    temp += s[i];
                }

                Console.WriteLine(temp);

                return temp;
            };
            StringModifier toUpper = s => s.ToUpper();
            StringModifier delSpaces = s =>
            {
                string temp = "";

                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] != ' ') temp += s[i];
                }

                Console.WriteLine(temp);

                return temp;
            };
            StringModifier replaceSpaces = s =>
            {
                Console.WriteLine(s.Replace(' ', '_'));
                return s.Replace(' ', '_');
            };


            modifier = delPunctuationMark;
            modifier += reverseString;
            modifier += replaceSpaces;
            modifier += delSpaces;
            modifier += toUpper;

            Console.WriteLine(modifier("строка , массив : событие ; лямбда-выражение . делегат )"));
        }
    }

    class Event
    {
        public event Squeeze SqueezeEvent;
        public event Move MoveEvent;

        public void CallMove(int x, int y) => MoveEvent?.Invoke(x, y);
        public void CallSqueeze(int coefficient) => SqueezeEvent?.Invoke(coefficient);
    }

    class Character
    {

        int xPosition = 0;
        int yPosition = 0;

        public Character(string name, int health, int armor = 0)
        {
            this.Name = name;
            this.Health = health;
            this.Armor = armor;
        }

        public string Name { get; set; }
        public int Health { get; set; }
        public int Armor { get; set; }
        public int XPosition { get => xPosition; set => xPosition = value; }
        public int YPosition { get => yPosition; set => yPosition = value; }

        public void CharacterInfo()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Position: ({0},{1})", xPosition, YPosition);
            Console.WriteLine("HP: {0}", Health);
            Console.WriteLine("Armor: {0}", Armor);
            Console.WriteLine('\n');
        }

        public void MoveCharacter(int x, int y)
        {
            XPosition = x;
            YPosition = y;
        }

        public void ShrinkCharacter(int coefficient)
        {
            Health /= coefficient;
            Armor /= coefficient;
        }
    }

}
