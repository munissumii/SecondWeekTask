string[] arr1 = { "a", "b", "c" };
string[] arr2 = { "1", "2", "3" };

string[] arr3 = new string[arr1.Length + arr2.Length];

Array.Copy(arr1, arr3, arr1.Length);
Array.Copy(arr2, 0, arr3, arr1.Length, arr2.Length);

foreach (var a in arr3)
{
    Console.Write(a + " ");
}