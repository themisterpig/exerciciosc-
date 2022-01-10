string s = "()[]{}";
string [] open = new string[3] {"(","[","{"};
string [] close = new string[3] {")","]","}"};
    int indexopen=0;
    string closed="";
    string openned="";
        for(int i=0;i<s.Lengh;i=i+2){
            openned = s[i].ToString();
            indexopen = Array.IndexOf(open,openned);
            Console.WriteLine("{0} {1}",openned,indexopen);
            
            
            if(indexopen==-1){
            break;
            }else{
                for(int j=i+1;j<s.Length;j++){
                    closed = s[j].ToString();
                    if(openned.CompareTo(open[0])==0){
                     closed=close[0];
                     
                    }else if (openned.CompareTo(open[1])==0){
                        closed = close[1];
                        
                    }else if(openned.CompareTo(open[2])==0){
                        closed = close[2];
                        
                    }
                    
                }
                int indexclose = s.IndexOf(closed);
                
                if(indexclose==-1){
                indexopen=-1;
                break;
                }/*else{
                    if(indexclose-indexopen==1 || indexclose-indexopen==3){
                        s = s.Replace(openned, string.Empty);
                        s = s.Replace(closed, string.Empty);
                    }
                }*/
                    
            }
            
            
        }
        Console.WriteLine("asd");
        Console.WriteLine(s);
        bool result = (indexopen==-1) ? true:false;
        