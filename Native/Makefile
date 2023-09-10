CXX ?= g++
CXXFLAGS = -Wall -std=c++17 -fPIC
LDFLAGS = -shared

SRC = bench_lib.cpp
HEADER = bench_lib.h

ifeq ($(OS),Windows_NT)
    LIB_EXT = dll
else
    UNAME_S := $(shell uname -s)
    ifeq ($(UNAME_S),Linux)
        LIB_EXT = so
        LDFLAGS = -shared
    endif
endif

OUTPUT = bench_lib.$(LIB_EXT)

all: $(OUTPUT)

$(OUTPUT): $(SRC) $(HEADER)
	$(CXX) $(CXXFLAGS) $(LDFLAGS) $(SRC) -o $(OUTPUT)

clean:
	rm -f $(OUTPUT)

.PHONY: all clean
