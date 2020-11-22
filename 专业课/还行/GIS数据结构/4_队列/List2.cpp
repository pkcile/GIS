#include <stdio.h>
#include "List2.h"


List2::List2(void)
{
}


List2::~List2(void)
{
}

 

void List2::initial(){
	pHead = new List2;
	pHead -> pNext = NULL;
}

void List2::in(int data01){
	List2 *temp = new List2;
	temp -> pNext = NULL;
	temp -> data = data01;
	pHead -> pNext = temp;
	printf("插入成功\n");
	printf("%d\n", pHead -> pNext -> data);
	printf("%p\n", pHead );
}

void List2::out(){
	List2 *temp = new List2;
	temp = pHead;
	while(1){
			if(temp -> pNext == NULL)
				break;
			if(temp -> pNext -> pNext == NULL){
				temp -> pNext = NULL;
				printf("删除成功\n");
				printf("%p\n", temp );
				printf("%d\n", temp -> data );
				break;
			}
			temp = temp -> pNext;
	
	}
}
