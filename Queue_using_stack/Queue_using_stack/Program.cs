// See https://aka.ms/new-console-template for more information
using Queue_using_stack;

Console.WriteLine("Hello, World!");


Implementation a = new Implementation(3);


a.EnQueue(1);
a.EnQueue(2);
a.EnQueue(3);
a.EnQueue(4);
Console.WriteLine("items");
a.PrintMembers();
Console.WriteLine("---------------");
a.DeQueue();
a.DeQueue();
a.DeQueue();
a.EnQueue(8);
Console.WriteLine("items");
a.PrintMembers();
Console.WriteLine("----------------");
a.DeQueue();
a.DeQueue();
a.DeQueue();
a.DeQueue();
