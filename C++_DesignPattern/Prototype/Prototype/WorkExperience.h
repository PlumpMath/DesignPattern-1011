#pragma once
#include <iostream>
#include <string>
using namespace std;

class WorkExperience
{
private:
	string workDate;
	string company;
public:
	WorkExperience(void);
	~WorkExperience(void);
	WorkExperience(WorkExperience* work)
	{
		this->workDate = work->workDate;
		this->company = work->company;
	}
	std::string getWorkDate()  
    {  
        return workDate;  
    }  
    void setWorkDate(std::string workDate)  
    {  
        this->workDate=workDate;  
    }  
    std::string getCompany()  
    {  
        return company;  
    }  
    void setCompany(std::string company)  
    {  
        this->company=company;  
    }

	//clone
	WorkExperience* Clone()
	{
		return new WorkExperience(this);
	}
};

class Resume
{
private:
	string name;
	string sex;
	string age;
	string timeArea;
	string company;
	WorkExperience* work;
public:
	Resume(string name)
	{
		this->name = name;
		work = new WorkExperience();
	}
	~Resume()
	{
		if(work!=NULL)
			delete work;
	}
	Resume(WorkExperience* work)
	{
		this->work = work->Clone();
	}

	void SetPersonalInfo(std::string sex,std::string age)  
    {  
        this->sex=sex;  
        this->age=age;  
    }  
    void SetWorkExperience(std::string workDate,std::string company)  
    {  
        work->setWorkDate(workDate);  
        work->setCompany(company);  
    }

	void Display()
	{
		std::cout<<name<<"  "<<sex<<"  "<<age<<std::endl;  
        std::cout<<"工作经历  "<<work->getWorkDate()<<"  "<<work->getCompany()<<std::endl;  
	}

	Resume* Clone()
	{
		Resume* cloneResume = new Resume(work);
		cloneResume->name = this->name;
		cloneResume->name=this->name;  
        cloneResume->age=this->age;  
        cloneResume->sex=this->sex;  
        return cloneResume;
	}
};