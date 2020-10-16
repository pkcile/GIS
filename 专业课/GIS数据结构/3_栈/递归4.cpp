#include<stdio.h>
//ตÝน้1
void digui(int n) {
	if(n == 1) {
		printf("1\t");
//		return 1;
	}
	else {
		printf("%d\t", n);
		digui(n-1);
//		return n + digui(n-1);
//		printf("%d\t", n);
	}
} 
int main() {
	int n;

//	while(n==0) {
//		
//	
//	}
	do {
		scanf("%d", &n);
		digui(n);
//		printf("%d\n", digui(n));
		if(n==0) break;
	} while(1);//n==0

	getchar();
	return 0;
	
} 
