// Builder.cpp : 定义控制台应用程序的入口点。
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

	cout<<"指挥者用ConcreteBuilder1的方法建造产品："<<endl; 
	director->Constuct(builder1);
	Product* p1 = builder1->GetResult();
	p1->Show();
	cout<<endl;

	cout<<"指挥者用ConcreteBuilder2的方法建造产品："<<endl; 
	director->Constuct(builder2);
	Product* p2 = builder1->GetResult();
	p2->Show();
	cout<<endl;

	return 0;
}

