using LaptopDiscount;

namespace LaptopDiscount_S4_Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        //[Test]
        //public void Test1()
        //{

           
        //    Assert.Pass();
        //}

        //Test cases for PartTime scenario

        [Test]
        public void PartTime_discount()
        {
            //Arrange
            var discount = new EmployeeDiscount(EmployeeType.PartTime, 100);

            //Act
            var actual = discount.CalculateDiscountedPrice();

            //Assert
            Assert.That(actual, Is.EqualTo(100));
        }

        //Test cases for PartialLoad scenario

        [Test]
        public void PartialLoad_discount()
        {
            //Arrange
            var discount = new EmployeeDiscount(EmployeeType.PartTime, 100);

            //Act
            var actual = discount.CalculateDiscountedPrice();

            //Assert
            Assert.That(actual, Is.EqualTo(95));
        }

        //Test cases for FullTime scenario
        [Test]
        public void FullTime_discount()
        {
            //Arrange
            var discount = new EmployeeDiscount(EmployeeType.PartTime, 100);

            //Act
            var actual = discount.CalculateDiscountedPrice();

            //Assert
            Assert.That(actual, Is.EqualTo(90));
        }

        // Test cases for CompanyPurchasing scenario
        [Test]
        public void CompanyPurchasing_discount()
        {
            //Arrange
            var discount = new EmployeeDiscount(EmployeeType.PartTime, 100);

            //Act
            var actual = discount.CalculateDiscountedPrice();

            //Assert
            Assert.That(actual, Is.EqualTo(80));
        }
    }
}