# very simple Makefile to build and run a single-file program using Mono

prg=matmult
exe=$(prg).exe
src=$(prg).cs

all: $(exe)

run: $(exe)
	mono $(exe) 

test: $(exe)
	sh ./test.sh

clean:
	-rm $(exe)

$(exe): $(src)
	mcs -out:$(exe) $(src)

