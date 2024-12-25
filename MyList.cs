using System;

namespace MyCustomList

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

            if(Count >= Capacity)

            {

                Resize();

            }

 

            _array[Count] = elemnt;

            Count++;

        }

 

        public void Add(int[] elements)

        {

//Реализовать

        }

 

        public void Add(int index, int element)

        {

            //Реализовать

            //1, 2, 3, 5, 6, 7

            //Add(3, 4)

            //1, 2, 3, 4, 5, 6, 7

        }

 

        public void Add(int index, int[] elements)

        {

            //Реализовать

        }

 

        public int this[int index]

        {

            get

            {

                if(index >= Count || index < 0)

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

 

        private void Resize()

        {

            int newLength = _array.Length * 2;

            var newArray = new int[newLength];

 

            Array.Copy(_array, newArray, Count);

 

            _array = newArray;

        }

 

        private void Copy(int[] sourceArray, int[] destinationArray)

        {

            if(sourceArray.Length > destinationArray.Length)

            {

                throw new ArgumentException();

            }

 

            for(int i = 0; i < sourceArray.Length; i++)

            {

                destinationArray[i] = sourceArray[i];

            }

        }

    }

}