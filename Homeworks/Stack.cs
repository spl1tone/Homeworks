namespace Homeworks;

internal class Stack<T>
{
    private List<T> objects;

    public Stack () => objects = new();


    public void Push (T obj) => objects.Add(obj);

    public T Pop ()
    {
        if (objects.Count == 0) throw new IndexOutOfRangeException("IndexOutOfRangeException");
        T obj = objects[^1];
        objects.RemoveAt(objects.Count - 1);
        return obj;
    }

    public T Peek ()
    {
        if (objects.Count == 0) throw new IndexOutOfRangeException("IndexOutOfRangeException");
        return objects[^1];
    }

    public void CopyTo (ref T[] array)
    {
        Array.Resize(ref array, objects.Count);
        array = objects.ToArray();
    }

    public int Count () { return objects.Count; }


    public void Clear () => objects.Clear();
}
