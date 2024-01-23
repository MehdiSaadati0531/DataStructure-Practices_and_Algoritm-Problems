// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine(N_kClass.N_K(4, 5));

public static class N_kClass
{
    public static int N_K(int n , int k) 
    {
        if (n == k || k == 0) return 1;
        
        return (N_K(n-1, k-1)+N_K(n-1, k));
    }
}