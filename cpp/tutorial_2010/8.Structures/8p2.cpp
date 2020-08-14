#include <iostream>
#include <string>

struct Human{
    std::string name;
    int age;
};

struct Pet{
    std::string type;
    std::string name;
    double weight;
    Human owner;
};


int main(){
    Human Fred;
    Fred.name = "Fred";//Obviously ...
    Fred.age = 13;
    
    Pet Max;
    Max.type = "Dog";
    Max.name = "Maximilain";// ^.^
    Max.owner = Fred;
    //I didn't set any weight
    
    std::cout << Max.owner.name << " has a " << Max.type << std::endl;

    return 0;
}
