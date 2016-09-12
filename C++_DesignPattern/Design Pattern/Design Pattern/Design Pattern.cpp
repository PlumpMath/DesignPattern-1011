// Design Pattern.cpp : �������̨Ӧ�ó������ڵ㡣
//

#include "stdafx.h"

#include <iostream>
using namespace std;

#include "AbstractFactory.h"

int _tmain(int argc, _TCHAR* argv[])
{
	//���󹤳�ģʽ
	COperation * oper = CCalculatorFactory::Create('+');
	oper->NumberA = 1;
	oper->NumberB = 2;
	cout<<oper->GetResult();

	return 0;
}

