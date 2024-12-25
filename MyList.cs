namespace CustomList

{
    public class MyList

    {
        private int[] _array;


        public int Capacity { get; set; }


        public int Count { get; set; }


        public MyList()

        {
            _array = new int[2];

            Capacity = _array.Length;

            Count = 0;
        }


        public MyList(int length)

        {
            _array = new int[length];

            Capacity = length;

            Count = 0;
        }


        public MyList(int length, int element)

        {
            _array = new int[length];

            _array[0] = element;

            Capacity = length;

            Count = 1;
        }


        public void Add(int elemnt)

        {
            int added = 1;

            CheckSize(added);

            _array[Count] = elemnt;

            Count++;
        }


        public void Add(int[] elements)

        {
            foreach (int element in elements)
            {
                Add(element);
            }
            
        }


        public void Add(int index, int element)

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


        public void Add(int index, int[] elements)

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


        public int this[int index]
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

                    var newArray = new int[newLength];

                    Array.Copy(_array, newArray, Count);

                    _array = newArray;

                    Capacity = _array.Length;
                }
            }
        }

        private void Copy(int[] sourceArray, int[] destinationArray)

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