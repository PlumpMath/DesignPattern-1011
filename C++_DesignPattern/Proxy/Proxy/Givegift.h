#pragma once
#include <string>
#include <iostream>
using namespace std;

class Givegift
{
public:
	Givegift(void);
	~Givegift(void);

	virtual void GiveDolls() = 0;
	virtual void GiveFlowers() = 0;
	virtual void GiveChocolate() = 0;
};

class SchoolGirl
{
public:
	string name;
};

class Pursuit:public Givegift
{
protected:
	SchoolGirl *mm;
public:
	Pursuit(void);
	Pursuit(SchoolGirl *mm)
	{
		this->mm = mm;
	}
	~Pursuit(void);

	void GiveDolls()
	{
		cout<<mm->name<<"ËÍÄãÑóÍÞÍÞ   ";
	}

	void GiveFlowers()
	{
		cout<<mm->name<<"ËÍÄãÏÊ»¨   ";
	}

	void GiveChocolate()
	{
		cout<<mm->name<<"ËÍÄãÇÉ¿ËÁ¦   ";
	}
};

class Proxy:Givegift
{
public:
	Pursuit *gg;

	Proxy(SchoolGirl *mm)
	{
		gg = new Pursuit(mm);
	}

	void GiveDolls()
	{
		gg->GiveDolls();
	}

	void GiveFlowers()
	{
		gg->GiveFlowers();
	}

	void GiveChocolate()
	{
		gg->GiveChocolate();
	}
};