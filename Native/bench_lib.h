#pragma once

#include <cstdint>
#include <uchar.h>

extern "C" {
	// Primitive-type functions
	void Empty();
	int32_t ConstantInt();
	int32_t MultiplyInt(int32_t a, int32_t b);
	bool NegateBool(bool value);

	// Array functions
	int SumIntArray(int32_t *arr, int32_t count);
	double SumDoubleArray(double *arr, int32_t count);

	// String functions
	int StringLength8(const char *str);
	int StringLength16(const char16_t *str);
	//const char *StringToUppercase(const char *str);

	// Struct functions
}
