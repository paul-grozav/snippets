#include <iostream>
#include <fstream>

int main(){
    std::ifstream myFile("testFile");
    if(myFile.is_open()){
	char *buffer = new char[5];
	myFile.read(buffer, 5);
	std::cout << "First 5 bytes are:" << buffer;
    }else std::cout << "Could not open file testFile from current directory!" << std::endl;

    return 0;
}
