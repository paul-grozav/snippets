#include <iostream>
#include <string>

class Dog{
    public:
        std::string name;
    
        void eat(std::string food){
    	    std::cout << name << " eats " << food << std::endl;
        }
};

class Human{
    public:
        Dog myDog;
    
        void feedTheDogWith(std::string food){
	    std::cout << "O.K. I'll feed the dog ..." << std::endl;
    	    myDog.eat(food);
        }
};

int main(){
    Dog Max;
    Max.name = "Maximilian";
    
    Human Fred;
    Fred.myDog = Max;
    Fred.feedTheDogWith("popcorn");

    return 0;
}
