using System;
using Generic_Colletions.Models;

namespace Generic_Colletions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //a) 4 dənə student obyekti yaradın qarışıq point dəyərlərində.
            Student student1 = new Student("Aqil","Xalilov",100);
            Student student2 = new Student("Xalil", "Xalilov", 101);
            Student student3 = new Student("Amil", "Xalilov", 99);
            Student student4 = new Student("Taner", "Xalilov", 130);

            //b) Group obyekti yaradın və group obyektinə AddStudent methodundan istifadə edərək studentləri əlavə edin.
            Group group =new Group();
            group.AddStudent(student1);
            group.AddStudent(student2);
            group.AddStudent(student3);
            group.AddStudent(student4);

            //c) GetAllStudents methodundan istifadə edərək bütün studentləri ekrana çıxardın.

            //group.GetStudents();
            ////d) Sort methodundan istifadə edərək sort olunmuş studentləri ekrana çıxardın.
            group.Sort();
            //e) İkinci bir Group obyketi yaradın və qrup nömrəsinin avtomatik artmağını yoxlayın.


        }
    }
}
