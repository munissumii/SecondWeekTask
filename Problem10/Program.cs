string[] arr1 = { "a", "b", "c" };
string[] arr2 = { "1", "2", "3" };
string[] arr3 = new string[arr1.Length + arr2.Length];


int i = 0;
int j = 0;
int k = 0;

while (i < arr1.Length && j < arr2.Length)
{
    arr3[k] = arr1[i];
    k++;
    i++;
    arr3[k] = arr2[j];
    k++;
    j++;

}

for (int h = 0; h < arr1.Length + arr2.Length; h++)
    Console.Write(arr3[h] + " ");

