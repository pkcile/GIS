#include <stdio.h>
#include "Class01.h"
/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char** argv) {
	Stack<int> stack01;
	stack01.initial();
	stack01.Push(0);
	stack01.Bianli();
	//stack01.Pop();
	//stack01.Bianli();
	getchar();
	return 0;
}
