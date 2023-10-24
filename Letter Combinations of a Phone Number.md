# Intuition
<!-- Describe your first thoughts on how to solve this problem. -->
String Combination problem are easy to solve using recursive way.
# Approach
<!-- Describe your approach to solving the problem. -->
1. we declare the keypad pattern.
2. then we need a List<string> variable to store our final reuslt;
3. then we write our function which will call itself(recursive way)
    
    - Initial call (emptyString, digits, zero index)    


# Code
```
public class Solution {
    private IList<string> result = new List<string> ();

    public IList<string> LetterCombinations(string digits) {
        if  (digits.Length > 0) Repeat("",digits,0);
        return result;
    }

    Dictionary<char, char[]> keypad = new Dictionary<char, char[]> {
        {'2', new char[]{'a', 'b', 'c'}}, 
        {'3', new char[]{'d', 'e', 'f'}}, 
        {'4', new char[] {'g', 'h', 'i'}}, 
        {'5', new char[] {'j', 'k', 'l'}}, 
        {'6', new char[] {'m', 'n', 'o'}}, 
        {'7', new char[] {'p', 'q', 'r', 's'}}, 
        {'8', new char[] {'t', 'u', 'v'}}, 
        {'9', new char[] {'w', 'x', 'y', 'z'}}
        };


    public void Repeat(string current, string digits, int i){
        if(i>=digits.Length) result.Add(current);
        else{
            var chars = keypad[digits[i]];
            foreach(var c in chars){
                Repeat(current+c, digits, i+1);
            }
        }
    }
}
```