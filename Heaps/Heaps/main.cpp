#include <iostream>;
#include <stdio.h>;
#include<stdlib.h>;
#include"Heaps.h";

using namespace std;

int main()
{
	int k;
	int arr[50] = { 0 };
	int n,key,exit;
	do
	{
		system("cls");
		cout << "enter the number of items:  ";
		cin >> n;
		//system("cls");
		cout << "Enter elements:\n";
		for (int i = 0; i < n; i++)
		{
			cin >> arr[i];
		}
	//	system("cls");
		cout << "\nYour array : ";
		PrintArray(arr, n);
		do {
			cout << "Enter the method:" << endl;
			cout << "1.Sorted array" << endl;
			cout << "2.Build Max Heap" << endl;
			cout << "3.Delete Max and build max heap" << endl;
			cout << "4.ShowMax" << endl;
			cout << "5.Input Value" << endl;
			cout << "6.Inpuw a new array or exit" << endl;
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
		} while (k != 6);
		system("cls");
		cout << "\n\n press 0 to exit and press any button to continue (1)" << endl;
		cin >> exit;

	} while (exit!=0);
}