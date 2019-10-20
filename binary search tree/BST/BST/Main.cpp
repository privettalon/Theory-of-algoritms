#include<stdio.h> 
#include<stdlib.h> 
#include "BST.h"
#include <iostream>

using namespace std;

int main()
{
	int chooice = 0;
	int data;
	Node* root;
	root = NULL;
	do
	{
		cout << "What do you want to do?" << endl;
		cout << "1 - Insert" << endl;
		cout << "2 - Delete" << endl;
		cout << "3 - Find" << endl;
		cout << "4 - Clear" << endl;
		cout << "5 - Exit" << endl << endl;
		cin >> chooice;
		if (chooice == 1)
		{
			cout << "Input data :  ";
			cin >> data;
			cout << endl;
			if (Search(root, data))
			{
				cout << "item already exists" << endl;
			}
			else
			{
				Add(root, data);
				show(root, 0);
				cout << endl;
			}
		}
		if (chooice == 2)
		{
			cout << "Input data : ";
			cin >> data;
			if (Search(root, data))
			{
				BSTremove(root, data);
				show(root, 0);
			}
			else
			{
				cout << "item does not exist" << endl;
			}
		}
		if (chooice == 3)
		{
			cout << "Input data : ";
			cin >> data;
			if (Search(root, data))
			{
				cout << "item already exists" << endl;
			}
			else
			{
				cout << "item does not exist" << endl;
			}
		}
		if (chooice == 4)
		{
			system("cls");
		}
	} while (chooice != 5);
}
