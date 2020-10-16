#include<stdio.h>
#include<stdlib.h>
int main() {
	int i;
	FILE *fp,*copy;
//	fp=fopen("C:\\Users\\pkcile\\Desktop\\666.dat","w"); //创建文件 
	if((fp=fopen("C:\\Users\\pkcile\\Desktop\\777.dat","w"))==NULL) {
		printf("Can't write!\n");
		exit(0); 
	}
	copy = fp;
	for(i=1; i<90; i+=2) {
		fprintf(copy,"%4d", i);
		printf("%3d", i);
	}
	
	printf("%p\n", fp); 
	printf("%d\n", *fp); //什么意思 
	fclose(fp);
	printf("completed.\n");
	return 0;
} 
