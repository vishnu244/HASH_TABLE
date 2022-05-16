﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HASH_TABLE
{
    public class HashMethods<K, V>
    {
        public int Size { get; set; }
        public int Count { get; set; }
        public LinkedList<keyValues<K, V>>[] items;
        public HashMethods(int size)
        {
            this.Size = size;
            this.items = new LinkedList<keyValues<K, V>>[size];

        }
        public void Add(K key, V value)
        {
            int position = GetArrayPosition(key);
            LinkedList<keyValues<K, V>> linkedlist = GetLinkedlist(position);
            keyValues<K, V> item = new keyValues<K, V>() { key = key, Value = value };
            linkedlist.AddLast(item);
        }
        public int GetArrayPosition(K key)
        {
            int position = key.GetHashCode() % Size;
            return Math.Abs(position);
        }
        public V GetValue(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<keyValues<K, V>> linkedlist = GetLinkedlist(position);
            foreach (keyValues<K, V> item in linkedlist)
            {
                if (item.key.Equals(key))
                {
                    return item.Value;
                }
            }
            return default(V);
        }
        public LinkedList<keyValues<K, V>> GetLinkedlist(int position)
        {
            LinkedList<keyValues<K, V>> linkedlist = items[position];
            if (linkedlist == null)
            {
                linkedlist = new LinkedList<keyValues<K, V>>();
                items[position] = linkedlist;
            }
            return linkedlist;
        }


        public void Display()
        {
            foreach (var linkedList in items)
            {
                if (linkedList != null)
                {
                    foreach (keyValues<K, V> keyvalue in linkedList)
                    {
                        Console.WriteLine(keyvalue.key + " --> " + keyvalue.Value);
                    }
                }
            }
        }
    }

    public struct keyValues<K, V>
    {
        public K key { get; set; }
        public V Value { get; set; }
    }
}
