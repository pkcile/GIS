#include <stdio.h>
#include "List1.h"
//#include "SQ.h"


//List1::List1(int maxList)
List1::List1(void)
{
}


List1::~List1(void)
{
}
void List1::initial(){
	maxList = 20;
	a = new int;

	//a = new int[maxList];
	//*(a ) = 10;
	//printf("%p\n", &a);
	//printf("%p\n", a);
	//printf("%p\n", *a);
	//printf("test\n");

	number = 0;
}
void List1::in(int data){
	if(number < maxList)
	{
		*(a + number) = data;
		printf("排入成功\n");
		printf("%d\n", *(a + (number++)));
	}
}
void List1::out(){
	//出去的条件
	if(number > 0){
		for(int i = 0; i < number; i++){
			a[i] = a[i + 1];
		}
	}
	number = number -1;
	printf("number = %d", number);
}
