#include <iostream>

int main(){
    int age;
    std::cout << "Please enter your age and then press Enter:";
    std::cin >> age;
    std::cout << "Ten years from now you'll be " << (age + 10);
    
    return 0;
}
