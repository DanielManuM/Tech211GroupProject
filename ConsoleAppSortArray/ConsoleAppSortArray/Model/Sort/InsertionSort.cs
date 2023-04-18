namespace ConsoleAppSortArray;

public class InsertionSort : SortType
{
    public override int[] Sort(int[] arr)
    {
        int i = 1;
        while (i < arr.Length)
        {
            int j = i;
            while (j > 0 && arr[j - 1] > arr[j])
            {
                (arr[j - 1], arr[i]) = (arr[i], arr[j - 1]);
                i = j - 1;
            }
            i++;
        }

        return arr;
    }
}
