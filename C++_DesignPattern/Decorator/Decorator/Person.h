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
		cout<<"装饰的"<<name<<endl;
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

//ConcreteDecorator类
class TShirts:public Finery
{
public:
	void Show()
	{
		cout<<"大T恤  ";
		Finery::Show();
	}
};

//ConcreteDecorator类 
class BigTrouser:public Finery
{
public:
	void Show()
	{
		cout<<"垮裤  ";
		Finery::Show();
	}

};

//ConcreteDecorator类  
class Sneakers:public Finery  
{  
public:  
    void Show()  
    {  
        std::cout<<"破球鞋  ";  
        Finery::Show();  
    }  
  
};  
  
//ConcreteDecorator类  
class Suit:public Finery  
{  
public:  
    void Show()  
    {  
        std::cout<<"西装  ";  
        Finery::Show();  
    }  
  
};  
  
//ConcreteDecorator类  
class Tie:public Finery  
{  
public:  
    void Show()  
    {  
        std::cout<<"领带  ";  
        Finery::Show();  
    }  
  
};  
  
//ConcreteDecorator类  
class LeatherShoes:public Finery  
{  
public:  
    void Show()  
    {  
        std::cout<<"皮鞋  ";  
        Finery::Show();  
    }  
       
};  