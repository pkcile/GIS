#include <stdio.h>
#include "Class01.h"
/* run this program using the console pauser or add your own getch, system("pause") or input loop */
/*
	> 广义表的相关内容
		1.递归
		2.广义表的基本结构 
			
*/
int main(int argc, char** argv) {
	
	//Class01类：递归 
	Class01 di_gui;
	//内容提示、及键盘输入月份 
	printf("请输入整数月，最后算的兔子的现有个数\n");double nth; scanf("%lf", &nth); 
	//输出结果 
	printf("%.0f\n", di_gui.rec(nth));
	getchar();
	return 0;
}
