# f21sc-testing-matmult-vs

C# exercise on matrix multiplication (see C# Fundamentals lab sheet)

This repo is a Visual Studio 2019 project, just switch to the master branch and open the solution file.

**Fork** and **Clone** this repo using the gitlab web interface. Then work in the local folder
that you get from cloning the project. Once finished coding, upload a version through your IDE,
or **Add** files, **Commit** changes, and **Push** everything using git from the commandline.
Once uploaded, the gitlab continuous integration (CI) engine will run automated tests, and will
report wether these tests have been successful or not.

Complete the code for the method `MatMult()` in `matmult.cs`.
Use the given test wrapper in `main()` to run the code.
Use the script `test.sh` to run automated tests (this is triggered automatically when uploading a version to gitlab).

Build the entire code:
> make all

Run one test case:
> make run

Run all test cases:
> make test

or
> sh ./test.sh

