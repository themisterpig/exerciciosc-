public class Solution {
    public string LongestCommonPrefix(string[] strs) {
     string a = strs[0];
    int num = 0;
    int previousnum=a.Length;
        

        
    foreach(string x in strs){
    int result = (a.Length < x.Length) ? a.Length:x.Length;
        
        for(int i = 0; i<result; i++){
            
            if(a[i].CompareTo(x[i])==0){
                num++;
            }else{
                break;
            }
            
        }
    if(previousnum > num){
    previousnum=num;
    }
    num=0;
    
    }
     
    string word= "";    
        if(previousnum==0){
            return word;
        }else{
            for(int i=0;i<previousnum;i++){
            word=word+a[i];
        }
            return word;
        }
    }
}