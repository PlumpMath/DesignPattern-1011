#pragma once

#include <iostream>
using namespace std;

class SubsystemOne
{
public:
	void MethodOne()
	{
		cout<<"��ϵͳ����һ"<<endl;
	}
};

class SubsystemTwo
{
public:
	void MethodTwo()
	{
		cout<<"��ϵͳ������"<<endl;
	}
};


class SubsystemThree
{
public:
	void MethodThree()
	{
		cout<<"��ϵͳ������"<<endl;
	}
};


class SubsystemFour
{
public:
	void MethodFour()
	{
		cout<<"��ϵͳ������"<<endl;
	}
};

class Facade
{
private:
	SubsystemOne* one;
	SubsystemTwo* two;
	SubsystemThree* three;
	SubsystemFour* four;

public:
	Facade()
	{
		one = new SubsystemOne();
		two = new SubsystemTwo();
		three = new SubsystemThree();
		four = new SubsystemFour();
	}

	void MethodA()
	{
		cout<<"������A"<<endl;
		one->MethodOne();
		two->MethodTwo();
		four->MethodFour();
	}

	void MethodB()
	{
		cout<<"������B"<<endl;
		two->MethodTwo();
		three->MethodThree();
	}
	~Facade()
	{
		delete one;
		delete two;
		delete three;
		delete four;
	}
};