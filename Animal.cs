using System;

namespace Exercise2DangHoangMinhSE161177
{
    abstract public class Animal
    {
        protected string animaltype;

        public abstract string AnimalType { get; set; }

        public abstract void makeSound();

        public abstract void getInfo();
    }
    public class Dog : Animal
    {
        private string animalbreed, animalname;

        public Dog() { }
        public Dog(string ab, string an, string at)
        {
            this.animalbreed = ab;this.animalname = an; this.animaltype = at;
        }

        public override string AnimalType
        {
            get
            {
                return animaltype;
            }
            set
            {
                animaltype = value;
            }
        }

        public string Animalbreed { get => animalbreed; set => animalbreed = value; }
        public string Animalname { get => animalname; set => animalname = value; }

        public override void makeSound()
        {
            Console.WriteLine("The " + animalname + " says : Woof Woof");
        }
        public override void getInfo()
        {
            Console.WriteLine(string.Format("Name : {0} \nType : {1} \nBreed : {2}", animalname, animaltype, animalbreed));
        }
    }
    public class Cat : Animal
    {
        private string animalname, animalclimb;
        public Cat() { }
        public Cat(string ac, string an, string at)
        {
            this.animalclimb = ac; this.animalname = an; this.animaltype = at;
        }
        public override string AnimalType
        {
            get
            {
                return animaltype;
            }
            set
            {
                animaltype = value;
            }
        }

        public string Animalname { get => animalname; set => animalname = value; }
        public string Animalclimb { get => animalclimb; set => animalclimb = value; }

        public override void makeSound()
        {
            Console.WriteLine("The " + animalname + " says : Meow Meow");
        }
        public override void getInfo()
        {
            Console.WriteLine(string.Format("Name : {0} \nType : {1}", animalname, animaltype));
        }
        public void CatClimb()
        {
            Console.WriteLine("The " + animalname + " climbs on the "+ animalclimb+".");
        }
    }
    public class Duck : Animal
    {
        private string animalname, animalswim;
        public override string AnimalType
        {
            get
            {
                return animaltype;
            }
            set
            {
                animaltype = value;
            }
        }
        public Duck() { }
        public Duck(string asw, string an, string at) 
        {
            this.animalswim = asw; this.animalname = an; this.animaltype = at;
        }
        public string Animalname { get => animalname; set => animalname = value; }
        public string Animalswim { get => animalswim; set => animalswim = value; }
        public override void makeSound()
        {
            Console.WriteLine("The " + animalname + " says : Quack Quack");
        }
        public override void getInfo()
        {
            Console.WriteLine(string.Format("Name : {0} \nType : {1}", animalname, animaltype));
        }
        public void DuckSwim()
        {
            Console.WriteLine("The " + animalname + " swims in the " + animalswim + ".");
        }
    }
    class MainProgram
    {
        static void Main(string[] args)
        {
            Dog dg = new Dog("Collie", "Korone", "Dog");
            dg.getInfo();
            dg.makeSound();
            Cat ct = new Cat("Tree", "Fauna", "Cat");
            ct.getInfo();
            ct.makeSound();
            ct.CatClimb();
            Duck dk = new Duck("Pool", "Subaru", "Duck");
            dk.getInfo();
            dk.makeSound();
            dk.DuckSwim();
        }
    }

}
