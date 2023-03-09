int[] array1 = { 4, 5, 9, 11, 15 };
int[] array2 = { 1, 5, 13, 15 };
for (int i = 0; array1.Length > i; i++)
{
    for(int j = 0; array2.Length > j; j++)
    {
        int difference = array1[i] - array2[j];
        if (difference == 0)
        {
            Console.WriteLine(array1[i]);
        }
    }
}


