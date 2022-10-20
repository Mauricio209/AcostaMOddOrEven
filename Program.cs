//Mauricio Acosta
//10-19-22
//GitHubChallange OddOrEven
//This code will be able to tell if the numbers 
//submitted are odd or even

Console.Clear();
string numOne;
int number =0, remainder;
//Console.WriteLine("Please enter a number");
//number = Convert.ToInt32(Console.ReadLine());
bool playagain = true;
while (playagain)
{
    bool isConverted = false;
    while (isConverted == false)
    {
        Console.WriteLine("Please enter a number");
        numOne = Console.ReadLine();
        isConverted = Int32.TryParse(numOne, out number);
        if (isConverted == false)
        {
            Console.WriteLine("Enter a valid number");
        }
    }




    remainder = number % 2;

    if (remainder == 0)
        Console.WriteLine("{0} is an even number", number);
    else
    {
        Console.WriteLine("{0} is an odd number", number);
    }
    Console.WriteLine("Type end to quit and press enter to reset");

    string reStart = Console.ReadLine();

    if (reStart == "quit")
    {


        playagain = false;
    }
    else
    {
        playagain = true;
    }


}
