// this program change A and B with a value C


//int a = 5;
//int b = 9;
//int c = a;

//a = b;
//c = b;

//System.Console.WriteLine("The value of A is: ", a);
//System.Console.WriteLine("The value of B is: " , b);

////////////// with user input

System.Console.Write("Enter A: ");
string astring = System.Console.ReadLine(); 
int firstNumber = System.Convert.ToInt32(astring);

System.Console.Write("Enter B: ");
string bstring = System.Console.ReadLine(); 
int secondNumber = System.Convert.ToInt32(bstring);

int c = 0;

c = firstNumber;
firstNumber = secondNumber;
secondNumber = c;

System.Console.WriteLine("Your swap value is " + firstNumber + " " + secondNumber);





