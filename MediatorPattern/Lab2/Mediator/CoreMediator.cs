using MediatorPattern.Lab2.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern.Lab2.Mediator
{
    public class CoreMediator
    {

        public Teacher teacher { get; set; }
        public List<Student> Students { get; set; }

        public void MediatorSendQuestion(string question, Student student)
            => teacher.RecieveQuestion(question, student);

        public void MediatorSendAnswers(string answer, Student student)
            => student.RecieveQuestion(answer);
        

    }
}
