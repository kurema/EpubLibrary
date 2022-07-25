using System;
using System.Collections.Generic;
using System.Text;

[assembly:System.Runtime.CompilerServices.InternalsVisibleTo("TestProject")]

namespace kurema.Epub.Helpers;

#nullable enable
public static partial class Functions
{

    
    internal static void AddItemsToArray<T>(
#if NET6_0_OR_GREATER
        [System.Diagnostics.CodeAnalysis.NotNull] 
#endif
        ref T[]? array, params T[] newItems) where T : class
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
