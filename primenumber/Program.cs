
using System.Numerics;

var mAAService = new MAAService();
while (true)
{
    try
    {
        Console.WriteLine("Please Enter prime number");
        var input = Console.ReadLine();
        //ถ้ากรอกตัวหนังสือมาจะเข้า catch เพราะระบบ convert string เป็น int ไม่ได้
        await mAAService.GetPrimeOrNonPrimeNumber(Convert.ToInt32(input));
    }
    catch (System.Exception ex)
    {
        Console.WriteLine("Error");
    }
}



public class MAAService
{
    public async Task GetPrimeOrNonPrimeNumber(BigInteger primeNumber)
    {
        string mesPrimeNumber = "prime number";
        string mesNonPrimeNumber = "number";
        for (int i = 1; i < primeNumber; i++)
        {
            var result = IsPrimeNumber(i);
            if (result)
            {
                mesPrimeNumber += $",{i}";
            }
            else
            {
                 mesNonPrimeNumber += $",{i}";
            }
        }
        Console.WriteLine(mesPrimeNumber);
        Console.WriteLine(mesNonPrimeNumber);
    }

    private static  bool IsPrimeNumber(int number)
    {
       if (number <= 1)
        {
            return false;
        }

        //เริ่มที่ 2 เพราะว่า 1 ไม่ใช่จำนวนเฉพาะ   
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
             //จำนวนเฉพาะคือ จำนวนที่หารด้วย 1 กับตัวมันเองลงตัวเท่านั้น
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}