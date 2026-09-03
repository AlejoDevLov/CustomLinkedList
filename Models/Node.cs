
namespace CustomLinkedList.Models;

internal class Node<T> where T : notnull
{
    public T Value { get; }
    public Node<T>? NextNode;

    public Node(T value)
    {
        Value = value;
    }
}
