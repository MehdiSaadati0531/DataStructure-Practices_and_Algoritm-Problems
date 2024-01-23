// See https://aka.ms/new-console-template for more information
using Double_Ended_Queue;

Console.WriteLine("Hello, World!");

Double_Ended_Queue_Array a = new(10);

a.EnQueueRear(1);
a.EnQueueRear(2);
a.EnQueueRear(3);

a.EnQueueFront(4);
a.EnQueueFront(5);
a.EnQueueFront(6);

a.DeQueueFront();
a.DeQueueFront();
a.DeQueueFront();
a.DeQueueFront();//error
a.DeQueueFront();//error
a.EnQueueFront(7);
a.DeQueueFront();
a.DeQueueFront();//error
a.DeQueueFront();//error
a.DeQueueFront();//error
a.DeQueueFront();//error

a.DeQueueRear();
a.DeQueueRear();
a.DeQueueRear();
a.EnQueueRear(8);
a.DeQueueRear();
a.DeQueueRear();//error
a.DeQueueRear();//error