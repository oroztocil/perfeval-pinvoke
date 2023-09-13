#pragma once

#include <cstdint>
#include <uchar.h>

extern "C" {
	// Primitive-type functions
	void Empty_Void();
	void Empty_IntArray(int32_t *arr, int32_t count);
	void Empty_String(const char *str);
	int32_t ConstantInt();
	int32_t MultiplyInt(int32_t a, int32_t b);
	bool NegateBool(bool value);

	// Array functions
	int SumIntArray(const int32_t *arr, int32_t count);
	void FillIntArray(int32_t *arr, int32_t count);

	// String functions
	int StringLength8(const char *str);
	int StringLength16(const char16_t *str);
	void StringToUppercase(char *str, int32_t length);

	// Struct functions
}
