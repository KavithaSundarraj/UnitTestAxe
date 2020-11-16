using System;
using NUnit.Framework;
using UnitTestAxe;

namespace UnitTestProject
{
   [TestFixture]
    public class UnitTest1
    {
        [Test]

        public void AxeLooseDurabilityAfterAttack()
        {
            //Arrange
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(10, 10);
            //Act
    
            axe.Attack(dummy);
            //Assert
            //Assert.AreEqual(9, axe.DurabilityPoints);
            Assert.That(axe.DurabilityPoints, Is.EqualTo(9),"Axe Durability does't change after attack ");
     
        }
        [Test]
        public void AttackingwithBrokenweapon()
        {
            //Arrange
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(0, 0);
            //Act
           
            axe.Attack(dummy);
            //Assert
           // Assert.AreEqual(10, axe.DurabilityPoints);
            Assert.That(axe.DurabilityPoints, Is.EqualTo(10), "Axe Durability remains same");

        }


    }
}
