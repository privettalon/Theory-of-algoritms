using System;
using System.Collections.Generic;
using System.Linq;


namespace HashTables_lab_edition_
{
    class HashTables<TKey, TValue>
    {
        private List<TValue>[] items;

        public HashTables(int size)// конструктор створює масив списків заданого розміру
        {
            items = new List<TValue>[size];
        }

        public bool Delete(TKey key, TValue value)
        {
            int k = GetHashCodeMy(key);
            if (items[k].Contains(value))
            {
                var index = items[k].IndexOf(value);
                items[k].RemoveAt(index);
                return true;
            }
            else
            {
                return false;
            }
            
        }
        public void Add(TKey key, TValue value, int n)// функція додавання значення в хеш таблицю
        {
            int k=0;
            if (n == 1)
            {
                 k = GetHashCodeMy(key); // індекс комірки масива який знаходиться за допомогою хешфункції
            }
            else
           if (n==2)
            {
                k = GetHashDivision(Convert.ToInt32(key));
            }
            else
           if (n==3)
            {
                 k = GetHashmult(Convert.ToInt32(key));
            }
            else
           if(n==4)
            {
                 k = GetHashUnivarsal(key);
            }
            else
            if(n==5)
            {
                k = Convert.ToInt32(key);
            }
            else
            {
                Console.WriteLine("error no ne 404");
            }
            

            if (items[k] == null) // якщо вона пуста створюємо там новий список 
            {
                items[k] = new List<TValue>() { value };
            }
            else// якщо комірка не пуста додаємо до списку нове значення
            {
                items[k].Add(value);
            }
        }

        public bool Search(TKey key, TValue item)// функція пошуку значення в цій хеш таблиці
        {
            var k = GetHashCodeMy(key);// індекс комірки масива який знаходиться за допомогою хешфункції
            if (items[k].Contains(item))//перевіряє чи входить елемент в колекцію . Contains повертає true or false
            {
                return true;
            }
            else //Якщо такого елемента в List немає або взагалі не існує List в даній комірці масиву повертає false
            {
                return false;
            }
        }

        private int GetHashCodeMy(TKey key)
        {
            return Convert.ToInt32(key.ToString().Substring(0, 1));// ключем є перша цифра 
        }
        private int GetHashDivision(int key)
        {
            int leght = items.Count();
            return key % leght;
        }
        private int GetHashmult(int key)
        {
        
            double A = 0.62;
            int m = 701;
            double d = key * A ;
            double answ = d - (int)d;
            if (key == 803)
            {
                return Convert.ToInt32(m * d );
            }
            else
            return Convert.ToInt32(m * d);
        }

        private int GetHashUnivarsal(TKey key)
        {
           
            return key.GetHashCode();
        }
        public int GetNumberofCol()
        {
            int number=0;
            for(int i=0;i<items.Count();i++)
            {
                if(items[i]==null)
                {
                    
                }
                else if(items[i].Count>1)
                {
                    number++;
                }
            }
            return number;
        }
        public void ShowTable()
        {
            for (int i = 0; i < items.Count(); i++)
            {
                if (items[i] == null)
                {
                    
                }
                else
                {
                    Console.Write("\nIndex[" + i + "] -> ");
                    foreach (TValue k in items[i])
                    {
                        Console.Write(k+"\t ");
                    }
                }
            }
        }
    }
}
