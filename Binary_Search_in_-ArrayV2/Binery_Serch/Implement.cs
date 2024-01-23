namespace BinarySearch
{
    public class IterativeBinarySearch
    {
        int[] arr = new int[] { 10, 22, 32, 43, 53, 65, 73, 85 };
        int first;
        int last;
        int middle;

        public IterativeBinarySearch()
        {
            last = arr.Length - 1;
            first = 0;
            middle = (first + last) / 2;
        }

        public void BinarySearchs(int key)
        {
            while (true)
            {
                if (key == arr[middle])
                {
                    Console.WriteLine(arr[middle]);
                    return;
                }
                else if (last == first)
                {
                    Console.WriteLine("Item Not Found!");
                    return;
                }
                else if (key > arr[middle])
                {
                    first = middle + 1;
                    middle = (first + last) / 2;
                }
                else
                {
                    last = middle - 1;
                    middle = (first + last) / 2;
                }
            }
        }
    }

    public class RecursiveBinarySearch
    {
        int[] arr = new int[] { 10, 22, 32, 43, 53, 65, 73, 85 };
        public void BinarySearch(int key, int first, int last)
        {
            int middle = (first + last) / 2;
            if (arr[middle] == key)
            {
                Console.WriteLine(arr[middle]);
            }
            else if (first == last)
            {
                Console.WriteLine("Item Not Found");
            }
            else if (key > arr[middle])
            {
                BinarySearch(key, middle + 1, last);
            }
            else
            {
                BinarySearch(key, first, middle - 1);
            }
        }
    }
}

