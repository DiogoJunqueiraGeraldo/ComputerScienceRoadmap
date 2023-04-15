// See https://aka.ms/new-console-template for more information


var linkedList = new DataStructures.Lists.SingleLinkedList<int>();

linkedList.Insert(1);
linkedList.Insert(2);
linkedList.Insert(3);
linkedList.Insert(4);
linkedList.Insert(5);


linkedList.InsertAt(1, 111);
linkedList.InsertAt(3, 222);
linkedList.InsertAt(8, 999);

linkedList.Reverse();

Console.WriteLine(linkedList);
