using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;

namespace ArrayBasedQueue
{
    class ArrayBasedQueue<T>
    {
        private int Head, Tail;

        private T[] Data;
        public int Count { get; private set; }

        private const int DefaultCapacity = 10;
        public ArrayBasedQueue(int capacity = 10)
        {
            Count = 0;
            if (capacity < DefaultCapacity)
            {
                capacity = DefaultCapacity;
            }
            Data = new T[capacity];
        }
        public void Enqueue(T Value)
        {
            if (IsArrayEmpty())
            {
                throw new QueueArrayEmptyException("Queue is Empty");

            }
            Count++;

            Data[Count] = Value;
        }

        public T Dequeue()
        {

            if (IsArrayEmpty())
            {
                throw new QueueArrayEmptyException("Queue is Empty");
            }

            Count--;

            // what happens when head surpasses tail?

            if(Head== Data.Length)
            {
                Head = 0;
                Tail = 0;
                throw new QueueArrayEmptyException("cannont remove anymore items!");
            }

            T TempArray = Data[Head];
            Head++;

            return TempArray;
        }

        public T Peek()
        {
            return Data[Head];
        }
        private void Resize(int size)
        {
            T[] TempArray = new T[size];


            for (int i = 0; i < Count; i++)
            {
                TempArray[i] = Data[i];
            }
            Data = TempArray;
        }
        public bool IsArrayEmpty()
        {
            return Data.Length == 0;
            //int x = 0;


            //string greeting = x == 0 ? "morning" : "gnite";
        }


    }

    public class QueueArrayEmptyException : Exception
    {
        public QueueArrayEmptyException(string msg) : base(msg)
        {

        }
    }
}
