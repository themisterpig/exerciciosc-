int[] flowerbed = { 1, 0, 0, 0, 1};
 int j = 0;
        int x = 0;
        if(flowerbed[0]== 0 && flowerbed[1]== 0){
            x=x+1;
        }
        if(flowerbed[flowerbed.Length-1] == 0 && flowerbed[flowerbed.Length-2]== 0){
            x=x+1;
        }
        
        for(int i=2; i<flowerbed.Length-2;i++){
           if(flowerbed[i]==0){
                j=j+1;
            }else{
                j=0;
            }
            
            if(j==2){
                x=x+1;
                j = 0;
            }
        }
        int n= 2;
        Console.WriteLine(x);
        if(n <= x){
            Console.WriteLine(true);
        }else{
            Console.WriteLine(false);
        }

    
        