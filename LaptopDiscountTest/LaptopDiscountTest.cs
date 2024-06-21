using LaptopDiscount;
using NUnit.Framework;
using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopDiscount_S4_Test
{
    public class LaptopDiscount_S4_test
    {
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
            var discount = new EmployeeDiscount(EmployeeType.PartialLoad, 100m);

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
            var discount = new EmployeeDiscount(EmployeeType.FullTime, 100m);

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
            var discount = new EmployeeDiscount(EmployeeType.CompanyPurchasing, 100m);

            //Act
            var actual = discount.CalculateDiscountedPrice();

            //Assert
            Assert.That(actual, Is.EqualTo(80));
        }

        // Test cases for CompanyPurchasing zero price scenario, should return 0 no matter the employee type is 
        [Test]
        public void Zero_CompanyPurchasing_price_discount()
        {
            //Arrange
            var discount = new EmployeeDiscount(EmployeeType.CompanyPurchasing, 0);

            //Act
            var actual = discount.CalculateDiscountedPrice();

            //Assert
            Assert.That(actual, Is.EqualTo(0));
        }

        // Test cases for parttime zero price scenario, should return 0 no matter the employee type is 
        [Test]
        public void Zero_parttime_price_discount()
        {
            //Arrange
            var discount = new EmployeeDiscount(EmployeeType.PartTime, 0);

            //Act
            var actual = discount.CalculateDiscountedPrice();

            //Assert
            Assert.That(actual, Is.EqualTo(0));
        }


    }
}
