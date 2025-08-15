public class Solution
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        int[] mergedArray = nums1.Concat(nums2).ToArray();
        MergeSort(mergedArray, 0, (nums1.Length + nums2.Length) - 1);

        if (mergedArray.Length % 2 != 0)
        {
            return mergedArray[mergedArray.Length / 2];
        }

        return (mergedArray[(mergedArray.Length - 1) / 2] + mergedArray[mergedArray.Length / 2]) / 2.0;
    }

    public void MergeSort(int[] array, int left, int right)
    {
        if (left < right)
        {
            int middle = (left + right) / 2;

            MergeSort(array, left, middle);

            MergeSort(array, middle + 1, right);

            Merge(array, left, right, middle);
        }
    }

    public void Merge(int[] array, int left, int right, int middle)
    {
        int length1 = middle - left + 1;
        int length2 = right - middle;

        int[] ar1 = new int[length1];
        int[] ar2 = new int[length2];

        for (int i = 0; i < length1; i++) ar1[i] = array[left + i];
        for (int j = 0; j < length2; j++) ar2[j] = array[middle + j + 1];

        int iIndex = 0, jIndex = 0, k = left;

        while (iIndex < length1 && jIndex < length2)
        {
            if (ar1[iIndex] <= ar2[jIndex])
            {
                array[k] = ar1[iIndex];
                iIndex++;
            }
            else
            {
                array[k] = ar2[jIndex];
                jIndex++;
            }
            k++;
        }
        while (iIndex < length1)
        {
            array[k] = ar1[iIndex];
            iIndex++;
            k++;
        }

        while (jIndex < length2)
        {
            array[k] = ar2[jIndex];
            jIndex++;
            k++;
        }
    }


}