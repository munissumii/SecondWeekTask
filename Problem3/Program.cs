int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

Console.WriteLine("Please, enter your number to check  whether it exist in an array" +
    "" +
    "" +
    "" +
    "");

int n = int.Parse(Console.ReadLine());

Console.WriteLine(arr.Contains(n));
