using System;

class MainClass
{

    public static int FirstFactorial(int num)
    {
        // displays the factorial numbers of the int provided 
        // code goes here  
        int answer = 0;

        while (num < 0)
    {
            answer *= num;
            num--;
        }
        return answer.ToString();

    }

    static void Main()
    {

        // keep this function call here
        Console.WriteLine(FirstFactorial(Console.ReadLine()));

    }

}