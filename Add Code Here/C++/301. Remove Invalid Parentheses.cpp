Given a string s that contains parentheses and letters, remove the minimum number of invalid parentheses to make the input string valid.

Return all the possible results. You may return the answer in any order.

 

Example 1:

Input: s = "()())()"
Output: ["(())()","()()()"]
Example 2:

Input: s = "(a)())()"
Output: ["(a())()","(a)()()"]
Example 3:

Input: s = ")("
Output: [""]

-----------------------
class Remove_para {
public:
    
    vector<string> res;
    unordered_map<string,int> mp;
    
    int getInValid(string s)
    {
        stack<char> stck;
        int i = 0;
        while(i < s.size())
        {
            if(s[i] == '(')
                stck.push('(');
            else if(s[i] == ')')
            {
                if(stck.size() > 0 && stck.top() == '(')
                    stck.pop();
                else
                    stck.push(')');
            }
            i++;
        }
        return stck.size();
    }
    
    void solution(string s,int minInv){

        if(mp[s] != 0) 
            return;
        else
            mp[s]++; //mp[s] = 1
        //base case
        if(minInv < 0){
            return;
        }
        if(minInv == 0)
        {
            if(!getInValid(s))
                res.push_back(s);
            return;
        }
        
        for(int i=0; i<s.size(); i++)
        {
            string left = s.substr(0,i);
            string right = s.substr(i+1);
            solution(left+right, minInv-1);
        }
        return;
    }
    
    vector<string> removeInvalidParentheses(string s) 
    {
        solution(s, getInValid(s));
        return res;
    }
};
