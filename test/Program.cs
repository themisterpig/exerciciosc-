using System;
public class Solution {
       public bool IsValid(string input)
        {
         bool valid = Quantaty(input);
            
        if (valid){
            
            return true;
        }

        return valid;
        }

        public bool Quantaty(string input)
        {
            string[] str1 = new string[6] {"(", ")", "[", "]", "{", "}"};
            bool valid=false;
            int i = 0;
            int j = 1;
            int idx1,idx2;

            if(input.Length %2 !=0){
                return false;
            }

            if(input.Contains(str1[i]) || input.Contains(str1[j])){
                if(input.Contains(str1[i]) && input.Contains(str1[j])){

                    idx1 = input.IndexOf(str1[i]);
                    idx2 = input.IndexOf(str1[j]);
                    if(idx2 == idx1+1 || idx2 >= idx1+3){
                        
                        valid=true;
                    }
                }else{
                    return false;
                    
                }
            }
            i++;
            j++;
            if(input.Contains(str1[i]) || input.Contains(str1[j])){
                if(input.Contains(str1[i]) && input.Contains(str1[j])){
                    idx1 = input.IndexOf(str1[i]);
                    idx2 = input.IndexOf(str1[j]);
                    if(idx2 == idx1+1 || idx2 >= idx1+3){
                        valid=true;
                    }
                }else{
                    return false;
                    
                }
            }
            i++;
            j++;
            if(input.Contains(str1[i]) || input.Contains(str1[j])){
                if(input.Contains(str1[i]) && input.Contains(str1[j])){
                    idx1 = input.IndexOf(str1[i]);
                    idx2 = input.IndexOf(str1[j]);
                    if(idx2 == idx1+1 || idx2 >= idx1+3){
                        valid=true;
                    }
                }else{
                    return false;
                    
                }
            }
            return valid;
        }
}


class teste {
  
    // Main Method
    static public void Main(String[] args)
    {
        
        Solution solution = new Solution();
        Console.WriteLine("abc: {0}",solution.IsValid("()"));
    }
}