
namespace MathLibrary;

    /// <summary>
    /// يحتوي على دوال رياضيه بسيطه
    /// </summary>
    public static class Calculator
    {
        /// <summary>
        /// تحسب حاصل ضرب عددين
        /// </summary>
        /// <param name="a">العدد الأول</param>
        /// <param name="b">العدد الثاني</param>
        /// <returns>ناتج الضرب</returns>
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        /// <summary>
        /// تحسب حاصل قسمة عددين
        /// </summary>
        /// /// <param name="a">العدد الأول</param>
        /// <param name="b">العدد الثاني</param>
        /// <returns>ناتج القسمة</returns>
      public static int Divide(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException("Cannot divide by zero.");
            return a / b;
        }
         /// <summary>
        /// يتحقق مما إذا كان العدد زوجيًا
        /// </summary>
        /// <param name="a">العدد للتحقق</param>
        /// <returns>true إذا كان العدد زوجيًا، وإلا false</returns>

        public static bool IsEven(int a)
        {
            return a % 2 == 0;
        }
    }