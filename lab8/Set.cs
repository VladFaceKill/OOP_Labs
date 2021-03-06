﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.IO;

namespace Lab_8
{
    public interface IGeneric<T>
    {
        public void Add(T newEl);
        public void Delete(T el);
        public void Show();

    }
    class Set<T> : IGeneric<T> where T : IComparable<T>
    {
        internal T[] elements;

        public Set(T[] array)
        {
            elements = new T[array.Length];
            array.CopyTo(elements, 0);
        }

        public T this[int i]
        {
            get
            {
                if (i >= 0 && i < elements.Length) return elements[i];
                else return default(T);
            }
        }

        public void Show()
        {
            for (int i = 0; i < elements.Length; i++)
            {
                Console.Write(this.elements[i] + "  ");
            }
            Console.WriteLine();
        }

        public void Add(T newEl)
        {
            try
            {
                Array.Resize(ref elements, elements.Length + 1);
                elements[elements.Length - 1] = newEl;

            }
            catch (OutOfMemoryException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Блок finaly выполнен");
            }
            Sort();
        }

        public void Delete(T el)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i].Equals(el))
                {
                    T addVar = elements[^1];
                    elements[^1] = elements[i];
                    elements[i] = addVar;
                    Array.Resize(ref elements, elements.Length - 1);
                }
            }
            Sort();
        }

        public void Sort()
        {
            Array.Sort(elements);
        }
        public void ToFile(string path)
        {
            using (StreamWriter strWriter = new StreamWriter(path))
            {
                foreach (var el in elements)
                {
                    strWriter.WriteLine(el.ToString());
                }
                
            }
        }
    }
}

