#include <iostream>

int main(){
    int avail = 0;
    char key;
    
    do{
	avail = std::cin.rdbuf()->in_avail();
//	std::cout << "key=" << avail << "|" << std::endl;
//	x++;
    }while(avail == 0);
    
    std::cout << "KEY PRESSED" << std::endl;

    return 0;
}
