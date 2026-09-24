

//Console.WriteLine("Hello, World!");

//decimal myDecimal = 10.5m;
//int myInt = (int)myDecimal; // Explicit casting from decimal to int
//Console.WriteLine(myInt);

//int myInt2 = 10;
//double myDouble = myInt2; // Implicit casting from int to double
//Console.WriteLine(myDouble);

//int myInt3 = (int)myDecimal + myInt; // Cast decimal to int before adding
//Console.WriteLine(myInt3);

//sbyte mySByte = 100;
//Console.WriteLine(mySByte);

//byte myByte = 200;
//Console.WriteLine(myByte);

//Asking a user for input and performing calculations
Console.WriteLine("Please enter a number: ");
// Read user input and convert it to a long integer
long userInput = Convert.ToInt64(Console.ReadLine());

//create a multiplier variable and assign it a value of 50
long multiplier = 50;
// Perform calculations using the user input and the multiplier
long result = userInput * multiplier;
// Display the result to the user
Console.WriteLine("The result is: " + result);

// Perform additional calculations with different data types
long secondMultiplier = 25;
// Perform calculations using the user input and the second multiplier
long secondResult = userInput + secondMultiplier;
// Display the second result to the user
Console.WriteLine("The second result is: " + secondResult);

// Perform calculations using the user input and a float multiplier
float thirdMultiplier = 12.5f;
// Perform calculations using the user input and the third multiplier
float thirdResult = userInput * thirdMultiplier;
// Display the third result to the user
Console.WriteLine("The third result is: " + thirdResult);

// Perform calculations using the user input and a double multiplier
double fourthMultiplier = 15.75;
// Perform calculations using the user input and the fourth multiplier
double fourthResult = userInput * fourthMultiplier;
// Display the fourth result to the user
Console.WriteLine("The fourth result is: " + fourthResult);

// Perform calculations using the user input and a boolean condition
bool isGreaterThan = userInput > multiplier;
// Display the boolean result to the user
Console.WriteLine("Is the user input greater than the multiplier? " + isGreaterThan);

// Perform calculations using the user input and a modulus operation
int modulusResult = (int)(userInput % 7);
// Display the modulus result to the user
Console.WriteLine("The modulus result is: " + modulusResult);
