# very simple Makefile to build and run a single-file program using Mono

prg=gcd
exe=$(prg).exe
src=$(prg).cs

all: $(exe)

run: $(exe)
	mono $(exe) 75 25

test: $(exe)
	sh ./test.sh

clean:
	-rm $(exe)

$(exe): $(src)
	mcs -out:$(exe) $(src)

