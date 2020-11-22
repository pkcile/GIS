#include "stdio.h"
#include "Class01.h"
Class::Class(int nSize)//初始化操作
{
	nMaxSize = nSize;//最大存储空间
	pElement = new int[9];//分配pElement一个位置 
	//new int []起到什么作用 
	int *temp = pElement;
	//printf("%p", pElement); 
	//指针变量与数组的区别？ 
	nLength = 0;
	//测试内存占的位置 
	//	for(int i = 0;i<nMaxSize;i++){
	//		printf("%p\n",pElement++);
	//	} 
	//	pElement = temp;
	//	for(int i = 0;i<nMaxSize;i++){
	//		*(pElement++) = 20 - i;
	//	} 
	//	pElement = temp;
	//	for(int i = 0;i<nMaxSize;i++){
	//		printf("%d\n",*(pElement++));
	//	}
	//	pElement = temp;
	//	printf("\n");
	//	for(int i = 0;i<nMaxSize;i++){
	//		printf("%p\n",*(pElement++));
	//	} 
	//	pElement = temp;
}
Class::~Class(void)
{
}
//1.查找
//输入number,查找到nth ,查找一个值匹配一个序列；如何一个值匹配多个序列 	
int Class::find01() {
	//合法性检验
	if(nLength > 0) {
		printf("请输入你要查找的值\n"); 
		//要查找的值、查到的序列、判断查找成功的标识 
		int number, nth = 0, right = 0; 
		scanf("%d", &number);
		for(int i = 0; i < nLength ; i++) {
			nth++;
			if(number == pElement[i]) {
				right = 1;
				break;
			}		
		}
		//如果查找成功，返回序列；如果不成功，返回-1 
		if(right == 1) {
			printf("值%d对应的序列为%d\n", number, nth); 
			return nth;
		} 
		else {
			printf("未找到对应的值\n"); 
			return -1;	
		} 
		
	}
	else {
		printf("为空\n");
		return -1;	
	}	
}
//1.查找
//输入nth,查找到number ，一个序列对应一个值	
int Class::find02() {
	printf("请输入你要查找的序列:\n"); 
	//要查找的序列
	int nth;
	scanf("%d", &nth); 
	//合法性检验
	if(nth <= nLength) {
		//要查到的值
		int number = 0; 
		number = pElement[nth-1];
		//如果查找成功，返回序列；如果不成功，返回-1 
		printf("序列%d的值为%d\n", nth, number);
		return number;	
	}
	else {
		printf("为空\n");
		return -1;	
	}	
}
//2.插入
//插入尾部 
void Class::insert02(){
	double number ;
	printf("请你选择要插入尾部的值：\n");
	scanf("%lf", &number);
	*(pElement + 1) = number;
	nLength++; 
	printf("尾部插入成功，其值为%f：\n", pElement[nLength]);  
} 


//3.删除操作
bool Class::delete01(int k){
	//合法性检验
	if(k<1 || k>nLength+1)
		return false;
	for(int i=k;i<nLength;i++){
		pElement[i-1] = pElement[i];
	}
	nLength--;	//更新表长
	//验证
	printf("插入后的数组\n");
	for(int i=0;i<nLength;i++){
		printf("%d\t",pElement[i]);
	}
	printf("\n");
	return true;
}
//4.修改操作
bool Class::modify(int k,int x){
	//合法性检验
	if(k<1 || k>nLength+1)
		return false;
	//修改
	pElement[k-1] = x;//注意
	//验证
	printf("修改后的数组\n");
	for(int i=0;i<nLength;i++){
		printf("%d\t",pElement[i]);
	}
	printf("\n");
	return true;
}
