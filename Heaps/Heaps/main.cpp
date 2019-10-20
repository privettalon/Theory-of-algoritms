#include <iostream>;
#include <stdio.h>;
#include"Heaps.h";

using namespace std;

int main()
{
	int key,num;
	int arr[] = { 12, 11, 13, 5, 6, 7 };
	int n = sizeof(arr) / sizeof(arr[0]);

	HeapSort(arr, n);

	cout << "Sorted array is \n";
	PrintArray(arr, n);
	
	 num = HeapExtractMax(arr, n);
	cout << num << endl;
	cout << "lol";
	PrintArray(arr, n);
	cin >> num;




}