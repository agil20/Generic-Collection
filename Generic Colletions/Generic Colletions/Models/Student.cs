using System;

namespace Generic_Colletions.Models
{
    internal class Student
    {

        /*Student class
- Id - qıraqdan set etmək olmayacaq yalnız get etmək olacaq və hər dəfə yeni bir Student obyekt yaradıldıqda avtomatik bir vahid artacaq.
- Name
- Surname
- Age
- Point
- ShowInfo() - student-in bütün məlumatlarını geriyə qaytaracaq.

'>' və '<' operatorları üçün operator overloading yazırsız və Point dəyərlərini müqayisə edir.

ps: Name, surname, point dəyərləri olmadan student obyekti yaratmaq olmaz
*/
       
        private static int _id;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public int Age { get; set; }
        public int Point { get; set; }
        public Student()
        {
            _id++;
            Id = _id;
        }
        public Student(string name, string surname, int point)
        {
            Name = name; Surname = surname;
            Point = point;
            
            
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Name {Name}\n" +
                $"Surname{Surname}\n" +

                $"Point {Point}\n");
           
        }
        public static bool operator >(Student s1, Student s2){
            return s1.Point > s2.Point;
        }

    public static bool operator <(Student s1, Student s2) { return s1.Point < s2.Point; }
}
}
   

