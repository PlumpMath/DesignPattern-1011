// Design Pattern.cpp : 定义控制台应用程序的入口点。
//

#include "stdafx.h"

#include <iostream>
using namespace std;

#include "AbstractFactory.h"

int _tmain(int argc, _TCHAR* argv[])
{
	//抽象工厂模式
	COperation * oper = CCalculatorFactory::Create('+');
	oper->NumberA = 1;
	oper->NumberB = 2;
	cout<<oper->GetResult();

	return 0;
}

