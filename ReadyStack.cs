using System;

public class ReadyStock<T>: IEnumerable<T>, IDisposable
{
    public int _top = 0;
    public int _size = 5;
    public T[] _stack = null;

    public setSize(int size)
    {
        _size = size;
    }

    
	public int getTop()
    {
            return _top;
    }

    public int  getSize()
    {
        return _size;
    }

    public bool isEmpty()
    {
        return _top == 0;
    }

    public bool push(T node)
    {
        if (!isEmpty)
        {
            _stack[_top] = nade;
            _top++;
            return ture;
        }else
        {
            return false;
        }
    }

    public T pop()
    {
        T node = default(T);
        if (!IsEmpty())
        {
            _top--;
            node = _stack[_top];
        }
        return node;
    }


}
