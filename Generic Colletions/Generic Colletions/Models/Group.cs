using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Colletions.Models
{
    internal class Group
    {
        /* No - qıraqdan set etmək olmayacaq yalnız get etmək olacaq hər dəfə yeni bir Group obyekt yaradıldıqda avtomatik qrup nömrəsinin rəqəm 
        * hissəsi bir vahid artacaq ilk yaradılacaq qrupun qrup nönmrəsi AP101 olacaq ikinci dəfə qrup yaradan zaman avtomatik
        * AP102 olacaq bu şəkildə hər dəfə yeni qrup yaradılanda rəqəm hissəsi artacaq.*/
        /*- Students array - private olacaq, Student obyektilərini özündə saxlayacaq.*/
       private Student[] Students=new Student[0];
        /*- AddStudent() - bu metod studnet type-da studnet qebul edir ve Students array-e elave edir.*/
        public void AddStudent(Student student)
        {
            Array.Resize(ref Students, Students.Length + 1);
            Students[Students.Length-1]=student;

        }
        /*- GetAllStudents() - geriyə bütün studentləri qaytaracaq.*/
        public void GetStudents()
        {
            foreach (var item in Students)
            {
                Console.WriteLine(item);
            }
        }
        /*- Sort() - parametr olaraq heç nə qəbul etməyəcək, Students
 * arrayindəki studentləri Point dəyərlərinə görə sort edib(azdan çoxa sıralamaq)
 geriyə bir Student tipindən sort olunmuş bir array qaytaracaq*/
        public void Sort()
        {
          
        }













    }
}
