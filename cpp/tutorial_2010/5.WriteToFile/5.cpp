#include <iostream>
#include <fstream>

int main(){
    std::ofstream myFile;
    myFile.open("testFile.txt");//File will be created if it does not exist
    myFile << "Writing this to a file.\n";
    myFile.close();

    return 0;
}
