namespace CustomList

{
    public class MyList<T>

    {
        private T[] _array;


        public int Capacity { get; set; }


        public int Count { get; set; }


        public MyList()

        {
            _array = new T[2];

            Capacity = _array.Length;

            Count = 0;
        }


        public MyList(int length)

        {
            _array = new T[length];

            Capacity = length;

            Count = 0;
        }


        public MyList(int length, T element)

        {
            _array = new T[length];

            _array[0] = element;

            Capacity = length;

            Count = 1;
        }


        public void Add(T elemnt)

        {
            int added = 1;

            CheckSize(added);

            _array[Count] = elemnt;

            Count++;
        }


        public void Add(T[] elements)

        {
            foreach (T element in elements)
            {
                Add(element);
            }
        }


        public void Add(int index, T element)

        {
            int added = 1;

            CheckSize(added);

            for (int i = Count - 1; i >= index; i--)
            {
                _array[i + added] = _array[i];
            }

            _array[index] = element;

            Count++;
            
        }


        public void Add(int index, T[] elements)

        {
            int added = elements.Length;


            CheckSize(added);

            for (int i = Count - 1; i >= index; i--)
            {
                _array[i + added] = _array[i];
            }

            for (int i = 0; i < elements.Length; i++)
            {
                _array[index + i] = elements[i];
                Count++;
            }
        }


        public T this[int index]
        {
            get

            {
                if (index >= Count || index < 0)

                {
                    throw new IndexOutOfRangeException();
                }


                return _array[index];
            }

            set

            {
                if (index >= Count || index < 0)

                {
                    throw new IndexOutOfRangeException();
                }


                _array[index] = value;
            }
        }


        // private void CheckSize()
        // {
        //     if(Count >= Capacity)
        //
        //     {
        //
        //         int newLength = _array.Length * 2;
        //
        //         var newArray = new int[newLength];
        //
        //
        //
        //         Array.Copy(_array, newArray, Count);
        //
        //
        //
        //         _array = newArray;
        //         
        //         Capacity = _array.Length;
        //     }
        //
        // }

        public void CheckSize(int addedLength)
        {
            if (Count + addedLength >= Capacity)
            {
                int newLength = _array.Length;
                int neededCapacity = Count + addedLength;

                while (Capacity < neededCapacity)
                {
                    newLength *= 2;

                    var newArray = new T[newLength];

                    Array.Copy(_array, newArray, Count);

                    _array = newArray;

                    Capacity = _array.Length;
                }
            }
        }

        private void Copy(T[] sourceArray, T[] destinationArray)

        {
            if (sourceArray.Length > destinationArray.Length)

            {
                throw new ArgumentException();
            }


            for (int i = 0; i < sourceArray.Length; i++)

            {
                destinationArray[i] = sourceArray[i];
            }
        }
    }
}