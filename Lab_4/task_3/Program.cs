using System;

class Turn
{
    private int[] elements;
    private int capacity;
    private int count;

    public Turn(int initialCapacity = 5)
    {
        capacity = initialCapacity;
        elements = new int[capacity];
        count = 0;
    }

    // Перевантаження оператора додавання елемента
    public static Turn operator +(Turn queue, int value)
    {
        if (queue.count == queue.capacity)
        {
            queue.Expand();
        }
        queue.elements[queue.count++] = value;
        return queue;
    }

    // Перевантаження оператора вилучення елемента
    public static Turn operator -(Turn queue, int value)
    {
        if (queue.count > 0)
        {
            for (int i = 0; i < queue.count; i++)
            {
                if (queue.elements[i] == value)
                {
                    for (int j = i; j < queue.count - 1; j++)
                    {
                        queue.elements[j] = queue.elements[j + 1];
                    }
                    queue.count--;
                    break;
                }
            }
        }
        return queue;
    }

    // Метод для розширення масиву при перевищенні ємності
    private void Expand()
    {
        capacity *= 2;
        int[] newElements = new int[capacity];
        Array.Copy(elements, newElements, count);
        elements = newElements;
    }

    // Метод для видалення кожного n-го елементу
    public void RemoveEveryNth(int n)
    {
        int i = n - 1;
        while (i < count)
        {
            for (int j = i; j < count - 1; j++)
            {
                elements[j] = elements[j + 1];
            }
            count--;
            i += n - 1;
        }
    }

    // Метод для відображення елементів черги
    public void Display()
    {
        for (int i = 0; i < count; i++)
        {
            Console.Write(elements[i] + " ");
        }
        Console.WriteLine();
    }

    public int GetCount()
    {
        return count;
    }

    public int GetElement(int index)
    {
        return elements[index];
    }
}

class Program
{
    static void Main(string[] args)
    {
        Turn[] queues = new Turn[3];
        Random rnd = new Random();

        for (int i = 0; i < queues.Length; i++)
        {
            queues[i] = new Turn();
            for (int j = 0; j < 10; j++)
            {
                queues[i] += rnd.Next(1, 101);
            }

            Console.WriteLine($"Черга {i + 1} пiсля додавання елементiв:");
            queues[i].Display();
        }

        queues[0].RemoveEveryNth(2);

        Console.WriteLine("Перша черга пiсля видалення кожного другого елементу:");
        queues[0].Display();
    }
}