// Builder.cpp : �������̨Ӧ�ó������ڵ㡣
//

#include "stdafx.h"
#include "Product.h"
#include <iostream>
using namespace std;

int _tmain(int argc, _TCHAR* argv[])
{
	Director* director = new Director();

	Builder* builder1 = new ConcreteBuilder1();
	Builder* builder2 = new ConcreteBuilder2();

	cout<<"ָ������ConcreteBuilder1�ķ��������Ʒ��"<<endl; 
	director->Constuct(builder1);
	Product* p1 = builder1->GetResult();
	p1->Show();
	cout<<endl;

	cout<<"ָ������ConcreteBuilder2�ķ��������Ʒ��"<<endl; 
	director->Constuct(builder2);
	Product* p2 = builder1->GetResult();
	p2->Show();
	cout<<endl;

	return 0;
}

