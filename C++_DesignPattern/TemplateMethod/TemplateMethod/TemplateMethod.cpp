// TemplateMethod.cpp : �������̨Ӧ�ó������ڵ㡣
//

#include "stdafx.h"
#include "TestPaper.h"

#include <iostream>
using namespace std;

int _tmain(int argc, _TCHAR* argv[])
{
	cout<<"ѧ���׳����Ծ�";
	TestPaper* studentA = new TestPaperA();
	studentA->TestQuestion1();
	studentA->TestQuestion2();
	studentA->TestQuestion3();

	cout<<"ѧ���ҳ����Ծ�";
	TestPaper* studentB = new TestPaperB();
	studentB->TestQuestion1();
	studentB->TestQuestion2();
	studentB->TestQuestion3();
	return 0;
}

