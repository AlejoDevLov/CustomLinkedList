
using CustomLinkedList.Models;
using System.Collections;

namespace CustomLinkedList.Helpers;

internal class CustomLinkedListEnumerator<T> : IEnumerator<T> where T : notnull
{
    public Node<T>? Current { get; private set; }
     
    private Node<T>? CurrentOriginalValue { get; set; }

    private bool IsFirstIteration = true;

    object IEnumerator.Current => Current!.Value;

    T IEnumerator<T>.Current => Current!.Value;

    public CustomLinkedListEnumerator(Node<T>? current)
    {
        Current = current;
        CurrentOriginalValue = current;
    }

    public bool MoveNext()
    {
        if(Current is null)
        {
            return false;
        }
        else if( Current is not null && IsFirstIteration )
        {
            IsFirstIteration = false;
            return true;
        }
        else if( Current!.NextNode is null )
        {
            return false;
        }
        else
        {
            Current = Current?.NextNode;
            return true;
        }
    }

    public void Reset()
    {
        Current = CurrentOriginalValue;
    }

    public void Dispose()
    {
        //throw new NotImplementedException();
    }
}
