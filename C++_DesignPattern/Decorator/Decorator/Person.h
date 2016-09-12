#pragma once
#include <string>
#include <iostream>
using namespace std;

class Person
{
private:
	string name;
public:
	Person(void);
	Person(string name)
	{
		this->name = name;
	}
	~Person(void);
	virtual void Show()
	{
		cout<<"װ�ε�"<<name<<endl;
	}
};

class Finery:public Person
{
protected:
	Person * component;
public:
	void Decorator(Person * component)
	{
		this->component = component;
	}
	void Show()
	{
		if(component != NULL)
			component->Show();
	}
};

//ConcreteDecorator��
class TShirts:public Finery
{
public:
	void Show()
	{
		cout<<"��T��  ";
		Finery::Show();
	}
};

//ConcreteDecorator�� 
class BigTrouser:public Finery
{
public:
	void Show()
	{
		cout<<"���  ";
		Finery::Show();
	}

};

//ConcreteDecorator��  
class Sneakers:public Finery  
{  
public:  
    void Show()  
    {  
        std::cout<<"����Ь  ";  
        Finery::Show();  
    }  
  
};  
  
//ConcreteDecorator��  
class Suit:public Finery  
{  
public:  
    void Show()  
    {  
        std::cout<<"��װ  ";  
        Finery::Show();  
    }  
  
};  
  
//ConcreteDecorator��  
class Tie:public Finery  
{  
public:  
    void Show()  
    {  
        std::cout<<"���  ";  
        Finery::Show();  
    }  
  
};  
  
//ConcreteDecorator��  
class LeatherShoes:public Finery  
{  
public:  
    void Show()  
    {  
        std::cout<<"ƤЬ  ";  
        Finery::Show();  
    }  
       
};  