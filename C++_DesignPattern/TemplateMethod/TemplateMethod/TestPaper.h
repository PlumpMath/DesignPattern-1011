#pragma once
#include <string>
#include <iostream>
using namespace std;

class TestPaper
{
public:
	void TestQuestion1()  
	{  
		std::cout<<"杨过得到，后来给了郭靖，练成倚天剑、屠龙刀的玄铁可能是【】a.球磨铸铁 b.马口铁 c.高速合金钢 d.碳素纤维"<<std::endl;    
		cout<<Answer1()<<endl;
	}  
	void TestQuestion2()  
	{  
		std::cout<<"杨过、程英、陆无双铲除了情花，造成【】a.使这种植物不再害人 b.使一种珍稀物种灭绝 c.破坏了那个生物圈的生态平衡 d.造成该地区沙漠化"<<std::endl;   
		cout<<Answer2()<<endl;
	}  
	void TestQuestion3()  
	{  
		std::cout<<"蓝凤凰致使华山师徒、桃谷六仙呕吐不止，如果你是大夫，会给他们开什么药【】a.阿司匹林 b.牛黄解毒片 c.氟哌酸 d.让他们喝大量牛奶"<<std::endl;   
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