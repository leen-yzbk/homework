
using Xunit;
using MathLibrary;

namespace MathLibrary.Tests
{
    ///<summary>
    /// تحتوي على اختبارات لدالة Multiply.
    /// </summary>
    public class CalculatorTests
    {
        [Fact]
        public void Multiply_TwoPositiveNumbers_ReturnsCorrectResult()
        {
            // Arrange 
            int a = 4, b = 5; 
            // Act
            int result = Calculator.Multiply(a, b);
            // Assert
            Assert.Equal(20, result);
        }

        [Fact]
        public void Multiply_NumberWithZero_ReturnsZero()
        {
            // Arrange
            int a = 0, b = 9; 
            // Act
            int result = Calculator.Multiply(a, b);
            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void Multiply_NegativeAndPositiveNumber_ReturnsNegative()
        {
            // Arrange
            int a = -4, b = 5;
            // Act
            int result = Calculator.Multiply(a, b);
            // Assert
            Assert.Equal(-20, result); 
        }

        [Fact]
        public void Multiply_TwoNegativeNumbers_ReturnsPositive()
        {
            // Arrange
            int a = -4, b = -7; 
            // Act
            int result = Calculator.Multiply(a, b);
            // Assert
            Assert.Equal(28, result); 
        }

        // تحتوي على اختبارات لدالة Divide
        [Fact]
        public void Divide_TwoPositiveNumbers_ReturnsCorrectResult()
        {
            // Arrange
            int a = 20, b = 4; 
            // Act
            int result = Calculator.Divide(a, b);
            // Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void Divide_NegativeAndPositive_ReturnsNegative()
        {
            // Arrange
            int a = -12, b = 4; 
            // Act
            int result = Calculator.Divide(a, b);
            // Assert
            Assert.Equal(-3, result);
        }

        [Fact]
        public void Divide_ByZero_ThrowsException()
        {
            // Arrange
            int a = 10, b = 0; 
            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => Calculator.Divide(a, b));
        }

        // تحتوي على اختبارات لدالة IsEven
        [Fact]
        public void IsEven_EvenNumber_ReturnsTrue()
        {
            // Arrange
            int a = 10;
                     // Act
            bool result = Calculator.IsEven(a);
            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsEven_OddNumber_ReturnsFalse()
        {
            // Arrange
            int a = 11; 
                        // Act
            bool result = Calculator.IsEven(a);
            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsEven_Zero_ReturnsTrue()
        {
            // Arrange
            int a = 0;
            // Act
            bool result = Calculator.IsEven(a);
            // Assert
            Assert.True(result);
        }
    }
}
