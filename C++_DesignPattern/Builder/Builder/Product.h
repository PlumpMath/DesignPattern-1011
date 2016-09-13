#pragma once

#include <string>
#include <vector>
#include <iostream>

using namespace std;

class Product
{
private:
	vector<string> parts;
public:
	Product(void);
	~Product(void);
	void Add(string part)
	{
		parts.push_back(part);
	}

	void Show()
	{
		cout<<"产品  创建"<<endl;
		vector<string>::iterator it;
		for(it = parts.begin();it!=parts.end();it++)
		{
			cout<<*it<<endl;
		}
	}
};

//Builder,抽象构造类
class Builder
{
public:
	virtual void BuildPartA()=0;
	virtual void BuildPartB()=0;
	virtual Product* GetResult()=0;
};

//ConcreteBuilder1,具体建造者类
class ConcreteBuilder1:public Builder
{
private:
	Product* product;
public:
    ConcreteBuilder1()  
    {  
        product=new Product();  
    }  
    ~ConcreteBuilder1()  
    {  
        delete product;  
    }
    void BuildPartA()
    {  
        product->Add("部件A");  
    }  
    void BuildPartB()  
    {  
        product->Add("部件B");  
    }  
    Product* GetResult()  
    {  
        return product;  
    }
};

class ConcreteBuilder2:public Builder  
{
private:  
    Product* product;  
public:  
    ConcreteBuilder2()  
    {  
        product=new Product();  
    }  
    ~ConcreteBuilder2()  
    {  
        delete product;  
    }  
    void BuildPartA()  
    {  
        product->Add("部件X");  
    }  
    void BuildPartB()  
    {  
        product->Add("部件Y");  
    }  
    Product* GetResult()  
    {  
        return product;  
    }
};

//Director Class,指挥者类
class Director
{
public:
	void Constuct(Builder* builder)
	{
		builder->BuildPartA();
		builder->BuildPartB();
	}
};