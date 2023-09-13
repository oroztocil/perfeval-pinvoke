#include <algorithm>
#include <cstring>
#include <iostream>
#include <string>

#include "bench_lib.h"

void Empty() {}

int32_t ConstantInt() {
	return 42;
}

int32_t MultiplyInt(int32_t a, int32_t b) {
	return a * b;
}

bool NegateBool(bool value) {
	return !value;
}

int SumIntArray(int32_t *arr, int32_t count) {
	int32_t acc = 0;

	for (int32_t i = 0; i < count; i++) {
		acc += arr[i];
	}

	return acc;
}

double SumDoubleArray(double *arr, int32_t count) {
	double acc = 0;

	for (int32_t i = 0; i < count; i++) {
		acc += arr[i];
	}

	return acc;
}

int StringLength8(const char *str) {
	return (int)strlen(str);
}


int StringLength16(const char16_t *str) {
	return (int)std::char_traits<char16_t>::length(str);
}

void StringToUppercase(char *str, int32_t length) {
	for (int32_t i = 0; i < length; i++) {
		str[i] = toupper(str[i]);
	}
}


