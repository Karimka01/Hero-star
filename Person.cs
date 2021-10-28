using System;
using System.Collections.Generic;
using System.Text;

namespace Persona
{
    public class Person
    {

        private string surname;
        private string name;
        private string patronymic;
        private int age;
        private double weight;
        private string colorEyes;
        public Person(string surname, string name, string patronymic, int age, double weight, string colorEyes)
        {
            this.surname = surname;
            this.name = name;
            this.patronymic = patronymic;
            this.colorEyes = colorEyes;
            this.age = age;
            this.weight = weight;

        }

        public void runInWork()
        {
            Console.WriteLine("*Сломя голову несусь на работу*");
        }
        public void eatDonut()
        {
            Console.WriteLine("*С трудом идя на работу, кушаю пончик*");
        }
        public void sleeping()
        {
            Console.WriteLine("*Сплю...Zzzzz...*");
        }
        public void eatSoup()
        {
            Console.WriteLine("*Жадно ем на обеде суп!!*");
        }
        public override string ToString()
        {
            return ("Моя фамилия - " + surname + ", моё имя - " + name + ", моё отчество - " + patronymic + ",\nи мне всего лишь " + age + " лет , а вешу я всего ничего, " + weight
                              + "киллограм ,\nглаза у меня красивые, " + colorEyes + " цвета.");
        }
    }
}

