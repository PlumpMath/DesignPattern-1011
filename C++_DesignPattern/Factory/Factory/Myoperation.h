#pragma once

class Operation
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

class AddOperation:public Operation
{
public:
	double GetResult()
	{
		return NumberA + NumberB; 
	}
};

class SubOperation:public Operation
{
public:
	double GetResult()
	{
		return NumberA - NumberB;
	}
};

class Factory
{
public:
	virtual Operation* CreateOperation()=0;
};

class AddFactory:public Factory
{
public:
	Operation* CreateOperation()
	{
		return new AddOperation();
	}
};

class SubFactory:public Factory
{
public:
	Operation* CreateOperation()
	{
		return new SubOperation();
	}
};
