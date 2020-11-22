#include<stdio.h>
#include<stdlib.h>
#define N 10

void array_way();
void point_way();
int main() {
	/*
		char型和string类型的关系
		char型的结束条件 '\0'
		空串和空字符串的区别 
		
		指针表示和数组表示形式的差异 
		
		malloc的相关用法：
			头文件：stdlib.h 
			(char*)malloc(6*sizeof(char)); 
			free(a)释放内存空间 
	*/
	array_way();
	point_way();
	return 0;
} 
void array_way() {
//	char string01[1];
	char string01[4];//个数不限 ?
	int i;
	string01[0] = ' ';
	string01[1] = 'T';
	string01[2] = '\0';
	for(i = 0; string01[i] != '\0'; i++) {
		printf("%d\n", string01[i]);
	}
}
void point_way() {
	char *p1;
	int i;
	p1 = (char *)malloc(6*sizeof(char));
	*p1 = '7';
	*(p1 + 1) = '1';
	*(p1 + 2) = '2';
	*(p1 + 3) = '3';
	*(p1 + 4) = '4';
	*(p1 + 5) = '5';
	*(p1 + 6) = '5';
	*(p1 + 7) = '\0';
	
	for(i = 0; *(p1 + i) != '\0'; i++) {
		printf("%c\t", *(p1 + i));
		printf("%p\t", p1+i);
		printf("%p\n", *(p1+i));
	}
//	free(p1);
	printf("%p\n", '1');
	printf("%c\n", *(p1 + 2));
	getchar(); 
} 
