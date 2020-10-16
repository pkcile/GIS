#include<stdio.h>
int nth(int test);
int fac(int nth01);
int main() {
	double nth;
	printf("please input the number of nth:\n");
	scanf("%lf", &nth);
	printf("%d\n", fac(double(nth)));
	return 0;
} 
int nth(int test) {
	if(test < 1) {
		printf("please input the correct number of nth\n");
		return -99999;
	}
	if(test == 1)
		return 1;
	else {
		return nth(test - 1) + 1;
	}
} 
int fac(int nth01) {
	if(nth01 < 1) {
		printf("please input the correct number of nth\n");
		return -99999;
	}
	if(nth01 == 1) {
		return 1;
	}
	else {
		return fac(nth01 - 1)*nth(nth01); 
	}
}
