#include <iostream>
#include <string>

int main(){
    std::string a("This is just a Test");
    std::cout << "a=" << a << std::endl;
    std::cout << "a.size()=" << a.size() << std::endl;
    std::cout << "a.length()=" << a.length() << std::endl;
    std::cout << "a.empty()=" << a.empty() << std::endl;//0=false and 1=true
    a.clear();//a is now empty
    std::cout << "a.empty()=" << a.empty() << std::endl;
    a = "A new valu";//put a new value
    std::cout << "a=" << a << std::endl;//oops!
    a += "E";// or 'E'
    std::cout << "a=" << a << std::endl;//that's better
    
    std::cout << std::endl << "Characters in a:" << std::endl;
    for(int i=0; i< a.length(); i++)
	std::cout << "a.at(" << i << ")=" << a.at(i) << "\ta[" << i << "]=" << a[i] << std::endl;
	
    a.insert(2, ": CRAB", 1);//insert 1 character from this string in a at position 2
    std::cout << std::endl << "a=" << a << std::endl;
    
    a.erase(2, 1);//erase 1 character starting at position 2
    std::cout << "a=" << a << std::endl;
    
    a.replace(1, 4, "n old");//Replace characters from 1 to 4 with "n old"
    std::cout << "a=" << a << std::endl;
    
    int pos = int(a.find("old"));//position of first occurrence in a
    std::cout << "\"old\" was first found at position " << pos << std::endl;
    
    pos = int(a.rfind("l"));//last occurrence of "l"
    std::cout << "\"l\" was last found at position " << pos << std::endl;
    
    std::cout << "a.substr(7,5)=" << a.substr(7,5) << std::endl;//substr(7, 5) returns a string from position 7 and of length 5
    

    return 0;
}
