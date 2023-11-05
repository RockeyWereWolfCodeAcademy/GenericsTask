namespace CustomCollectionsGeneric
{
    public class CustomList<T>
    {
        T[] _array;
        int _count;
        const int DefaultCapacity = 5;
        public int Count { get => _count; }
        public int Capacity { get => _array.Length; 
            set
            {
                if (value < _count)
                {
                    throw new ArgumentOutOfRangeException();
                }
                if (value > 0)
                {
                    _array = new T[value];
                    T[] tempArray = new T[value];
                    if (_count > 0)
                    {
                        Array.Copy(_array, tempArray, _count);
                    }
                    _array = tempArray;
                }
                else
                {
                    _array = new T[value];
                }
                
            } 
        }

        public CustomList()
        {
            _array = new T[0];
        }

        public CustomList(int size)
        {
            if (size < 0)
                throw new ArgumentOutOfRangeException("Size must be positive");
            Capacity = size == 0 ? DefaultCapacity : size;
            //_array = new T[Capacity];    
        }

        public CustomList(params T[] array)
        {
            int size = array.Length;
            Capacity = size == 0 ? DefaultCapacity : size;
            _count = size;
            //_array = new T[Capacity];
            Array.Copy(array, _array, size);
        }

        public T this[int index]
        {
            get
            {
                if (index < 0) throw new IndexOutOfRangeException("Index cannot be negative");
                if (index > Count) throw new IndexOutOfRangeException("Index cannot be bigger than elements count");
                return _array[index];
            }
            set
            {
                if (index < 0) throw new IndexOutOfRangeException("Index cannot be  negative");
                if (index > Count) throw new IndexOutOfRangeException("Index cannot be bigger than elements count");
                _array[index] = value;
            }
        }

        public void Add(T item)
        { 
            if (_count == Capacity)
            {
                Array.Resize(ref _array, _count + Capacity);
            }
            _array[_count++] = item;
        }

        public void Clear()
        {
            _array = new T[DefaultCapacity];
            //Capacity = 0;
            _count = 0;
        }
        public bool Exist(T item)
        {
            foreach (var element in _array)
            {
                if (element.Equals(item))
                {
                    return true;
                }
            }
            return false;
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i].Equals(item)) // Use custom equality logic if needed
                {
                    return i;
                }
            }
            return -1;
        }

        public int LastIndexOf(T item)
        {
            for (int i = _array.Length - 1; i >= 0; i--)
            {
                if (_array[i].Equals(item)) // Use custom equality logic if needed
                {
                    return i;
                }
            }
            return -1;
        }

        public bool Remove(T item)
        {
            int index = IndexOf(item);
            if (index >= 0)
            {
                for (int i = index; i < _array.Length - 1; i++)
                {
                    _array[i] = _array[i + 1];
                }
                Array.Resize(ref _array, _array.Length - 1);
                return true;
            }

            return false;
        }

        public void Reverse()
        {
            int left = 0;
            int right = _count - 1;
            while (left < right)
            {
                T temp = _array[left];
                _array[left] = _array[right];
                _array[right] = temp;
                left++;
                right--;
            }
        }
    }
}