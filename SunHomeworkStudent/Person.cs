using System;

namespace SunHomeworkStudent
{
    class Person
    {
        public int studage; 
            public void Greet()
            {
            Console.WriteLine("Hellooo ");
            }


        public void SetAge(int age)

            {
                Console.WriteLine ("The age is now set to -->  " + age) ;
                studage = age;
            }


    }
}
