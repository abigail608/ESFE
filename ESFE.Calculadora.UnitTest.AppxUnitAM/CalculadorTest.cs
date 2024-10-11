using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESFE.Calculadora.UnitTest.AppxUnitAM
{
    public class CalculadorTest
    {
        [Fact]
        public void Add_ShouldReturnCorrectSum()
        {
            // Arrange 
            Calculador calculador = new Calculador();
            double num1 = 5.0;
            double num2 = 3.0;

            // Act
            double result = calculador.Add(num1, num2);

            // Assert
            Assert.Equal(8.0, result);
        }

        [Fact]
        public void Subtract_ShouldReturnCorrectDifference()
        {
            // Arrange
            Calculador calculador = new Calculador();
            double num1 = 8.0;
            double num2 = 3.0;

            // Act 
            double result = calculador.Subtract(num1, num2);

            // Assert
            Assert.Equal(5.0, result);
        }

        [Fact]
        public void Multiply_ShouldReturnCorrectProduct()
        {
            // Arrange
            Calculador calculador = new Calculador();
            double num1 = 4.0;
            double num2 = 2.0;

            // Act 
            double result = calculador.Multiply(num1, num2);

            // Assert
            Assert.Equal(8.0, result);
        }

        [Fact]
        public void Divide_ShouldReturnCorrectQuotient()
        {
            //  // Arrange
            Calculador calculador = new Calculador();
            double num1 = 10.0;
            double num2 = 2.0;

            // Act 
            double result = calculador.Divide(num1, num2);

            // Assert
            Assert.Equal(5.0, result);
        }

        [Fact]
        public void Divide_ByZero_ShouldThrowExection()
        {
            // Arrange 
            Calculador calculador = new Calculador();
            double num1 = 5.0;
            double num2 = 0.0;

            // Act and Assert
            Assert.Throws<ArgumentException>(() => calculador.Divide(num1, num2));
        }
    }
}
