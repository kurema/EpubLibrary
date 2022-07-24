using System;
using System.Collections.Generic;
using System.Text;

namespace kurema.Epub.Helpers;

public static class Functions
{
    internal static void AddItemsToArray<T>(ref T[] array, T[] newItems) where T : class
    {
        if (array is null)
        {
            array = (T[])newItems.Clone();
            return;
        }
        int currentLength = array.Length;
        Array.Resize(ref array, currentLength + newItems.Length);
        for (int i = 0; i < newItems.Length; i++)
        {
            array[currentLength + i] = newItems[i];
        }
    }
}
