using NUnit.Framework;

namespace AddressBookLINQ
{
    public class Tests
    {
        AddressBook address = new AddressBook();

        [SetUp]
        public void Setup()
        {
            address = new AddressBook();
        }

        [Test]
        public void GivenInsertValues_returnInteger()
        {
            int expected = 2;
            int actual = address.AddValues();
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void GivenModifyValues_returnInteger()
        {
            int expected = 1;
            int actual = address.EditDataTable("Singh", "Firstname");
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void GivenDeleteQuery_returnInteger()
        {
            int expected = 0;
            int actual = address.DeleteRowInDataTable("lalita");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GivenRetrieveQuery_BasedOnCityandState_returnString()
        {
            string expected = "Rajvardhan Kshitij ";
            string actual = address.RetrieveBasedOnCityorState("Roorke", "UP");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GivenRetrieveCount_BasedOnCityandState_returnString()
        {
            string expected = "1 1 ";
            string actual = address.RetrieveCountBasedOnCityorState();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GivenSortQuery_BasedOnCityandState_returnString()
        {
            string expected = "Rajvardhan ";
            string actual = address.SortBasedOnNameInDataTable("Najibabad");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GivenCountQuery_BasedOnCityandState_returnString()
        {
            string expected = "1 1 ";
            string actual = address.RetrieveCountBasedOnType();
            Assert.AreEqual(expected, actual);
        }
    }
}