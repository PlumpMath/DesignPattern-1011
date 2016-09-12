// Decorator.cpp : 定义控制台应用程序的入口点。
//

#include "stdafx.h"
#include "Person.h"


int _tmain(int argc, _TCHAR* argv[])
{
	Person *xc = new Person("小菜");
	cout<<"第一种装扮：";

	Sneakers *pqx = new Sneakers();
	BigTrouser *kk = new BigTrouser();
	TShirts *dtx = new TShirts();

	pqx->Decorator(xc);
	kk->Decorator(pqx);
	dtx->Decorator(kk);
	dtx->Show();

	return 0;
}

