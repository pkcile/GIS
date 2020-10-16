#include<stdio.h>
int main() {
	int *p1=NULL, i=666;//p1为指针变量，NULL为指针变量的指针 
	p1 = &i;//将变量i的地址赋给指针变量p1 
	printf("变量i的地址赋给p1后，p1取值%d\n", *p1);
	printf("变量i的地址：%p\n", &i);
	printf("变量i的值666的地址：%p\n", i);
	printf("666的地址：%p\n", 666);
	return 0; 
} 
