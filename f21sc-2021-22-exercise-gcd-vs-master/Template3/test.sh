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
prg=gcd
# return code; 0 = ok, anything else is an error
ret=0
ok=0
n=0

# -------------------------------------------------------
# a sequence of unit tests

out="`mono ./${prg}.exe 8 2`"
# echo "$out"
exp=$(cat <<EOS
gcd(8,2) = 2
EOS
)
check

out="`mono ./${prg}.exe 75 25`"
# echo "$out"
exp=$(cat <<EOS
gcd(75,25) = 25
EOS
)
check

out="`mono ./${prg}.exe 18 93`"
# echo "$out"
exp=$(cat <<EOS
gcd(18,93) = 3
EOS
)
check

out="`mono ./${prg}.exe 234 9921`"
# echo "$out"
exp=$(cat <<EOS
gcd(234,9921) = 3
EOS
)
check

out="`mono ./${prg}.exe 18 93`"
# echo "$out"
exp=$(cat <<EOS
gcd(18,93) = 3
EOS
)
check

out="`mono ./${prg}.exe 1638 2380`"
# echo "$out"
exp=$(cat <<EOS
gcd(1638,2380) = 14
EOS
)
check

# return status code (0 for ok, 1 for not)
echo "$ok of $n tests are OK"
exit $ret
