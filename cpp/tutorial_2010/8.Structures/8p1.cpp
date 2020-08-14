#include <iostream>

struct Point{
    int x,y;
};

int main(){
    Point a;
    a.x = 7;
    a.y = 9;
    
    std::cout << "a.x=" << a.x << std::endl << "a.y=" << a.y << std::endl;

    return 0;
}
