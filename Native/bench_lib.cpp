#include <algorithm>
#include <iostream>
#include <string>

#include <stdio.h>
#include "bench_lib.h"

void Hello() { printf("Do you want to know the answer to the ultimate question of life, the universe, and everything?\n"); }
void Hello2 () { std::cout << "Do you want to know the answer to the ultimate question of life, the universe, and everything?" << std::endl; }

int Answer() { return 42; }

int Mul2(int x) { return x * 2; }

void ShoutAtMe(const char* input) {
    std::string str(input);
    std::transform(str.begin(), str.end(), str.begin(), ::toupper);
    std::cout << str << std::endl;
}

int main() {
    Hello();

    std::string str = "Blbabla";

    printf("Test: %s\n", str.c_str());

    Hello2();


    return 42;
}