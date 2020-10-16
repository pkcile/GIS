#pragma once
class Class01
{
public:
	Class01(void);
	~Class01(void);
};
template<class T>
class Stack
{
public:
	T data;
	Stack<T> *pNext;
	Stack<T> *pHead;
public:
	void initial();
	void Push(int data);
	void Pop();
	void Bianli();
};

//初始化
template<class T>
void::Stack<T>::initial(){
	pHead = new Stack<T>;//随意分配一个地址？ 
	pHead ->pNext = NULL;
	printf("栈的初始化：%p\n", pHead);
}

//入栈
template<class T>
void::Stack<T>::Push(int data){
	Stack<T> *temp = new Stack<T>;
	pHead -> pNext = pHead;
	pHead = temp;
	pHead -> data = data;
	printf("入栈后头指针：%p\n", pHead);
	printf("入栈后头指针数据域：%d\n", pHead -> data);
}

//出栈
template<class T>
void::Stack<T>::Pop(){
	Stack<T> *temp = new Stack<T>;
	if(pHead -> pNext == NULL)
		printf("出栈失败，栈为空");
	else
	{
		pHead = pHead -> pNext;
		printf("出栈后头指针：%p", pHead);
	}
		

}

//遍历
template<class T>
void::Stack<T>::Bianli(){
	if(pHead -> pNext == NULL)
		printf("为空\n");
	else{
		Stack<T> *temp = new Stack<T>;
		temp = pHead;
		//printf("%d\n", pHead -> pNext -> data);
		printf("遍历后的值\n");
		printf("%d\n", temp -> data);
		//printf("%d\n", temp -> pNext -> data);
		do{
			printf("hahaha:%d\n", temp -> data);
			temp = temp -> pNext;
		}while(temp  == NULL);
	}
	
}


