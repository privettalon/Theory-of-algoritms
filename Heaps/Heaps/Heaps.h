#pragma once


int Parent(int i);
int Left(int i);
int Right(int i);

void PrintArray(int array[], int heap_size);
void MaxHeapify(int array[], int i, int heap_size);
void HeapSort(int array[], int heap_size);
int HeapMax(int array[], int heap_size);
int HeapExtractMax(int array[], int heap_size);
void HeapIncreaseKey(int array[], int i, int key);
