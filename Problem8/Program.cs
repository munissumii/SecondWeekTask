int[] arr = { 2, 4, 6, 7, 16, 9, 25, 70, 81, 35, 12, 49 };

for (int i = 0; i < arr.Length; i++)
{
    on_All((int)arr[i]);
}

void on_All(int i)
{

    if (Math.Sqrt(i) == (int)Math.Sqrt(i))
        Console.Write(i + " ");

}