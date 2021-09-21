using System.Collections.Generic;
using System.Linq;

public class Sorter
{
    public Sorter()
    {
    }

    public void QuickSort(int[] input) {
        //partition step
        QuickSort(input, 0, input.Length - 1);
    }

    private void QuickSort(int[] input, int start, int end) {
        if (start < end) {
            int p = Partition(input, start, end);

            QuickSort(input, start, p - 1);
            QuickSort(input, p + 1, end);
        }
    }

    private int Partition(int[] input, int start, int end) {
        int endValue = input[end];
        int i = start - 1;
        for (int j = start; j <= end - 1; ++j) {
            if (input[j] <= endValue) {
                //else partition process starts
                i++;
                //swap
                var tmp = input[j];
                input[j] = input[i];
                input[i] = tmp;
            }
        }
        //swap
        input[end] = input[i + 1];
        input[i + 1] = endValue;

        return i + 1;
    }
}