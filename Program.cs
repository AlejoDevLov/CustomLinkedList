
using CustomLinkedList.Models;


var customLL = new CustomLinkedList<int>();
customLL.Add(8);
customLL.Add(2);
customLL.Add(1);
customLL.Add(5);
customLL.Add(5);
customLL.Add(10);
customLL.AddToFront(9);

int[] emptyArray = new int[10];
customLL.CopyTo(emptyArray, 3);
customLL.Contains(2);

Console.WriteLine(customLL.Contains(2));

customLL.Remove(8);

//foreach (var item in emptyArray)
//    Console.WriteLine(item);

foreach (var item  in customLL)
    Console.WriteLine(item);



Console.ReadKey();