using System;
using System.IO;
using LABwork5.Processor;

namespace LABwork5
{
    namespace MSWord
    {
        internal class Word : TextProcessor, ITextComands
        {
            string[,] textTable;
            int rowCounter;
            int colCounter;
            int version;
            public Word(int row =5, int col=5, int workSpaceSize=5, int version=1) : base(workSpaceSize)
            {
                textTable = new string[row, col];
                rowCounter = row;
                colCounter = col;
                this.version = version;
            }
            public int Version
            {
                get
                {
                    return version;
                }
            }
            public string this[int row, int col]
            {
                get
                {
                    if(IsAvailable(row, col))
                    {
                        return textTable[row,col];
                    }
                    else
                    {
                        Console.WriteLine("Попытка получения элемента по недопустимому индексу");
                        return "";
                    }
                }
                set
                {
                    if (IsAvailable(row,col))
                    {
                        textTable[row, col] = value;
                    }
                    else
                    {
                        Console.WriteLine("Попытка присваивания значения элементу по недопустимому индексу");
                        textTable[row, col] = "";
                    }
                }
            }

            public int Row
            {
                get
                {
                    return rowCounter;
                }
                set
                {
                    rowCounter = value;
                }
            }
            public int Col
            {
                get
                {
                    return colCounter;
                }
                set
                {
                    colCounter = value;
                }
            }

            public void CreateTable()
            {
                Console.ResetColor();

                Console.WriteLine("Here you can create your table");

                Console.WriteLine("Enter row size => ");
                rowCounter = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter col size => ");
                colCounter = Convert.ToInt32(Console.ReadLine());

                string[] headers = new string[colCounter];

                for(int i = 0; i < colCounter; i++)
                {
                    Console.WriteLine("Enter header of " + (i+1) + " column");
                    textTable[0, i] = Console.ReadLine();
                    headers[i] = textTable[0, i];
                }

                for(int i = 1; i < rowCounter; i++)
                {
                    for(int j = 0; j < colCounter; j++)
                    {
                        Console.WriteLine($"Enter {headers[j]} content");
                        textTable[i, j] = Console.ReadLine();
                    }
                }
                
            }

            public void ShowTable()
            {
                Console.WriteLine();
                for(int i = 0; i < rowCounter; i++)
                {
                    Console.Write("\t");
                    for (int j = 0; j < colCounter; j++)
                    {
                         Console.Write(textTable[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }

            public override void EditText()
            {
                Console.ResetColor();

                Console.WriteLine("What do you want to change? ");
                Console.WriteLine("1 - table to uppercase");
                Console.WriteLine("2 - table to lowercase");
                Console.WriteLine("3 - change content of workSpace");
                Console.WriteLine("4 - change content of table");
                Console.WriteLine("5 - nothing");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        for (int i = 0; i < rowCounter; i++)
                        {
                            for (int j = 0; j < colCounter; j++)
                            {
                                textTable[i, j] = textTable[i, j].ToUpper();
                            }
                        }
                        break;
                    case 2:
                        for (int i = 0; i < rowCounter; i++)
                        {
                            for (int j = 0; j < colCounter; j++)
                            {
                                textTable[i, j] = textTable[i, j].ToLower();
                            }
                        }
                        break;
                    case 3:
                        Console.WriteLine("Please, enter a number of string for change => ");
                        int indexForChange = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("So, now enter a new value => ");
                        string newValue = Console.ReadLine();

                        workSpace[indexForChange - 1] = newValue;
                        break;
                    case 4:
                        Console.WriteLine("Enter a row for change => ");
                        int rowForChange = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter a col for change => ");
                        int colForChange = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("So, now enter a new value => ");
                        string anotherValue = Console.ReadLine();

                        textTable[rowForChange, colForChange] = anotherValue;

                        return;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Invalid command");
                        break;
                }
            }

            public override string ToString()
            {
                string str = $"Your table consist of {rowCounter} row & {colCounter} columns";
                return str;
            }
        }
    }
}