using NUnit.Framework;

namespace PeopleProject.Tests
{

    [TestFixture]
    public class atlagEletkor
    {
        People people;
        int setupNumb;

        [SetUp]
        public void BasicNumbers()
        {
            people = new People();
            setupNumb = 3;

            for (int i = 0; i < 10; i++)
            {
                people.UjSzemely(setupNumb);
                setupNumb++;
            }
        }

        [Test]
        public void minMaxInvalid()
        {
            Assert.That(() => people.AtlagEletkor(100, 1), Throws.TypeOf<ArgumentException>());
        }

        [Test]
        public void ZeroObjectInList()
        {
            People emptyPeople = new People();
            Assert.That(() => emptyPeople.AtlagEletkor(1, 20), Throws.TypeOf<InvalidOperationException>());
        }

        [Test]
        public void Fine()
        {
            Assert.That(() => people.AtlagEletkor(1, 20), Is.EqualTo(75));
        }
    }
}
