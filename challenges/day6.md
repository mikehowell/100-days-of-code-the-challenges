## Day 6: ##
### ISBN Validations ###

Example from [http://www.programmr.com/challenges/isbn-validation](http://www.programmr.com/challenges/isbn-validation)

An ISBN number is legal if it consists of 10 digits and

d_1 + 2*d_2 + 3*d_3 + ... + 10*d_10 is a multiple of 11.

The ISBN number 0-201-31452-5 is valid.

1x5 + 2x2 + 3x5 + 4x4 + 5x1 + 6x3 + 7x1 + 8x0 + 9x2 + 10x0 = 88

and 88 is a multiple of 11.

Write a program which validates whether an ISBN number.

For Ex:

1) if user inputs 8535902775 then it should print "Valid"

2) if user inputs 1843369283 then it should print "Not Valid"
