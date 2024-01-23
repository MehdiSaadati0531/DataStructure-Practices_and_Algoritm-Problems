// See https://aka.ms/new-console-template for more information
using Test;


Queue a = new(3);

a.EnQueue(1);
a.EnQueue(2);
a.EnQueue(3);
Console.WriteLine("Items :");
a.PrintMember();
Console.WriteLine("--------------------");

a.DeQueue();
a.DeQueue();
a.DeQueue();
Console.WriteLine("Items :");
a.PrintMember();
Console.WriteLine("--------------------");

a.EnQueue(4);
a.EnQueue(5);
a.EnQueue(6);
Console.WriteLine("Items :");
a.PrintMember();
Console.WriteLine("--------------------");

a.EnQueue(7);   