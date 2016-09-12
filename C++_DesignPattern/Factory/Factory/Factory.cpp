// Factory.cpp : �������̨Ӧ�ó������ڵ㡣
//

#include "stdafx.h"
#include "Myoperation.h"
#include <iostream>
using namespace std;

int _tmain(int argc, _TCHAR* argv[])
{
	Factory* operFactory = new AddFactory();
	Operation *oper = operFactory->CreateOperation();
	oper->NumberA = 1;
	oper->NumberB = 2;
	cout<<oper->GetResult();

	return 0;
}

