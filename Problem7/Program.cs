int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int sum = 0;

for (int i = 0; i < arr.Length; i++)
{
    sum += arr[i];
}
Console.WriteLine("Sum with for loop is  " + sum);
sum = 0;


int k = 0;
while (k < arr.Length)
{
    sum += arr[k];
    k++;
}
Console.WriteLine("Sum with while loop is " + sum);


int findSum(int[] A, int N)
{
    if (N <= 0)
        return 0;
    return (findSum(A, N - 1) + A[N - 1]);
}

Console.Write($"Sum with function is {findSum(arr, arr.Length)}");