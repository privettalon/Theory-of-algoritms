#include <iostream>;
#include <stdio.h>;
#include<stdlib.h>;
#include"Heaps.h";

using namespace std;

int main()
{
	int arr[50] = { 0 };
	int n,key,exit;
	do {
		cout << "enter the number of items:  ";
		cin >> n;
		system("cls");
		cout << "Enter elements:\n";
		for (int i = 0; i < n; i++)
		{
			cin >> arr[i];
		}
		system("cls");
		HeapSort(arr, n);
		cout << "Sorted array :" << endl;
		PrintArray(arr, n);
		cout << "\n\n press 0 to exit and press any button to continue (1)" << endl;
		cin >> exit;
	} while (exit!=0);
}