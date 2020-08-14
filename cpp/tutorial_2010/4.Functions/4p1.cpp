#include <iostream>

long factorial(int n){
    if(n == 0) return 1;
    else return n*factorial(n-1);
}

int main(){
    int n;
    std::cout << "n=";
    std::cin >> n;
    std::cout << "n!=" << factorial(n);

    return 0;
}
