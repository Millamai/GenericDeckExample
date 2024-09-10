using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDeckExample
{
    internal class Deck<T>
    {

        private static Random rng = new Random();

        List<T> list = new List<T>();

        //Samme som add
        public void Push(T item)
        {
            list.Add(item);
        }

        //   Tager det sidste element og returnerer
        public T Pop()
        {
            T lastItem = list[list.Count - 1];
            list.Remove(lastItem);
            return lastItem;
        }

        public void Clear()
        {
            list.Clear();
        }

        public void Shuffle()
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        //Viser det øverste kort - her snyder vi :)
        public T Peek()
        {
            return list[list.Count - 1];
        }
    }
}
