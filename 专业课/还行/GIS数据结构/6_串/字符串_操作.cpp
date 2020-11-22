#include <iostream>
#include<stdio.h> 
#include <string>
using namespace std;
void string_method();
void char_method();
void char_search();
int main ()
{
	/*
		string 
			string类！！
			
			，引入头文件不同
			
		操作： 
			串的比较
			串的连接 
			
		数组：
			要初始化 
			作用域！！ 
			二维数组、多维数组的排列方式
		显示
			cin >> 输入，不能加endl
			cout << 输出显示，能加endl,\n 
			 
	*/ 
    //string_method();
	char_method();
	return 0;
}
void string_method() {
	
	//	字符串拼接 
	cout << "---------------------------------------------------------------------" << endl;
	cout << "string:\n" << endl; 
	string str01 = "";
	string str02 = "";
	cout <<"please input two object:(A B)" << endl;
	cin >> str01 >> str02;
	str01 = str01 + str02;	
	cout << str01 << endl;
} 
void char_method() {
	int i,k,number[100] = {0};//数组初始化重要 
	int n = 0, m = 0, m2 =0, n2 = 0;//组合序列 
	//引入二维数组 
	char str01[3][4] = {{'\0'}};	//char str01[3][4] = {{' '}};
	//输入数组 
	for(i = 0; i < 3; i++) {
		cout << "第" << i + 1 << "个字符数组:" << endl;
		for(k = 0; k < 4; k++) {
			cin >> str01[i][k];
		}
	}
	char_search(str01[]);
	//计算一维数组中元素个数
	for(i = 0; i < 3; i++) {
		for(k = 0; str01[i][k]!='\0'; k++) {
			number[k]++;
		}
	} 
	cout << "please input the nth for which you want to combine: n and m:" << endl;
	cin >> n2 >> m2;//序号 ,比实际值高1 
	m = m2 -1; n = n2 -1;
//	//拼接 
//	for(k = 0; k < number[m] + 1; k++) {//在n个的基础上，添加m个 ,number[n]:第n下一单位量级的个数 
//		//*(str01[n] + number[n] + k) = *(str01[m] + k);
//		str01[n][(number[n] + 1)+ k] = str01[m][k]; 
//		
//	}
//	for(k = 0; str01[n][k]!='\0'; k++) {
//		cout << str01[n][k];
//	} 
//	 for(i = 0; str01[i]!='\0'; i++) {
//	 	printf("%d\t", str01[i]);
//	 } 
	 
}
void char_search(char str01[]) {
	char c;
	int k = -1,m = -1;
	cin >> k >> m; 
	cout << "查找第" << k << "组" << "第" << m << "几个数据"; 
	//合法性检验
	c = str01[k][m];
	cout << c; 
} 
