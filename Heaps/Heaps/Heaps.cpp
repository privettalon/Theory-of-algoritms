#include "Heaps.h"
#include <iostream>

int Parent(int i)
{
	if (i == 0)
		return 0;
	else
		return (i)/2;
}

int Left(int i)
{
	return 2*i+1;
}

int Right(int i)
{
	return 2*i+2;
}

void PrintArray(int array[], int heap_size)
{
	for (int i = 0; i < heap_size; ++i)
		std::cout << array[i] << " ";
	std::cout << "\n";
}

void MaxHeapify(int array[], int i, int heap_size)
{
	int larges=i;
	int l = Left(i);
	int	r = Right(i);
	if (l <= heap_size && array[l] > array[i])
	{
		larges = l;
	}
	if (r <= heap_size && array[r] > array[i])
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
	for (int i = heap_size-1 ; i >= 0; i--)
	{
		int swap = array[0];
		array[0] = array[i];
		array[i] = swap;

		MaxHeapify(array, i,heap_size);
	}
}

int HeapMax(int array[], int heap_size)
{
	HeapSort(array, heap_size);
	return array[0];
}

int HeapExtractMax(int array[], int heap_size)
{
	if (heap_size < 1)
	{
		return -10;
	}
	int max = array[0];
	array[0] = array[heap_size];
	heap_size--;
	MaxHeapify(array ,1 , heap_size);
	return max;
}

void HeapIncreaseKey(int array[], int i, int key)
{
	if (array[i] > key)
	{
		std::cout <<"The new key is less than the current one";
	}
	else
	{
		array[i] = key;
		while (i > 1 && array[Parent(i)] < array[i])
		{
			int swap = array[i];
			array[i] = array[Parent(i)];
			array[Parent(i)] = swap;

		}
		i = Parent(i);
	}
}
