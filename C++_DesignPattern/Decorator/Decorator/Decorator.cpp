// Decorator.cpp : �������̨Ӧ�ó������ڵ㡣
//

#include "stdafx.h"
#include "Person.h"


int _tmain(int argc, _TCHAR* argv[])
{
	Person *xc = new Person("С��");
	cout<<"��һ��װ�磺";

	Sneakers *pqx = new Sneakers();
	BigTrouser *kk = new BigTrouser();
	TShirts *dtx = new TShirts();

	pqx->Decorator(xc);
	kk->Decorator(pqx);
	dtx->Decorator(kk);
	dtx->Show();

	return 0;
}

