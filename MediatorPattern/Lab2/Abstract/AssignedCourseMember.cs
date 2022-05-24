using MediatorPattern.Lab2.Mediator;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern.Lab2.Abstract
{
    public abstract class AssignedCourseMember
    {
        private readonly CoreMediator coreMediator;

        public AssignedCourseMember(CoreMediator coreMediator)
        {
            this.coreMediator = coreMediator;
        }

        public string Name { get; set; }
        public void SendQuestion(string message)
        {
            Console.WriteLine($"{Name} : {message}");
        }

        public void RecieveQuestion(string message)
        {
            Console.WriteLine($"Student recieve answer: {message}");
        }

    }
}
