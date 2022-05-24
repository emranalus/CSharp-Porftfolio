using MediatorPattern.Lab2.Abstract;
using MediatorPattern.Lab2.Mediator;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern.Lab2.Concrete
{
    public class Teacher : AssignedCourseMember
    {
        public Teacher(CoreMediator coreMediator) : base(coreMediator)
        {
        }

        public string Name { get; set; }

        public void RecieveQuestion(string question, Student student) 
            => Console.WriteLine($"Teacher recieve question from {student.Name}: {question}");

        public void AnswerQuestion(string question, Student student)
            => Console.WriteLine($"Teacher answer question from {student.Name}: {question}");

    }
}
