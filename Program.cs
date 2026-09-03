
using CustomLinkedList.Models;


var customLL = new CustomLinkedList<int>();
customLL.Add(8);
customLL.Add(2);
customLL.Add(1);
customLL.Add(5);
customLL.Add(5);
customLL.Add(10);
customLL.AddToFront(9);


IEnumerable<int> somethind = [];

foreach (var item in customLL)
    Console.WriteLine(item);



Console.ReadKey();