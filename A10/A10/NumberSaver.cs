using System;
using System.Collections.Generic;
using System.Text;

namespace A10
{
    class NumberSaver : INumberSaver
    {
        internal class Elem
        {
            internal Elem next;
            internal Elem previous;
            internal int number = 0;
        }

        Elem _first;
        Elem _last;
        public void Add(int n)
        {
            Elem newElem = new Elem();
            newElem.number = n;

            if (_first == null)
            {
                _first = newElem;
                _last = _first;
            }
            else
            {
                Elem elem = _first;
                while (elem != null)
                {
                    if (newElem.number < elem.number)
                    {
                        break;
                    }
                    elem = elem.next;
                }
                if (elem == _first)
                {
                    newElem.next = _first;
                    _first.previous = newElem;
                    _first = newElem;
                }
                else if (elem == null)
                {
                    newElem.previous = _last;
                    _last.next = newElem;
                    _last = newElem;
                }
                else
                {
                    newElem.next = elem;
                    newElem.previous = elem.previous;
                    elem.previous.next = newElem;
                    elem.previous = newElem;
                }
            }
        }
        public bool Contains(int n)
        {
            Elem el = _first;
            while (el != null)
            {
                if (el.number == n)
                {
                    return true;
                }
                el = el.next;
            }
            return false;
        }
        public String Get(SortOrder sortOrder)
        {
            String result = "";
            if (sortOrder == SortOrder.Ascending)
            {
                Elem elem = _first;
                while (elem != null)
                {
                    result += elem.number + ", ";
                    elem = elem.next;
                }
            }
            else
            {
                Elem elem = _last;
                while (elem != null)
                {
                    result += elem.number + ", ";
                    elem = elem.previous;
                }
            }
            result.Remove(result.Length - 2);
            return result;
        }
        public void Clear()
        {
            _first = null;
            _last = null;
        }

    }
}
