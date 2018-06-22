## Day 38 ##

### Weighted Uniform Strings ###

Example from [HackerRank](https://www.hackerrank.com/challenges/weighted-uniform-string/problem).

**Challenge**

A weighted string is a string of lowercase English letters where each letter has a weight. Character weights are 1 to 26 from a to z.

We define the following terms:

| word  | value           |
|-------|-----------------|
| apple | 1+16+16+12+5=50 |
| hack  | 8+1+3+11=23     |
| watch | 23+1+20+3+8=53  |
| ccccc | 3+3+3+3+3=15    |
| aaa   | 1+1+1=3         |
| zzzz  | 26+26+26+26=104 |


The _weight_ of a string is the sum of the weights of all the string's characters. For example:

A uniform string consists of a single character repeated _zero_ or _more_ times. For example, **ccc** and **a** are uniform strings, but bcb and cd are not.

Given a string, _s_ , let _U_ be the set of weights for all possible uniform contiguous substrings of string _s_. You have to answer _n_ queries, where each query _i_ consists of a single integer, _x[i]_. For each query, print **Yes** on a new line if _x[i]_ is an element of _U_ ; otherwise, print **No** instead.

**Input Format**

The first line contains a string _s_, the original string.
The second line contains an integer _n_, the number of queries.
Each of the next _n_ lines contains an integer _x[i]_, the weight of a uniform substring of _s_ that may or may not exist.

_Constraints_

+ 1 <= |_s_|,_n_ <= 10^5
+ 1 <= _x[i]_ <= 10^7
+ _s_ will only contain lowercase English letters, ascii[a-z].

**Output Format**

Print _n_ lines. For each query, print **Yes** on a new line if _x[i]_ is an element of _U_. Otherwise, print **No**.

_Sample Input 0_

abccddde
6
1
3
12
5
9
10

_Sample Output 0_

Yes
Yes
Yes
Yes
No
No

_Explanation 0_

The weights of every possible uniform substring in the string **abccddde** are shown below:

| Uniform substring  | weight           |
|-------|-----------------|
| a | 1 |
| b  | 2    |
| c | 3 |
| cc | 3+3=6 |
| d | 4 |
| dd | 4+4=8 |
| ddd | 4+4+4=12 |
| e | 5 |

We print **Yes** on the first four lines because the first four queries match weights of uniform substrings of _s_. We print **No** for the last two queries because there are no uniform substrings in that have those weights.

Note that while _de_ is a substring of _s_ that would have a weight of _9_, it is **not** a _uniform substring_.

Note that we are only dealing with contiguous substrings. So ccc is not a substring of the string ccxxc.
