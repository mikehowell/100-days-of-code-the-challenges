## Day 13 ##

### Mini-Max Sum ###

Example from [HackerRank](https://www.hackerrank.com/challenges/mini-max-sum/problem).

Given five positive integers, find the minimum and maximum values that can be calculated by summing exactly four of the five integers. Then print the respective minimum and maximum values as a single line of two space-separated long integers.

**Input Format**

    A single line of five space-separated integers.

**Constraints**

    Each integer is in the inclusive range [1...10^9].

**Output Format**

Print two space-separated _long_ integers denoting the respective minimum and maximum values that can be calculated by summing exactly four of the five integers. (The output can be greater than a 32 bit integer.)

*Sample Input*

1 2 3 4 5

*Sample Output*

10 14

*Explanation*

Our initial numbers are 1, 2, 3, 4, and 5. We can calculate the following sums using _four_ of the five integers:

    If we sum everything except 1, our sum is 14.
    If we sum everything except 2, our sum is 13.
    If we sum everything except 3, our sum is 12.
    If we sum everything except 4, our sum is 11.
    If we sum everything except 5, our sum is 10.

*Hints*: Beware of integer overflow! Use *64-bit* Integer.
