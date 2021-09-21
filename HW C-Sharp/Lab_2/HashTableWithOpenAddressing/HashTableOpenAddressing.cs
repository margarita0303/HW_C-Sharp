using System;
using System.Collections.Generic;

namespace HashTable
{
    
    /// Класс Item был написан в Lab_1/HashTableWithLinkedList/HashTableWithLinkedList.cs

    public class HashTableWithOpenAdressing<TK, TV>
    {
        private int _size;
        private int _maxSize;
        private Item<TK, TV>[] _items;
        
        public HashTableWithOpenAdressing(int maxSize = 256 - 1)
        {
            _size = 0;
            _maxSize = maxSize;
            _items = new Item<TK, TV>[_maxSize];
        }
        
        private int GetHash(TK key)
        {
            return key.GetHashCode() % _maxSize;
        }
        
        private int? FindPosition(TK key)
        {
            var hash = GetHash(key);
            for (var i = 0; i < _maxSize; i++)
            {
                if (_items[hash] == null)
                {
                    break;
                }
                if (!_items[hash].IsFictitious && _items[hash].Key.Equals(key))
                {
                    return hash;
                }
                hash = (hash + 1) % _maxSize;
            }
            return null;
        }


        public void Insert(TK key, TV value)
        {
            var hash = GetHash(key);
            var item = new Item<TK, TV>(key, value);
            while (true)
            {
                if (_items[hash] == null)
                {
                    break;
                }

                if (_items[hash].IsFictitious)
                {
                    break;
                }
                hash = (hash + 1) % _maxSize;
            }
            _items[hash] = item;
            _size += 1;
        }

        public TV Find(TK key)
        {
            var position = FindPosition(key);
            if (position == null)
            {
                throw new KeyNotFoundException();
            }
            return _items[(int)position].Value;
        }
        
        /// При удалении я не освобождаю ячейку, а помечаю ее фиктивной
        /// Таким образом, искать можно будет только до первого null
        public void Delete(TK key)
        {
            var position = FindPosition(key);
            if (position == null)
            {
                return;
            }
            _items[(int)position].IsFictitious = true;
        }
    }
}