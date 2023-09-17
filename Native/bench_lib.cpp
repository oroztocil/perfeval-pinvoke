#include <algorithm>
#include <cstring>
#include <iostream>
#include <string>

#include "bench_lib.h"

void Empty_Void() {}

void Empty_IntArray(int32_t *arr, int32_t count) {}

void Empty_String(const char *str) {}

int32_t ConstantInt() {
	return 42;
}

int32_t MultiplyInt(int32_t a, int32_t b) {
	return a * b;
}

bool NegateBool(bool value) {
	return !value;
}

int SumIntArray(const int32_t *arr, int32_t count) {
	int32_t acc = 0;

	for (int32_t i = 0; i < count; i++) {
		acc += arr[i];
	}

	return acc;
}

void FillIntArray(int32_t *arr, int32_t count) {
	for (int32_t i = 0; i < count; i++) {
		arr[i] = i;
	}
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

BlittableStruct SumIntsInStruct_Return(BlittableStruct data) {
	data.result = data.a + data.b;
	return data;
}


void SumIntsInStruct_Pointer(BlittableStruct *data) {
	data->result = data->a + data->b;
}

void UpdateNonBlittableStruct(NonBlittableStruct *data) {
	data->number++;
	data->flag = !data->flag;
	
	if (data->text[0] != 0) {
		data->text[0] = 'X';
	}

	for (int i = 0; i < data->numberArraySize; i++) {
		data->numberArray[i]++;
	}
}
