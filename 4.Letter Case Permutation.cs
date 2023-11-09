public class Solution {
    IList<string> result = new List<string>();
    int len;
    public IList<string> LetterCasePermutation(string s) {
        s = s.ToLower();
        len = s.Length;
        Repeat(s, "", 0);
        return result;
    }

    private void Repeat(string s, string current, int pos ){
        if(s.Length==pos){
            result.Add(current); return;
        }
        char tmp = s[pos];
        Repeat(s,current+tmp,pos+1);
        if(Char.IsLetter(tmp)){
            var a = (tmp+"").ToUpper();
            Repeat(s,current+a, pos+1);
        }
        

    }
}