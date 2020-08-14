#include <iostream>

int fib(int n);//you mention the function here
int n;//this variable is global => it's visible in all functions

int main(){
    std::cout << "n=";
    std::cin >> n;
    std::cout << "fib(n)=" << fib(n);

    return 0;
}

int fib(int n){//but the body is here
    if(n == 0) return 0;
    else if(n == 1) return 1;
    else if(n > 1) return fib(n-2)+fib(n-1);
    else return 0;//when n<0
}
