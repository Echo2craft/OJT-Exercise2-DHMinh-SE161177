using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Exercise2DangHoangMinhSE161177;

namespace Exercise2UnitTest
{
    [TestClass]
    public class Excercise2UnitTest
    {
        [TestMethod]
        public void TestDogs()
        {
            Dog dg = new Dog("Collie", "Korone", "Dog");
            Assert.AreEqual("Collie", dg.Animalbreed);
            Assert.AreEqual("Korone", dg.Animalname);
            Assert.AreEqual("Dog", dg.AnimalType);

            Dog dg2 = new Dog("Collie", "Korone", "Dog");
            Assert.AreEqual(dg.Animalbreed, dg2.Animalbreed);
            Assert.AreEqual(dg.Animalname, dg2.Animalname);
            Assert.AreEqual(dg.AnimalType, dg2.AnimalType);
            Assert.IsNotNull(dg);

            Dog dg3 = new Dog("Chihuahua", "Ceobe", "Dog");
            Assert.AreNotEqual(dg.Animalbreed, dg3.Animalbreed);
            Assert.AreNotEqual(dg.Animalname, dg3.Animalname);
            Assert.AreEqual(dg.AnimalType, dg3.AnimalType);

            Dog dg4 = new Dog("Spaniel", "Saga", "Dog");
            Assert.AreNotEqual(dg.Animalbreed, dg4.Animalbreed);
            Assert.AreNotEqual(dg.Animalname, dg4.Animalname);
            Assert.AreEqual(dg.AnimalType, dg4.AnimalType);
        }
        [TestMethod]
        public void TestCats()
        {
            Cat ct = new Cat("Tree", "Fauna", "Cat");
            Assert.AreEqual("Tree", ct.Animalclimb);
            Assert.AreEqual("Fauna", ct.Animalname);
            Assert.AreEqual("Cat", ct.AnimalType);

            Cat ct2 = new Cat("Tree", "Fauna", "Cat");
            Assert.AreEqual(ct.Animalclimb, ct2.Animalclimb);
            Assert.AreEqual(ct.Animalname, ct2.Animalname);
            Assert.AreEqual(ct.AnimalType, ct2.AnimalType);

            Cat ct3 = new Cat("Wall", "Shiro", "Cat");
            Assert.AreNotEqual(ct.Animalclimb, ct3.Animalclimb);
            Assert.AreNotEqual(ct.Animalname, ct3.Animalname);
            Assert.AreEqual(ct.AnimalType, ct3.AnimalType);

            Cat ct4 = new Cat("Roof", "Sakura", "Cat");
            Assert.AreNotEqual(ct.Animalclimb, ct4.Animalclimb);
            Assert.AreNotEqual(ct.Animalname, ct4.Animalname);
            Assert.AreEqual(ct.AnimalType, ct4.AnimalType);
        }
        [TestMethod]
        public void TestDucks()
        {
            Duck dk = new Duck("Pool", "Subaru", "Duck");
            Assert.AreEqual("Pool", dk.Animalswim);
            Assert.AreEqual("Subaru", dk.Animalname);
            Assert.AreEqual("Duck", dk.AnimalType);

            Duck dk2 = new Duck("Pool", "Subaru", "Duck");
            Assert.AreEqual(dk.Animalswim, dk2.Animalswim);
            Assert.AreEqual(dk.Animalname, dk2.Animalname);
            Assert.AreEqual(dk.AnimalType, dk2.AnimalType);

            Duck dk3 = new Duck("Lake", "Ducky", "Duck");
            Assert.AreNotEqual(dk.Animalswim, dk3.Animalswim);
            Assert.AreNotEqual(dk.Animalname, dk3.Animalname);
            Assert.AreEqual(dk.AnimalType, dk3.AnimalType);

            Duck dk4 = new Duck("Pond", "Donald", "Duck");
            Assert.AreNotEqual(dk.Animalswim, dk4.Animalswim);
            Assert.AreNotEqual(dk.Animalname, dk4.Animalname);
            Assert.AreEqual(dk.AnimalType, dk4.AnimalType);

        }
    }
}
