
public class Solution {
    int N;
    List<string> result = new();
    public IList<string> GenerateParenthesis(int n) {
        N=n;
        Repeat("(",1,0);
        return result;
    }

    private void Repeat(string current, int open, int close){
        if(open==close && close==N) {
            result.Add(current); return;
        }
        if(open<N){
            Repeat(current+"(", open+1, close);
        }
        if(close<open){
            Repeat(current+")", open, close+1);
        }
    }
}
