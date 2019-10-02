using System;
using System.Collections.Generic;
using System.Text;

namespace Learning_Project.CodeForces
{
    class ProtoTypePattern
    {
        class MainApp
        { 
            static void Main()
            {
                // Create two instances and clone each


                ConcretePrototype1 p1 = new ConcretePrototype1("I");
                ConcretePrototype1 c1 = (ConcretePrototype1)p1.Clone();
                Console.WriteLine("Cloned: {0}", c1.Id);

                ConcretePrototype2 p2 = new ConcretePrototype2("II");
                ConcretePrototype2 c2 = (ConcretePrototype2)p2.Clone();
                Console.WriteLine("Cloned: {0}", c2.Id);

                Console.ReadKey();
            }
        }
        abstract class Prototype
        {
            public Prototype(string id)
            {
                this.Id = id;
            }
            public string Id { get; }
            public abstract Prototype Clone();
        }
        class ConcretePrototype1 : Prototype
        {
            public ConcretePrototype1(string id)
              : base(id)
            {
            }
            public override Prototype Clone()
            {
                return (Prototype)this.MemberwiseClone();
            }
        }
        class ConcretePrototype2 : Prototype
        {
            public ConcretePrototype2(string id)
              : base(id)
            {
            }
            public override Prototype Clone()
            {
                return (Prototype)this.MemberwiseClone();
            }
        }
    }
}
