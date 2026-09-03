
using CustomLinkedList.Helpers;
using CustomLinkedList.Interfaces;
using System.Collections;

namespace CustomLinkedList.Models;

internal class CustomLinkedList<T> : ILinkedList<T> where T : notnull
{
    private Node<T>? Head {  get; set; }
    private int _totalNodes = 0;
    

    public int Count => _totalNodes;

    public bool IsReadOnly => throw new NotImplementedException();

    public void Add(T item)
    {
        if(Head is null)
        {
            Head = new Node<T>(item);
            ++_totalNodes;
        }
        else
        {
            Node<T>? node = Head;

            while (node.NextNode is not null)
            {
                node = node.NextNode;
            }
            node.NextNode = new Node<T>(item);
            ++_totalNodes;
        }
    }

    public void AddToEnd(T item)
    {
        Add(item);
    }

    public void AddToFront(T item)
    {
        if( Head is null )
        {
            Head = new Node<T>(item);
        }
        else
        {
            var head = Head;
            Head = new Node<T>(item);
            Head.NextNode = head;
            ++_totalNodes;
        }
    }

    public void Clear()
    {
        Head = null;
        _totalNodes = 0;
    }

    public bool Contains(T item)
    {
        throw new NotImplementedException();
    }

    public void CopyTo(T[] array, int arrayIndex)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<T> GetEnumerator()
    {
        return new CustomLinkedListEnumerator<T>(Head);
    }

    public bool Remove(T item)
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

}
