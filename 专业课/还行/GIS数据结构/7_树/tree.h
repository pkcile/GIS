#include "stdio.h"
//为什么有时候出现不需要用头文件的情况 
//类与类之间的相互使用还不熟悉
 
//类1 
class ClassTree
{
public:
	ClassTree(void);
	~ClassTree(void);
public:
	int a;
public:
	void hello(); 
	void initialize();
	void test1();
	void test();
};

//类2 
class testNode
{
public:
	testNode(void);
	~testNode(void);

public:
	int data01;
	void test2();
};

void testNode::test2() {
	printf("test");
} 

