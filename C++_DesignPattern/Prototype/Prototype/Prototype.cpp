// Prototype.cpp : �������̨Ӧ�ó������ڵ㡣
//

#include "stdafx.h"
#include "WorkExperience.h"

int _tmain(int argc, _TCHAR* argv[])
{
	Resume* a = new Resume("����");
	a->SetPersonalInfo("��","29");  
    a->SetWorkExperience("1998-2000","XX��˾"); 

	Resume* b = a->Clone();  
    b->SetWorkExperience("1998-2006","YY��˾"); 

	Resume* c=b->Clone();  
    c->SetPersonalInfo("��","24");  
    c->SetWorkExperience("1998-2003","ZZ��˾");  

	a->Display();  
    b->Display();  
    c->Display();  
  
    delete a;  
    delete b;  
    delete c;  
    a=b=c=NULL;  
	return 0;
}

