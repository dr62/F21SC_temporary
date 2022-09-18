#!/bin/bash

# function to check output from running $cmd against expected output
check () {
    #echo "Cmd: $cmd"
    echo "Output: \n$out"
    echo "Expected: \n$exp"
    if [ "$out" = "$exp" ]
    then echo ".. OK"
	 ok=$(( $ok + 1))
    else echo "** WRONG"
	 ret=1
    fi
    n=$(( $n + 1))
}

# name of the application to run
prg=matmult
# return code; 0 = ok, anything else is an error
ret=0
ok=0
n=0

# -------------------------------------------------------
# a sequence of unit tests

out="`mono ./${prg}.exe 8 2`"
# echo "$out"
exp=$(cat <<EOS
First Matrix:
[1,2,3]
[1,2,3]
[1,2,3]

Second Matrix:
[1,2,3]
[1,2,3]
[1,2,3]

Result of Matrix Multiplication:
[6,12,18]
[6,12,18]
[6,12,18]

First Matrix:
[1,2,3]
[7,3,4]

Second Matrix:
[5,2,1]
[7,2,1]
[4,2,8]

Result of Matrix Multiplication:
[31,12,27]
[72,28,42]

First Matrix:
[1,2,1]
[7,3,9]

Second Matrix:
[6,0,2]
[4,1,8]
[3,2,0]

Result of Matrix Multiplication:
[17,4,18]
[81,21,38]

First Matrix:
[1,2,3]
[7,3,4]

Second Matrix:
[5,2,1]
[7,2,1]
[4,2,8]

Result of Matrix Multiplication:
[31,12,27]
[72,28,42]
EOS
)
check


# return status code (0 for ok, 1 for not)
echo "$ok of $n tests are OK"
exit $ret
