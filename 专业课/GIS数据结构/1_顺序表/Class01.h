//#pragma once
class Class
{
public:
	
	~Class(void);
	 Class(int nSize);
public:
	//初始化一个地址，即初始化顺序表
	//int pElement[100];//存储空间地址
	int *pElement;
	int nLength;//表长，不允许有初始值
	int nMaxSize;//最大存储空间

public:
	//1.查
	//输入number,查找到nth 
	int find01();
	//输入nth,查找到number
	int find02();
	//2.增 
//	bool insert(int k, int x);
	//插入尾部 
	void insert02(); 
//	//插入首部 
//	void insert03();
//	//插入特定序列位置 
//	void insert04();
//	//插入特定值之前 
//	void insert05(); 
//	//插入特定值之后 
//	void insert06();
	bool delete01(int k);
	int inseart01(int k, int x);
	bool modify(int k, int x);
};

