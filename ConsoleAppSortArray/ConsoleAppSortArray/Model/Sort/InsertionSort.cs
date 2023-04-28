namespace ConsoleAppSortArray;

public class InsertionSort : SortType
{
    public override string MethodName => "insertion sort";
    public override int[] Sort(int[] arr)
    {
        if (arr is null)
        {
            throw new ArgumentNullException(nameof(arr), "Input cannot be null.");
        };

        int i = 1;
        while (i < arr.Length)
        {
            int k = arr[i];
            int j = i - 1;
            while (j >= 0 && arr[j] > k)
            {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j + 1] = k;
            i++;
        }

        return arr;
    }
}