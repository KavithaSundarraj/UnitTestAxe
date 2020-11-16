using NUnit.Framework;
using UnitTestAxe;


namespace UnitTestProject
{
    [TestFixture]
    public class UnitTest2
    {
        [Test]
        public void Dummyloseshealthiattacked()
        {
            //Arrange
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(10, 10);
            //Act

            axe.Attack(dummy);
            //Assert
            
            Assert.That(dummy.DummyHealth, Is.EqualTo(9), "Dummy loses health if attacked ");
        }
        [Test]
        public void DeadDummythrowsexceptionifattacked()
        {
            //Arrange
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(0, 0);
            //Act

            axe.Attack(dummy);
            //Assert
            
            Assert.That(dummy.DummyHealth, Is.EqualTo(0), "Dead Dummy throws exception ");
        }
        [Test]
        public void  DeadDummycangiveXP()
        {
            //Arrange
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(0, 10);
            //Act

            axe.Attack(dummy);
            //Assert
            
            Assert.That(dummy.DummyXP, Is.EqualTo(0), "Dead Dummy can give xp");
            //axe.DurabilityPoints
        }
        [Test]
        public void  AliveDummycantgiveXP()
        {
            //Arrange
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(0, 10);
            //Act

            axe.Attack(dummy);
            //Assert

            Assert.That(dummy.DummyXP, Is.EqualTo(10), "  Alive Dummy cant give XP");

        }
    }
}
