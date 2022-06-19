using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpTopics.Basics.Helpers;

namespace CSharpTopics.Basics
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class DelegatesPracticeSort
    {
        public static void Main(string[] args)
        {
            Person[] persons = new Person[4];

            persons[0] = new Person { Name = "Rifat", Age = 25};
            persons[1] = new Person { Name = "KD001", Age = 27 };
            persons[2] = new Person { Name = "Rifat", Age = 16 };
            persons[3] = new Person { Name = "Titin", Age = 5 };

            int CompareValues(Person a, Person b)
            {
                if(a.Name == b.Name)
                {
                    if (a.Age < b.Age)
                        return 1;
                    else
                        return -1;
                }
                else
                {
                    return a.Name.CompareTo(b.Name);
                }
            }

            BubbleSort<Person>.Sort(persons, CompareValues);

            foreach(var a in persons)
                Console.WriteLine(a.Name + " " + a.Age);
        }
    }
}
