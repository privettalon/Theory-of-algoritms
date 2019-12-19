#include <iostream>;
#include <stdio.h>;
#include<stdlib.h>;
#include"Heaps.h";

using namespace std;

int main()
{
	int n=0;
	int k;
	int arr[50] = { 0 };
	int key,exit;
	do
	{
		system("cls");
		cout << "Enter elements:\n";

		for(int i =0;;i++)
		{
			int b;
			cin >> b;
			if (b != -99)
			{
				n++;
				arr[i] = b;
			}
			else break;
			
			
		} 
		system("cls");
		cout << "\nYour array : ";
		PrintArray(arr, n);
		do {
			cout << "Enter the method:" << endl;
			cout << "1.Sorted array" << endl;
			cout << "2.Build Max Heap" << endl;
			cout << "3.Delete Max and build max heap" << endl;
			cout << "4.ShowMax" << endl;
			cout << "0.add" << endl;
			cout << "5.Input Value" << endl;
			cout << "6. exit" << endl;
			cin >> k;
			if (k == 1)
			{
				cout << "Sorted array :" << endl;
				HeapSort(arr, n);
				PrintArray(arr, n);
			}

			if (k == 2)
			{
				BuildMaxHeap(arr, n);
				PrintArray(arr, n);

			}

			if (k == 3)
			{
				DeleteMax(arr, n);
			}

			if (k == 4)
			{
				ShowMax(arr, n);
				cout << endl;
			}

			if (k == 5)
			{
				int index, key;
				cout << "Input a index : ";
				cin >> index;
				cout << "\n Input a key: ";
				cin >> key;
				HeapSwapKey(arr, index-1, key, n);
			}
			if (k == 0)
			{
				int b;
				cin >> b;				
				arr[n] = b;
				BuildMaxHeap(arr, n+1);
				PrintArray(arr, n + 1);
				n++;
			
			}
		} while (k != 6);
		exit = 0;

	} while (exit!=0);
}