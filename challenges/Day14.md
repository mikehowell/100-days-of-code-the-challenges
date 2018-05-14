## Day 14 ##

### Super Reduced String ###

Example from [HackerRank](https://www.hackerrank.com/challenges/reduced-string/problem).

Steve has a string of lowercase characters in range ascii[‘a’..’z’]. He wants to reduce the string to its shortest length by doing a series of operations in which he selects a pair of adjacent lowercase letters that match, and then he deletes them. For instance, the string aab could be shortened to b in one operation.

Steve’s task is to delete as many characters as possible using this method and print the resulting string. If the final string is empty, print Empty String

**Input Format**

    A single string, _s_.

**Constraints**

    1 <= n <= 1000

**Output Format**

    If the final string is empty, print **Empty String**; otherwise, print the final non-reducible string.

**Sample Input 0**

    aaabccddd

**Sample Output 0**

    abd

**Explanation 0**

**Sample Input**

    aaabccddd

**Sample Output 0**

    abd

**Explanation**

Steve performs the following sequence of operations to get the final string:

    aaabccddd → abccddd → abddd → abd

**Sample Input 1**

    aa

**Sample Output 1**

    Empty String

**Explanation 1**

**Sample Input 1**

    aa

**Sample Output 1**

    Empty String

**Explanation 1**

    aa → Empty String

**Sample Input 2**

    baab

**Sample Output 2**

    Empty String

**Explanation 2**

**Sample Input 1**

    baab

**Sample Output 1**

    Empty String

**Explanation 1**

    baab → bb → Empty String
