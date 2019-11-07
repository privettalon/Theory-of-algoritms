#include "Heaps.h"
#include <iostream>


void PrintArray(int array[], int heap_size)
{
	for (int i = 0; i < heap_size; ++i)
		std::cout << array[i] << "\t";
	std::cout << "\n\n";

}

void MaxHeapify(int array[], int i, int heap_size)
{
	int larges = i;
	int l = 2 * i + 1;//лівий нащадок;
	int r = 2 * i + 2; // правий нащадок;
	if (l < heap_size && array[l] > array[larges])// якщо лівий нащаок більший за корінь
	{
		larges = l;
	}
	if (r < heap_size && array[r] > array[larges])// якщо правий нащодок більший за корінь
	{
		larges = r;
	}
	if (larges != i)//якщо корінь змінився ;
	{
		int swap = array[i];
		array[i] = array[larges];
		array[larges] = swap;
		MaxHeapify(array, larges, heap_size);// знову рекурсивно викликаємо функцію;
	}
}




void HeapSort(int array[],int heap_size)

{

	BuildMaxHeap(array, heap_size);

	for (int i = heap_size - 1; i >= 0; i--)// цикл для сортування масиву;
	{
		int swap = array[0];
		array[0] = array[i];
		array[i] = swap;
		MaxHeapify(array,0,i);
	}
}

void DeleteMax(int array[], int& heap_size)
{ 
	BuildMaxHeap(array, heap_size);

	int swap = array[0];
	array[0] = array[heap_size - 1];
	heap_size--;
	BuildMaxHeap(array, heap_size);
	PrintArray(array, heap_size);
}

void ShowMax(int array[], int heap_size)
{
	BuildMaxHeap(array, heap_size);
	std::cout << array[0];
}

void BuildMaxHeap(int array[], int heap_size)
{
	
	{
		for (int i = heap_size/2-1 ; i >= 0; i--)//Цикл для побудови піраміди саксимальеих значень;
		{
			MaxHeapify(array, i, heap_size);
		}
	
	}
	
}

void HeapSwapKey(int array[], int n, int key, int heap_size)
{
	int parrent = n / 2-1 ;
	if (key < array[n])
	{
		std::cout << "The new key is smaller than the current key." << std::endl;
	}
	
		array[n] = key;
		while (n > 0 && array[parrent] < array[n])
		{
			int swap = array[n];
			array[n] = array[parrent];
			array[n] = swap;
			n = parrent;
		}

		PrintArray(array, heap_size);
}



