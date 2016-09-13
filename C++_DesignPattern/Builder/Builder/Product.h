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
		cout<<"��Ʒ  ����"<<endl;
		vector<string>::iterator it;
		for(it = parts.begin();it!=parts.end();it++)
		{
			cout<<*it<<endl;
		}
	}
};

//Builder,��������
class Builder
{
public:
	virtual void BuildPartA()=0;
	virtual void BuildPartB()=0;
	virtual Product* GetResult()=0;
};

//ConcreteBuilder1,���彨������
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
        product->Add("����A");  
    }  
    void BuildPartB()  
    {  
        product->Add("����B");  
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
        product->Add("����X");  
    }  
    void BuildPartB()  
    {  
        product->Add("����Y");  
    }  
    Product* GetResult()  
    {  
        return product;  
    }
};

//Director Class,ָ������
class Director
{
public:
	void Constuct(Builder* builder)
	{
		builder->BuildPartA();
		builder->BuildPartB();
	}
};