using System;  
public class PalindromeNumber
{  
    public static void Main()
{
    int num,r,sum=0,t,rev;
	
    Console.WriteLine("\n Check whether a number is a palindrome or not:\n");
    Console.WriteLine("Input a number: ");
    num = Convert.ToInt32(Console.ReadLine()); 	
	    
    rev = num/10;
    for(t=num;num!=0;rev)
    {
         r=num % 10;
         sum=sum*10+r;
    }
    if(t==sum)
    {
         Console.WriteLine("{0} is a palindrome number.\n",t);
    }
    else
    {
         Console.WriteLine("{0} is not a palindrome number.\n",t);
    }

    }	 
}
