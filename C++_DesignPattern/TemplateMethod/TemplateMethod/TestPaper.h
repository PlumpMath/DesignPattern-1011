#pragma once
#include <string>
#include <iostream>
using namespace std;

class TestPaper
{
public:
	void TestQuestion1()  
	{  
		std::cout<<"����õ����������˹������������콣�������������������ǡ���a.��ĥ���� b.����� c.���ٺϽ�� d.̼����ά"<<std::endl;    
		cout<<Answer1()<<endl;
	}  
	void TestQuestion2()  
	{  
		std::cout<<"�������Ӣ��½��˫�������黨����ɡ���a.ʹ����ֲ�ﲻ�ٺ��� b.ʹһ����ϡ������� c.�ƻ����Ǹ�����Ȧ����̬ƽ�� d.��ɸõ���ɳĮ��"<<std::endl;   
		cout<<Answer2()<<endl;
	}  
	void TestQuestion3()  
	{  
		std::cout<<"�������ʹ��ɽʦͽ���ҹ�����Ż�²�ֹ��������Ǵ�򣬻�����ǿ�ʲôҩ����a.��˾ƥ�� b.ţ�ƽⶾƬ c.������ d.�����Ǻȴ���ţ��"<<std::endl;   
	}
	virtual string Answer1()
	{
		return "";
	}
	
	virtual string Answer2()
	{
		return "";
	}

	virtual string Answer3()
	{
		return "";
	}

};

class TestPaperA:public TestPaper
{
public:
	string Answer1()
	{
		return "b";
	}
	
	string Answer2()
	{
		return "b";
	}

	string Answer3()
	{
		return "b";
	}
};

class TestPaperB:public TestPaper
{
public:
	string Answer1()
	{
		return "b";
	}
	
	string Answer2()
	{
		return "b";
	}

	string Answer3()
	{
		return "b";
	}
};