using System;



namespace Calculator
{
    public class Calc
    {
        

        public  int Add(int x, int y)
        {
            int result = 0;
            try
            {
                result = x + y;
            }

            catch (Exception e)
            {
                Console.WriteLine("Error" + e);

            }
            return result;



        }

        public  int Minus(int x, int y)
        {
            int result = 0;
            try
            {
                result = x - y;
            }

            catch (Exception e)
            {
                Console.WriteLine("Error" + e);

            }
            return result;
        }

        public  int Multiply(int x, int y)
        {
            int result = 0;
            try
            {
                result = x * y;
            }

            catch (Exception e)
            {
                Console.WriteLine("Error" + e);

            }
            return result;
        }

        public  int Divided(int x, int y)
        {
            int result = 0;
            try
            {
                result = x / y;
            }

            catch (Exception e)
            {
                Console.WriteLine("Error" + e);

            }
            return result;
        }
    }

}
