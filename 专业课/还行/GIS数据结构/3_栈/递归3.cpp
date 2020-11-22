#include<stdio.h>
int fac(int nth);
int main() {
	double nth;
	printf("please input the number of nth:\n");
	scanf("%lf", &nth);
	printf("%d\n", fac(int(nth)));
//	printf("hello world\n");
	return 0;
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
		return fac(nth01 - 1)*nth01;
	}
}
