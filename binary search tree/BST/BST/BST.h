#pragma once

struct Node
{
	int data; // значення 
	Node* left;
	Node* right;
};


void Add(Node * &node, int data);
void show(Node* node, int l);
bool Search(Node * node ,int data);
Node* BSTremove(Node* node, int data);
Node* Maxfind(Node* node);
Node* Minfind(Node* node);

