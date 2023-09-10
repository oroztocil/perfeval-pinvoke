#include <algorithm>
#include <iostream>
#include <string>

#include "bench_lib.h"

void Hello() { std::cout << "Do you want to know the answer to the ultimate question of life, the universe, and everything?" << std::endl; }

int Answer() { return 42; }

int Mul2(int x) { return x * 2; }

void ShoutAtMe(const char* input) {
    std::string str(input);
    std::transform(str.begin(), str.end(), str.begin(), ::toupper);
    std::cout << str << std::endl;
}