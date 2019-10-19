#include"BST.h"
#include<stdio.h> 
#include<stdlib.h> 
#include <iostream>

using namespace std;


void Add(Node* &node, int data)
{
	if (node == NULL)
	{
		node = new Node;
		node->data = data;
		node->left = node->right = NULL;

	}
	else  if (data <= node->data)
	{
		if (node->left != NULL)
		{
			Add(node->left, data);
		}
		else
		{
			node->left = new Node;
			node->left->data = data;
			node->left->left = NULL;
			node->left->right = NULL;
		}
	}
	else if (data >= node->data)
	{
		if (node->right != NULL)
		{
			Add(node->right, data);
		}
		else
		{
			node->right = new Node;
			node->right->data = data;
			node->right->right = NULL;
			node->right->left = NULL;
		}
	}
}

void show(Node* node, int l)
{
	if (node != NULL)
	{
		show(node->right, l + 1);
		for (int i = 0; i < l; i++)
		{
			cout <<"     " ;

		}
		cout << node->data << endl;
		show(node->left, l + 1);
	}
}

bool Search(Node* node, int data)
{
	if (node == NULL)
	{
		return false;
	}
	else if (node->data == data)
	{
		return true;
	}
	else if (data < node->data)
	{
		return Search(node->left, data);
	}
	else
	{
		return Search(node->right, data);
	}
}

Node* BSTremove(Node* node, int data)
{
	Node* temp ;
	if (node == NULL)
	{
		return NULL;
	}
	else if (data < node->data)
	{
		node->left = BSTremove(node->left, data);
	}
	else if (data > node->data)
	{
		node->right = BSTremove(node->right, data);
	}
	else if (node->left && node->right)
	{
		temp = Minfind(node->right);
		node->data = temp->data;
		node->right = BSTremove( node->right, node->data);
	}
	else
	{
		temp = node;
		if (node->left == NULL)
		{
			node = node->left;
		}
		else if (node->right == NULL)
		{
			node = node->right;
		}
		delete temp;
	}
	return node;
}

Node* Maxfind(Node* node)
{
	if (node == NULL)
	{
		return NULL;
	}
	else if (node->right == NULL)
	{
		return node;
	}
	else
	{
		return Maxfind(node->right);
	}
}

Node* Minfind(Node* node)
{
	if (node == NULL)
	{
		return NULL;
	}
	else if (node->left == NULL)
	{
		return node;
	}
	else
	{
		return Minfind(node->left);
	}
}
