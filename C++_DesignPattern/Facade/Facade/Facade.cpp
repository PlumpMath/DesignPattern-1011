// Facade.cpp : �������̨Ӧ�ó������ڵ㡣
//

#include "stdafx.h"
#include "Subsystem.h"

int _tmain(int argc, _TCHAR* argv[])
{
	Facade* facade = new Facade();

	facade->MethodA();
	facade->MethodB();

	return 0;
}

