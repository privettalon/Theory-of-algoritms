using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTables_lab_edition_
{
    class HashTables<TKey, TValue>
    {
        private List<TValue>[] items;

        public HashTables(int size)// конструктор створює масив списків заданого розміру
        {
            items = new List<TValue>[size];
        }

        public void Add(TKey key, TValue value)// функція додавання значення в хеш таблицю
        {
            var k = GetHashCode(key);// індекс комірки масива який знаходиться за допомогою хешфункції
            if (items[k] == null) // якщо вона пуста створюємо там новий список 
            {
                items[k] = new List<TValue>() { value };
            }
            else// якщо комірка не пуста додаємо до списку нове значення
            {
                items[k].Add(value);
            }
        }

        public bool Search(TKey key , TValue item)// функція пошуку значення в цій хеш таблиці
        {
            var k = GetHashCode(key);// індекс комірки масива який знаходиться за допомогою хешфункції
            if (items[k].Contains(item))//перевіряє чи входить елемент в колекцію . Contains повертає true or false
            {
                return true;
            }
            else //Якщо такого елемента в List немає або взагалі не існує List в даній комірці масиву повертає false
            {
                return false;
            }
        }

        private int GetHashCode(TKey key)
        {
            return Convert.ToInt32(key.ToString().Substring(0, 1));// ключем є перша цифра 
        }
    }
}
