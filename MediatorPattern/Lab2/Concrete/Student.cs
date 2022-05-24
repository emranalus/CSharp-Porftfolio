using MediatorPattern.Lab2.Abstract;
using MediatorPattern.Lab2.Mediator;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern.Lab2.Concrete
{
    public class Student : AssignedCourseMember
    {
        // When Student was summoned it wants a CoreMediator type parameter
        // To give it to the base abstract class
        public Student(CoreMediator coreMediator) : base(coreMediator)
        {

        }
    }
}
