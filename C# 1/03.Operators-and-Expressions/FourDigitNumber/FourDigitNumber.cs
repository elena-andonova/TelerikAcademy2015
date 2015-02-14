using System;


namespace FourDigitNumber
{
    class FourDigitNumber
    {
        static void Main()
        {
            int number = 9876;
            Console.WriteLine("The four digit number is {0}", number);
            int fourthNum = number % 10;
            int thirdNum = (number / 10) % 10;
            int secNum = (number / 100) % 10;
            int firstNum = (number / 1000) % 10;
            int sum = fourthNum + thirdNum + secNum + firstNum;
            Console.WriteLine("The sum of the four digits is: {0}", sum);
            Console.WriteLine("Printing the number in reverse order: {0}{1}{2}{3}",
                               fourthNum, thirdNum, secNum, firstNum);
            
            string strFirstNum = Convert.ToString(firstNum);
            string strSecNum = Convert.ToString(secNum);
            string strThirdNum = Convert.ToString(thirdNum);
            string strFourthNum = Convert.ToString(fourthNum);

            string putLastInFront = strFourthNum + strFirstNum + strSecNum + strThirdNum ;
            int putLastInFrontNum = Convert.ToInt32(putLastInFront);
            Console.WriteLine("Putting the last number in first position: {0}", putLastInFrontNum);

            string revSecThird = strFirstNum + strThirdNum + strSecNum + strFourthNum;
            int revSecThirdNum = Convert.ToInt32(revSecThird);
            Console.WriteLine("Exchanging the second and third digits: {0}", revSecThirdNum);
        }
    }
}
