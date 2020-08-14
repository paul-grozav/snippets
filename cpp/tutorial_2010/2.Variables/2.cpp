#include <iostream>

int main(){
    //Integer
    int a = 7;
    std::cout << "a=" << a << std::endl;
    
    //Long
    long b = 999999999;
    std::cout << "b=" << b << std::endl;
    
    //Char
    char c = 65;//65 is the ASCII code for char 'A'
    std::cout << "c=" << c << std::endl;
    c = '@';
    std::cout << "c=" << c << std::endl;
    
    //Char Array
    char *ca = "You can put your text here";
    std::cout << "ca[]=" << ca << std::endl;
    std::cout << "std::strlen(ca)=" << std::strlen(ca) << std::endl;
    
    //Double
    double d = 0.2;
    std::cout << "d=" << --d << std::endl;//--d is -0.8
}
