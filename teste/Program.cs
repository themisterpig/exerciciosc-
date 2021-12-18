string [] strs = new string[2]  {"cira","cara"};
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
    
    Console.WriteLine(previousnum);
