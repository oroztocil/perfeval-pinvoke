#pragma once

#include <cstdint>
#include <uchar.h>

struct BlittableStruct {
	int32_t a;
	int32_t b;
	int32_t result;
};

struct NonBlittableStruct {
	int32_t number;
	int32_t numberArraySize;
	int32_t *numberArray;
	char *text;
	bool flag;
};

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
	BlittableStruct SumIntsInStruct_Return(BlittableStruct data);
	void SumIntsInStruct_Pointer(BlittableStruct *data);
	void UpdateNonBlittableStruct(NonBlittableStruct *data);
}
