using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListPractice
{
    public class GenericList<T> : IEnumerable<T>
    {
        T[] superArray;
        public string stringOfLists;
        public GenericList()
        {
            superArray = new T[0];
        }
        public void AddArray(T addItem)
        {
            T[] tempArray = new T[superArray.Length + 1];
            for (int i = 0; i < superArray.Length; i++)
            {
                tempArray[i] = superArray[i];
            }
            tempArray[superArray.Length] = addItem;
            superArray = tempArray;
        }
        public void RemoveArray(T removeItem)
        {           
            bool item = true;
            T[] temporaryList = new T[superArray.Length - 1];
            for (int i = 0; i <= temporaryList.Length; i++)
            {
                if (item)
                {
                    if (superArray[i].Equals(removeItem))
                    {
                        item = false;
                    }
                    else
                    {
                        temporaryList[i] = superArray[i];
                    }                    
                } else
                {
                    temporaryList[i - 1] = superArray[i];
                }
            }
            superArray = temporaryList;
        }
        public void RemoveArray2(T removeItem)
        {
            for (int i = 0; i < superArray.Length; i++)
            {
                if (superArray[i].Equals(removeItem))
                {
                    RemoveArray(removeItem);
                }
            }
        }
        public void Zipper(List<T> listToZipper)
        {
            T[] temoraryArray = new T[superArray.Length];
            T[] temoraryArray2 = new T[0];
            temoraryArray = superArray;
            superArray = temoraryArray2;
            for (int i = 0; i < temoraryArray.Length || i < listToZipper.Count(); i++)
            {
                if (i < temoraryArray.Length)
                {
                    AddArray(temoraryArray[i]);
                }
                if (i < listToZipper.Count())
                {
                    AddArray(listToZipper[i]);
                }
            }
        }
        public string ListToString()
        {
            string myString = string.Join(",", superArray);
            stringOfLists = myString;
            return stringOfLists;
        }
        public static GenericList<T> operator +(GenericList<T> itemOne, GenericList<T> itemTwo)
        {
            GenericList<T> genList = new GenericList<T>();
            for (int i = 0; i < itemOne.Count(); i++)
            {                
                    genList.AddArray(itemOne.superArray[i]);
            }
            for (int i = 0; i < itemTwo.Count(); i++)
            {
                genList.AddArray(itemTwo.superArray[i]);
            }
                return genList;
        }
        public static GenericList<T> operator -(GenericList<T> itemOne, GenericList<T> itemTwo)
        {
            for (int i = 0; i < itemOne.Count(); i++)
            {                
                for (int z = 0; z < itemTwo.Count(); z++)
                {
                    if (itemOne.superArray[i].Equals(itemTwo.superArray[z]))
                    {
                        itemOne.RemoveArray(itemTwo.superArray[z]);
                    }
                }
            }
            return itemOne;
        }
        public void SortArray()
        {
            T temporary;
            for (int i = 0; i < superArray.Length; i++)
            {
                for (int z = 0; z < superArray.Length; z++)
                {
                    if(superArray[i].GetHashCode() < superArray[z].GetHashCode())
                    {
                        temporary = superArray[i];
                        superArray[i] = superArray[z];
                        superArray[z] = temporary;
                    }
                }
            }
        }
        public void HappyNumber()
        {            
            for (int i = 0; i < 1000; i++)
            {
                if (ShowHappy(i) == true)
                {
                    Console.WriteLine("{0} is a Happy Number", i);                    
                }
            }               
        }
        public bool ShowHappy(int number)
        {
            var visited = new List<int>();
            var n = number;
            while (!visited.Contains(n))
            {
                visited.Add(n);
                var sum = n;
                n = 0;
                while(sum != 0)
                {
                    n += (sum % 10) * (sum % 10);
                    sum /= 10;
                }
                if (n == 1)
                {
                    return true;
                }
            }
                return false;
        }
        public void Print()
        {
            foreach (T item in superArray)
            {
                Console.WriteLine(item);
            }
        }
        public int Count()
        {
            int index = 0;
            for (int i = 0; i < superArray.Length; i++)
            {
                index++;
            }
            return index;
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < superArray.Length; i++)
            {
                yield return superArray[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
