#include "Heaps.h"
#include <iostream>


void PrintArray(int array[], int heap_size)
{
	for (int i = 0; i < heap_size; ++i)
		std::cout << array[i] << "\t";
	std::cout << "\n";
}

void MaxHeapify(int array[], int i, int heap_size)
{
	int larges = i;
	int l = 2 * i + 1;
	int r = 2 * i + 2; 
	if (l < heap_size && array[l] > array[larges])
	{
		larges = l;
	}
	if (r < heap_size && array[r] > array[larges])
	{
		larges = r;
	}
	if (larges != i)
	{
		int swap = array[i];
		array[i] = array[larges];
		array[larges] = swap;
		MaxHeapify(array, larges, heap_size);
	}
}


void HeapSort(int array[],int heap_size)

{
	for (int i = heap_size / 2 - 1; i >= 0; i--)
	{
		MaxHeapify(array, i, heap_size);
	}
	
	for (int i = heap_size - 1; i >= 0; i--)
	{
		int swap = array[0];
		array[0] = array[i];
		array[i] = swap;
		MaxHeapify(array,0,i);
	}
}



