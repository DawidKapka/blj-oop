using System;
using System.Collections.Generic;
using System.Text;

namespace A10
{
    public enum SortOrder
    {
        Ascending = 0,
        Descending = 1
    }

    public interface INumberSaver
    {
        void Add(int n);

        bool Contains(int n);

        String Get(SortOrder sortOrder);
        void Clear();
    }
}
