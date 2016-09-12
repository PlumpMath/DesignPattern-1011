#pragma once

class AbstractFactory
{
public:
	AbstractFactory(void);
	~AbstractFactory(void);
};

class COperation
{
public:
	double NumberA;
	double NumberB;
	virtual double GetResult()
	{
		double Result = 0;
		return Result;
	}
};

class AddOperation:public COperation
{
public:
	virtual double GetResult()
	{
		return NumberA + NumberB; 
	}
};

class SubOperation:public COperation
{
public:
	virtual double GetResult()
	{
		return NumberA - NumberB;
	}
};

class CCalculatorFactory
{
public:
	static COperation * Create(char Op)
	{
		COperation * oper;
		switch(Op)
		{
		case '+':
			oper = new AddOperation();
			break;
		case '-':
			oper = new SubOperation();
			break;
		}
		return oper;
	}
};

