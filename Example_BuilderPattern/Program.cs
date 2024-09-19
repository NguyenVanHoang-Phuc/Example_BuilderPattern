using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace UserName.BuilderPattern{
    class UserName //Define class 
    {
        private List<string> names = new List<string>();

        public void Add(string name)
        {
            names.Add(name);
        }

        public void Display()
        {
            Console.WriteLine("\nName List -------");
            foreach (string name in names)
                Console.WriteLine(name);
        }
    }

    abstract class Builder //Builder Interface
    {
        public abstract void BuildPartA();
        public abstract void BuildPartB();
        public abstract UserName GetResult();
    }

    class ConcreteBuild1 : Builder // Implement Concrete Builder 1
    {
        private UserName names = new UserName();
        public override void BuildPartA()
        {
            names.Add("Phuc Nguyen");
        }

        public override void BuildPartB()
        {
            names.Add("Cuong Truong");
        }

        public override UserName GetResult()
        {
            return names;
        }
    }

    class ConcreteBuild2 : Builder // Implement Concrete Builder 1
    {
        private UserName names = new UserName();
        public override void BuildPartA()
        {
            names.Add("Bao Le");
        }

        public override void BuildPartB()
        {
            names.Add("Trong HIV");
        }

        public override UserName GetResult()
        {
            return names;
        }
    }
    class Director  // Optional
    {
        public void Contruct(Builder builder)
        {
            builder.BuildPartA();   
            builder.BuildPartB();
        }
    }

    class Proogram
    {
        static void Main(string[] args)
        {
            // Create Director and Builder
            Director director = new Director();

            Builder b1 = new ConcreteBuild1();
            Builder b2 = new ConcreteBuild2();

            // Contructor two Username

            director.Contruct(b1);
            UserName n1 = b1.GetResult();
            n1.Display();

            director.Contruct(b2);
            UserName n2 = b2.GetResult();
            n2.Display();

            Console.ReadLine();
        }
    }


}
