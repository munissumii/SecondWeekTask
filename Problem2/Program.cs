using System.Drawing;

int[] arr = { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
Reverse(arr, 0, 8);

void Reverse(int[] arr, int a, int b)
{
    int temp;

    while (a < b)
    {
        temp = arr[a];
        arr[a] = arr[b];
        arr[b] = temp;
        a++;
        b--;
    }
}

for (int i = 0; i < arr.Length; i++)
    Console.Write(arr[i] + " ");

