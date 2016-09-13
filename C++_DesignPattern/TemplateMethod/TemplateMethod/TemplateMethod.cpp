// TemplateMethod.cpp : 定义控制台应用程序的入口点。
//

#include "stdafx.h"
#include "TestPaper.h"

#include <iostream>
using namespace std;

int _tmain(int argc, _TCHAR* argv[])
{
	cout<<"学生甲抄的试卷";
	TestPaper* studentA = new TestPaperA();
	studentA->TestQuestion1();
	studentA->TestQuestion2();
	studentA->TestQuestion3();

	cout<<"学生乙抄的试卷";
	TestPaper* studentB = new TestPaperB();
	studentB->TestQuestion1();
	studentB->TestQuestion2();
	studentB->TestQuestion3();
	return 0;
}

