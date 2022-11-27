int[] arr = {99, 22, 33, 111, 44, 55, 66 };

int MaxNumber()
{
    int max = arr[0];

    for(int i=1; i<arr.Length; i++)
    {
        if (arr[i] > max)
            max = arr[i];
    }
    return max;
}

Console.WriteLine(MaxNumber());