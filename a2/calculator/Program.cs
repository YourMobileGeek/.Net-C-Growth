using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
	  
	  Console.WriteLine("//////////////////////////////////////////////");
	  Console.WriteLine("A2: Simple Calculator");
	  Console.WriteLine("Note: Program does not perform data validation");
	  Console.WriteLine("Author: Ariana M. Davis");

	  DateTime date = DateTime.Now;

	  Console.WriteLine("Date:" +date); 
	  Console.WriteLine("//////////////////////////////////////////////");
	  Console.WriteLine();
	
	  Console.Write("num1: ");
	  
	  double num1 = Convert.ToDouble(Console.ReadLine());

	  Console.Write("num2: ");
 
	  double num2 = Convert.ToDouble(Console.ReadLine());

	  Console.WriteLine('\n');
	  
	  Console.WriteLine(" 1 - Addition \n 2 - Subtraction \n 3 - Multiplication \n 4 - Division \n");
	  
	  Console.Write("Choose a mathematical operation: ");
	  int userInput = Convert.ToInt32(Console.ReadLine());
	  Console.WriteLine('\n');
	  double result = 0;

	  if (userInput > 4 || userInput < 1) {	
		Console.WriteLine("An incorrect mathematical operation was entered");
		
		Console.Write("num1: ");
	  
	    num1 = Convert.ToDouble(Console.ReadLine());

	  	Console.WriteLine();

	  	Console.Write("num2: ");
 
	  	num2 = Convert.ToDouble(Console.ReadLine());

	  	Console.WriteLine('\n');
	  
	  	Console.WriteLine(" 1 - Addition \n 2 - Subtraction \n 3 - Multiplication \n 4 - Division \n");
	  
	  	Console.Write("Choose a mathematical operation: ");
	  	userInput = Convert.ToInt32(Console.ReadLine());
	  	Console.WriteLine('\n');
	  	result = 0;


	  	switch(userInput){

		  case 1:
		    result = num1+num2;
		    Console.WriteLine(num1 + " + " + num2 + " = " + result);
		    break;
		
		  case 2:
		    result = num1-num2; 
		    Console.WriteLine(num1 + " - " + num2 + " = " + result);
		    break;

		  case 3: 
		    result = num1*num2;
		    Console.WriteLine(num1 + " * " + num2 + " = " + result);
		    break;

		  case 4:
		    while (num2 == 0){
			Console.WriteLine("Cannot divide by zero!");	
			Console.Write("\n num2: ");
			num2 = Convert.ToDouble(Console.ReadLine());
		    }
		    
		    	result = num1/num2; 
		    	Console.WriteLine("*** Result of division operation ***"); 
		    	Console.WriteLine(num1 + " / " + num2 + " = " + result);

		    break;

		}


		} 

	  else {

		switch(userInput){

		  case 1:
		    result = num1+num2;
		    Console.WriteLine(num1 + " + " + num2 + " = " + result);
		    break;
		
		  case 2:
		    result = num1-num2; 
		    Console.WriteLine(num1 + " - " + num2 + " = " + result);
		    break;

		  case 3: 
		    result = num1*num2;
		    Console.WriteLine(num1 + " * " + num2 + " = " + result);
		    break;

		  case 4:
		    while (num2 == 0){
			Console.WriteLine("Cannot divide by zero!");	
			Console.WriteLine("\n num2: ");
			num2 = Convert.ToDouble(Console.ReadLine());
		    }
		    
		    	result = num1/num2; 
		    	Console.WriteLine("*** Result of division operation ***"); 
		    	Console.WriteLine(num1 + " / " + num2 + " = " + result);

		    break;

		}


	  }

	  Console.Write("Press any key to exit!");
	  Console.ReadKey();

        }
    }
}
