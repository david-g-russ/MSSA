using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Design a class hierarchy of your choice. (Need only class files ) 

// All classes placed in one file to simplify assignment turn-in, in real program classes would be separated to different files

namespace Assignment2._1._2
{
    abstract class Animal
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string Gender { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }
        public virtual string Class { get; set; }

        public void Eat() 
        {
            Console.WriteLine("I am eating");
        }
        
        public void Sleep() 
        {
            Console.WriteLine("I am sleeping");
        }

        public void Move() 
        {
            Console.WriteLine("I am moving");
        }

        public virtual void Communicate() 
        {
            Console.WriteLine("I am an animal");
        }
       
    } //base, abstract class

    class Mammal:Animal
    {
        public new string Class = "Animal";
        public string Order { get; set; }
        
        public override void Communicate()
        {
            Console.WriteLine("I am a mammal");
        }

    } // derived class level 1
    class Carnivora:Mammal
    {
        public new string Order = "Mammal";
        public string Suborder { get; set; }
        public override void Communicate()
        {
            Console.WriteLine("I am a carnivora");
        }
    } // derived class level 2
    class Feliformia:Carnivora
    {
        public new string Suborder = "Carnivora";
        public string Family { get; set; }
        public override void Communicate()
        {
            Console.WriteLine("I am a feliformia");
        }
    } // derived class level 3
    class Felidae : Feliformia
    {
        public new string Family = "Feliformia";
        public string Subfamily { get; set; }
        public override void Communicate()
        {
            Console.WriteLine("I am a felidae");
        }
    } // derived class level 4
    class Felinae : Felidae
    {
        public new string Subfamily = "Felidae";
        public string Genus { get; set; }
        public override void Communicate()
        {
            Console.WriteLine("I am a felinae");
        }
    } // derived class level 5
    class Felis : Felinae
    {
        public new string Genus = "Felis";
        public string Species { get; set; }
        public override void Communicate()
        {
            Console.WriteLine("I am a felis");
        }
    } // derived class level 6
    class Catus : Felis
    {
        public new string Species = "Catus";
        public string Subspecies { get; set; }
        public override void Communicate()
        {
            Console.WriteLine("I am a felis catus");
        }
        public void Pet()
        {
            Console.WriteLine("I am getting pets");
        }
        public new void Eat()
        {
            Console.WriteLine("I am eating cat food");
        }
    } // derived class level 7 (from felis)
    class Silvestris:Felis
    {
        public new string Species = "Silvestris";
        public string Subspecies { set; get; }
        public override void Communicate()
        {
            Console.WriteLine("I am a felis silvestris");
        }
        public void Hunt()
        {
            Console.WriteLine("I am hunting for food");
        }
        public new void Eat()
        {
            Console.WriteLine("I am eating rodents");
        }
    } // derived class level 7 (from felis)
    class Leopardus : Felinae
    {
        public new string Genus = "Leopardus";
        public string Species { set; get; }
        public override void Communicate()
        {
            Console.WriteLine("I am a leopardus");
        }
    } // derived class level 6
    class Pardalis:Leopardus
    {
        public new string Species = "Pardalis";
        public string Subspecies { get; set; }
        public override void Communicate()
        {
            Console.WriteLine("I am a leopardus pardalis");
        }
        public void Poach()
        {
            Console.WriteLine("I am trying to avoid poachers that want my skin");
        }
        public new void Eat()
        {
            Console.WriteLine("I am eating reptiles");
        }
    } // derived class level 7 (from leopardus)
    class Prionailurus : Felinae
    {
        public new string Genus = "Prionailurus";
        public string Species { get; set; }
        public override void Communicate()
        {
            Console.WriteLine("I am a prionailurus");
        }
    } // derived class level 6
    class Viverrinus : Prionailurus
    {
        public new string Species = "Viverrinus";
        public string Subspecies { get; set; }
        public override void Communicate()
        {
            Console.WriteLine("I am a prionailurus viverrinus");
        }
        public void Fish()
        {
            Console.WriteLine("I am fishing for my food");
        }
        public new void Eat()
        {
            Console.WriteLine("I am eating fish");
        }
    } // derived class level 7 (from prionailurus)
}