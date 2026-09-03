
using CustomLinkedList.Models;
using System.Collections;

namespace CustomLinkedList.Helpers;

internal class CustomLinkedListEnumerator<T> : IEnumerator<T> where T : notnull
{
    public Node<T>? CurrentNode { get; set; }
     
    private Node<T>? CurrentOriginalValue { get; set; }

    private bool IsFirstIteration = true;

    object IEnumerator.Current => CurrentNode!.Value;

    T IEnumerator<T>.Current => CurrentNode!.Value;

    public CustomLinkedListEnumerator(Node<T>? current)
    {
        CurrentNode = current;
        CurrentOriginalValue = current;
    }

    public bool MoveNext()
    {
        if(CurrentNode is null)
        {
            return false;
        }
        else if( CurrentNode is not null && IsFirstIteration )
        {
            IsFirstIteration = false;
            return true;
        }
        else if( CurrentNode!.NextNode is null )
        {
            return false;
        }
        else
        {
            CurrentNode = CurrentNode?.NextNode;
            return true;
        }
    }

    public void Reset()
    {
        CurrentNode = CurrentOriginalValue;
    }

    public void Dispose()
    {
        //throw new NotImplementedException();
    }

}
