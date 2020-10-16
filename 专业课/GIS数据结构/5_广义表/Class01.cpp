#include<stdio.h>
//#include<stdlib.h>
#include"Class01.h"
Class01::Class01(void) {}
Class01::~Class01(void) {}
void Class01::hello() {
	printf("hello world\n");
}
/*
	原则： 
		每对小兔生长一个月就成为大兔 
		每对大兔生一对小兔
	问题：
		有个人样了初生的一对小兔
		一年后共有多少对兔子
	解决：
		月份： 1 2 3 4 5 6 7 8
		兔对： 1 1 2 3 5 8 13 21 
	
	fib算法、递归问题 
	 
*/ 
//计算兔子的数目
 
double Class01::rec(double nth) {
	if(nth == 1) {
		return 1;
	}
	else {
		if(nth == 2) {
			return 1;
		}
		else {
			return rec(nth -1) + rec(nth -2);
		}
			
	}
}
