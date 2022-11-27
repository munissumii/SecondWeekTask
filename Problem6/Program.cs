string input;

string empty = "";

 Console.WriteLine("Enter a string : ");

input = Console.ReadLine();

 for (int i = input.Length - 1; i >= 0; i--)
 {
    empty += input[i].ToString();
 }
if (empty == input)
{
    Console.WriteLine("String is Palindrome.  " + 
        "\nInput = {0} and Output= {1}", input, empty);
}
else
{
    Console.WriteLine("String is not Palindrome. " + 
        "\nInput = {0} and Output= {1}", input, empty);
}
    