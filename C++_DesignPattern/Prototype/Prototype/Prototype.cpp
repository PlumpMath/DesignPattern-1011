// Prototype.cpp : 定义控制台应用程序的入口点。
//

#include "stdafx.h"
#include "WorkExperience.h"

int _tmain(int argc, _TCHAR* argv[])
{
	Resume* a = new Resume("大鸟");
	a->SetPersonalInfo("男","29");  
    a->SetWorkExperience("1998-2000","XX公司"); 

	Resume* b = a->Clone();  
    b->SetWorkExperience("1998-2006","YY公司"); 

	Resume* c=b->Clone();  
    c->SetPersonalInfo("男","24");  
    c->SetWorkExperience("1998-2003","ZZ公司");  

	a->Display();  
    b->Display();  
    c->Display();  
  
    delete a;  
    delete b;  
    delete c;  
    a=b=c=NULL;  
	return 0;
}

