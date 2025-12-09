public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();

        foreach(char cur in s) {
            if (stack.Count > 0) {
                char top = stack.Peek();
                if (check(top, cur)) {
                    stack.Pop();
                    continue;
                }
            }
            stack.Push(cur);
        }

        return stack.Count == 0;
    }

    public bool check(char top, char cur) {
        return (top == '(' && cur == ')') ||
               (top == '{' && cur == '}') ||
               (top == '[' && cur == ']');
    }
}