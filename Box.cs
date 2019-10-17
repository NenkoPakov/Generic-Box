using System;
using System.Collections.Generic;
using System.Text;

namespace _1excercise
{
    class Box<T> where T : IComparable<T>
    {
        private List<T> items;

        public Box()
        {
            this.items = new List<T>();
        }

        public List<T> Items
        {
            get { return items; }
            set { this.items = value; }
        }

        public void Add(T element)
        {
            Items.Add(element);
        }

        public void SwapTwoElements(int firstElement, int secondElement)
        {
            var firstItem = Items[firstElement];
            Items[firstElement] = Items[secondElement];
            Items[secondElement] = firstItem;
        }

        public int CountOfLargerElements(T elementForComparison)
        {
            var count = 0;
            foreach (var item in items)
            {
                if (item.CompareTo(elementForComparison)!=1)
                {
                    continue; 
                }

                count++;
            }

            return count;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in Items)
            {
                sb.AppendLine($"{item.GetType()}: {item}");
            }

            return sb.ToString().Trim();
        }
    }
}
