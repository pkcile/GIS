#include <stdio.h>
#include "Class01.h"
/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char** argv) {
	//引入结构体并初始化 
	Class classListS(20);

	//操作提示 
	printf("---------------------------------------------------------------------\n"); 
	printf("请你选择要进行的操作类型，1：增，2：删，3：改，4：查\n退出操作：输入除1、2、3、4的数字\n");
	printf("---------------------------------------------------------------------\n"); 
	//循环操作 
	while(1){
		//标识符 
		double choose_number;
		scanf("%lf", &choose_number);
		if(choose_number == 1) {
			printf("增加操作，请选择插入类型\n"); double choose_number01; scanf("%lf", &choose_number01);
			if(choose_number01 == 1) {
				classListS.insert02();
			}
			else {
				if(choose_number01 == 2) {
				
				}
				else {
					if(choose_number01 == 3) {
						
					}
					else {
						if(choose_number01 == 4) {
							
						}
						else {
							printf("输入错误");
						} 
					} 
				}
			}
		}
		else {
			if(choose_number == 2) {
				printf("删除操作，请选择删除类型\n");
			}
			else {
				if(choose_number == 3) {
					printf("修改操作，请选择修改类型\n");
				}
				else {
					if(choose_number == 4) {
						printf("查找操作，请选择查找类型\n");
					}
					else{
						printf("please input correct number to choose!");
						break;
					}
				}
			}
		}
	}
//	//查
//	int nth = classListS.find01();
//	//查 
//	int number = classListS.find02();
	getchar();
	return 0;
}
/*
## 操作分类
### 0.变量
	temp =	1.从最前面或最后面
			2.从特定序号
			3.按值
	动态插入、查找、删除
	静态插入、查找、删除
### 1.初始化操作
		初始化 	
### 2.加工型操作
		增、删、改 
		增+temp
		删+temp
		改+temp	
### 3.引用型操作 
		查找 
		1.按值查找
		2.按序号查找 
		目的：
		得到对应的值或序号
###	难点：如何批量删除、查找、修改 
*/ 
