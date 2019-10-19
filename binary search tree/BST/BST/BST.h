#pragma once

struct Node
{
	int data; // the value of the node
	Node* left; // pointer to left descendant
	Node* right; // pointer to right descendant
};


void Add(Node * &node, int data);//adding nodes
void show(Node* node, int l); // showing a tree
bool Search(Node * node ,int data);// element search
Node* BSTremove(Node* node, int data);//deleting an item
Node* Maxfind(Node* node); // search for the greatest value
Node* Minfind(Node* node);// search for the smallest value

