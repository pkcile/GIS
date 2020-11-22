#include <stdio.h>
#include "Class01.h"
/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char** argv) {
	
	
	Clinklist<int> test01;
	//CNode<int> test02;
	Class01 test03;
	test01.initialize();
		
	while(1){
		int a, b;
		printf("\n请输入要插入的位置和值：\n");
		scanf("%d%d",&a,&b);
		test01.insert(a, b);
		test01.allKnow();
		if(a == 0 && b == 0){
			break;
		}

	}
	getchar();
	return 0;
}
