// Proxy.cpp : 定义控制台应用程序的入口点。
//

#include "stdafx.h"
#include "Givegift.h"

int _tmain(int argc, _TCHAR* argv[])
{
	SchoolGirl *jiaojiao = new SchoolGirl();
	jiaojiao->name = "李娇娇";

	Proxy *daili = new Proxy(jiaojiao);

	daili->GiveDolls();
	daili->GiveFlowers();
	daili->GiveChocolate();
	return 0;
}

