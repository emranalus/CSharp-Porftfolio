using MediatorPattern.Lab2.Concrete;
using MediatorPattern.Lab2.Mediator;
using System;
using System.Collections.Generic;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Lab2

            CoreMediator mediator = new CoreMediator();
            Teacher teacher = new Teacher(mediator);
            teacher.Name = "Ercan";

            Student emirhan = new Student(mediator);
            emirhan.Name = "Emirhan";
            Student notemir = new Student(mediator);
            notemir.Name = "NotEmir";

            mediator.Students = new List<Student>();
            mediator.Students.Add(emirhan);
            mediator.Students.Add(notemir);

            emirhan.SendQuestion("Dolar isaretini neden koyuyoruz hojam?");
            teacher.AnswerQuestion("Parayi veren dudugu calar!", emirhan);

            notemir.SendQuestion("Hojam marsta namaz kilarsam kible ne taraf?");
            teacher.AnswerQuestion("Dunyaya don cucum", notemir);

            #endregion

            Console.WriteLine("Hello World!");
        }
    }
}
