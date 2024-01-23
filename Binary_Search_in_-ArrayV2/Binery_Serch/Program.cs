using BinarySearch;

IterativeBinarySearch a = new IterativeBinarySearch();
RecursiveBinarySearch b = new RecursiveBinarySearch();
int key;
do
{
    key = int.Parse(Console.ReadLine());
    Console.WriteLine("**************************");
    a.BinarySearchs(key);

} while (key != -50);
do
{
    key = int.Parse(Console.ReadLine());
    Console.WriteLine("-------------------------");
    b.BinarySearch(key, 0, 7);

} while (key != -50);