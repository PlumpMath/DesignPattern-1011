// Proxy.cpp : �������̨Ӧ�ó������ڵ㡣
//

#include "stdafx.h"
#include "Givegift.h"

int _tmain(int argc, _TCHAR* argv[])
{
	SchoolGirl *jiaojiao = new SchoolGirl();
	jiaojiao->name = "���";

	Proxy *daili = new Proxy(jiaojiao);

	daili->GiveDolls();
	daili->GiveFlowers();
	daili->GiveChocolate();
	return 0;
}

