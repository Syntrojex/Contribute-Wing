using System;

class Array
{
    private int[] arr;
    private int size;
    private int capacity;

    // Check if array is full
    private bool IsFull()
    {
        if (size == capacity)
        {
            return true;
        }

        return false;
    }

    // Regrow array
    private void Regrow()
    {
        int[] newArr = new int[capacity * 2];

        for (int i = 0; i < size; i++)
        {
            newArr[i] = arr[i];
        }

        arr = newArr;
        capacity = capacity * 2;
    }

    // Shifting
    private void ShiftRight(int fromIndex)
    {
        for (int i = size - 1; i >= fromIndex; i--)
        {
            arr[i + 1] = arr[i];
        }
    }

    private void ShiftLeft(int fromIndex)
    {
        for (int i = fromIndex; i < size - 1; i++)
        {
            arr[i] = arr[i + 1];
        }
    }

    // Default Constructor
    public Array()
    {
        capacity = 2;
        arr = new int[capacity];
        size = 0;
    }

    // Parameterized Constructor
    public Array(int capacity)
    {
        if (capacity <= 0)
        {
            capacity = 2;
        }

        this.capacity = capacity;
        arr = new int[capacity];
        size = 0;
    }

    // Insertion at Start
    public void InsertAtStart(int value)
    {
        if (IsFull())
        {
            Regrow();
        }

        if (size > 0)
        {
            ShiftRight(0);
        }

        arr[0] = value;
        size++;
    }

    // Insertion at Index
    public void InsertAtIndex(int value, int index)
    {
        if (index < 0 || index > size)
        {
            Console.WriteLine("Invalid Index!");
            return;
        }

        if (IsFull())
        {
            Regrow();
        }

        if (index < size)
        {
            ShiftRight(index);
        }

        arr[index] = value;
        size++;
    }

    // Insertion at End
    public void InsertAtEnd(int value)
    {
        if (IsFull())
        {
            Regrow();
        }

        arr[size] = value;
        size++;
    }

    // Deletion from Start
    public void DeleteFromStart()
    {
        if (size == 0)
        {
            Console.WriteLine("Array is Empty!");
            return;
        }

        ShiftLeft(0);
        size--;
    }

    // Deletion from Index
    public void DeleteFromIndex(int index)
    {
        if (index < 0 || index >= size)
        {
            Console.WriteLine("Invalid Index!");
            return;
        }

        ShiftLeft(index);
        size--;
    }

    // Deletion from End
    public void DeleteFromEnd()
    {
        if (size == 0)
        {
            Console.WriteLine("Array is Empty!");
            return;
        }

        size--;
    }

    // Update at Start
    public void UpdateAtStart(int value)
    {
        if (size == 0)
        {
            Console.WriteLine("Array is Empty!");
            return;
        }

        arr[0] = value;
    }

    // Update at Index
    public void UpdateAtIndex(int index, int value)
    {
        if (index < 0 || index >= size)
        {
            Console.WriteLine("Invalid Index!");
            return;
        }

        arr[index] = value;
    }

    // Update at End
    public void UpdateAtEnd(int value)
    {
        if (size == 0)
        {
            Console.WriteLine("Array is Empty!");
            return;
        }

        arr[size - 1] = value;
    }

    // Reverse Array
    public void Reverse(int start, int end)
    {
        while (start < end)
        {
            int temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;

            start++;
            end--;
        }
    }

    // Rotate Right
    public void RotateRight(int k)
    {
        if (size <= 1)
        {
            return;
        }

        k = k % size;

        Reverse(0, size - 1);
        Reverse(0, k - 1);
        Reverse(k, size - 1);
    }

    // Rotate Left
    public void RotateLeft(int k)
    {
        if (size <= 1)
        {
            return;
        }

        k = k % size;

        Reverse(0, k - 1);
        Reverse(k, size - 1);
        Reverse(0, size - 1);
    }

    // Display
    public void Display()
    {
        if (size > 0)
        {
            Console.Write("\nArray is: [");

            for (int i = 0; i < size; i++)
            {
                Console.Write(arr[i]);

                if (i != size - 1)
                {
                    Console.Write(",");
                }
            }

            Console.WriteLine("]");
        }
        else
        {
            Console.WriteLine("Array is Empty!!");
        }
    }
}


class Program
{
    static void Main()
    {
        Array arr1 = new Array(10);

        arr1.Display();

        // Insertion
        Console.WriteLine();
        Console.WriteLine("Insertion:");

        arr1.InsertAtStart(10);
        arr1.InsertAtStart(20);
        arr1.InsertAtEnd(30);

        arr1.Display();

        arr1.InsertAtIndex(15, 1);

        arr1.Display();

        // Deletion
        Console.WriteLine();
        Console.WriteLine("Deletion:");

        arr1.DeleteFromStart();
        arr1.Display();

        arr1.DeleteFromIndex(1);
        arr1.Display();

        arr1.DeleteFromEnd();
        arr1.Display();

        // Update
        Console.WriteLine();
        Console.WriteLine("Updation:");

        arr1.UpdateAtStart(100);
        arr1.Display();

        arr1.UpdateAtIndex(0, 200);
        arr1.Display();

        arr1.UpdateAtEnd(300);
        arr1.Display();

        // Rotation
        Console.WriteLine();
        Console.WriteLine("Rotation:");

        arr1.RotateRight(1);
        arr1.Display();

        arr1.RotateLeft(1);
        arr1.Display();
    }
}
