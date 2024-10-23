﻿using Aula_09___QuickSort;

int[] values = [0, 12, 7, 1, 2, 8];

Console.WriteLine("Array: ");
Aula_09___QuickSort.QuickSort.Print<int>(values);

Aula_09___QuickSort.QuickSort.Sort<int>(values, 0, values.Length-1);

Console.WriteLine("Sorted with Quick: ");
Aula_09___QuickSort.QuickSort.Print(values);