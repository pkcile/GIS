#pragma once
//定义Class01类
class Class01
{
public:
	Class01(void);
	~Class01(void);
};


/*
	定义CNode类  
	功能：定义数据域，指针指向
	内容：数据域 、下一地址指针
	相当于结构体
*/
template <class T>
class CNode{
public:
	//T data;
	T data;
	CNode<T> *pNext;//嵌套
};


/*
	定义Clinklist类  
	功能：定义首地址变量
*/
template<class T>
class Clinklist{
public:
	//相当于定义的全局变量
	//T	data;
	CNode<T> *pHead;
	
	
public:
	int nLength;
	void initialize();
	void insert(int k, T v);
	void insert02(int data);
	void allKnow();

};



/*
1.初始化
*/
template<class T>
void::Clinklist<T>::initialize(){
	printf("initiallize---hello world!\n");
	pHead = new CNode<T>;//只是为pHead先初始化一个指向的地址
	pHead -> pNext = NULL;
    nLength = 0;//初始化的位置
	printf("pHead的的地址：%p\n", pHead);

}
/*
2.插入
*/
template<class T>
void::Clinklist<T>::insert(int k, T v){
	//Class01
	//不满足条件才会退出
//判断k是否能够成立
	if(k < 1 || k-1 > nLength){
		printf("insert---it is false\n");
	}
	else{
		printf("insert前节点数：%d\n",nLength);
		int i = 1;
		CNode<T> *S = new CNode<T>;//要插入的元素
		S -> data = v;
		S ->pNext = NULL;
		CNode<T> *p = pHead;//临时存放头指针
		while(i != k){
			p = p ->pNext;
			i++;
		}
		S -> pNext = p ->pNext;//S的尾
		p -> pNext = S;//指向S的头
		printf("insert后节点数:%d\n", ++nLength);
	}
}
/*
3.插入
*/
template<class T>
void::Clinklist<T>::insert02(int data){
	//Class01
	/*printf("%p\n",pHead);
	printf("%p\n",pHead -> pNext);
	CNode<T> *temp = new CNode<T>;
	temp -> pNext = pHead ->pNext;

	printf("%p\n", temp);
	printf("%p\n", temp ->pNext);*/
	printf("Y\n");
	CNode<T> *ins = new CNode<T>;
	ins -> data = data;
	ins -> pNext = NULL;
	CNode<T> *temp = new CNode<T>;
	temp -> pNext= pHead -> pNext;
	while((temp -> pNext) != NULL){
		temp = temp -> pNext;
	}
	temp ->pNext = ins;
	ins ->pNext = NULL;
	nLength++;
	printf("insert---All Right! Insert maybe is right!\n");
}
/*
4.遍历元素
*/
template<class T>
void::Clinklist<T>::allKnow(){
	CNode<T> *temp = new CNode<T>;
	int i = 1;

	//拷贝地址
	temp -> pNext  = pHead -> pNext; 
	printf("遍历后的结果：\n");
	while(temp -> pNext != NULL){
		printf("\t");
		printf("--%d--",  temp -> pNext -> data );
		printf("\t");
		temp = temp -> pNext;
	}
	//temp = pHead -> pNext;

	////拷贝地址
	//temp -> pNext = pHead ->pNext;


	/*printf("phead: %p\n",  pHead);
	printf("temp: %p\n",  temp);
	printf("phead-> next: %p\n",  pHead -> pNext);
	printf("phead-> data: %d\n",  pHead -> pNext -> data);

	if(pHead -> pNext == NULL){
		printf("WHY !\n");
	}*/
	
	//printf("bianli---hello \n");
}


