// Facade.cpp : 定义控制台应用程序的入口点。
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

