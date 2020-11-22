#include<stdio.h>
int age(int nth) {
	if(nth < 1) {
		printf("please input the correct number of nth\n");
		return -99999;
	}
	if(nth == 1)
		return 10;
	else {
		
		return age(nth - 1) + 2;
	}
} 
int main() { 
	double nth;
	printf("please input the number of nth:\n");
	scanf("%lf", &nth);
	printf("%d\n", age(int(nth))); 
	getchar();
	return 0;
} 
/*
summarize:(correct)
summerize:(false)
	1.µÝ¹éÈÝÒ×³¬³öÖµÓò·¶Î§£» 
*/
