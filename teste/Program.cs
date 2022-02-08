int[] nums = { 2, 2, 1};

int num;
        int r =0;
        if(nums.Length >2){
            for(int a=0; a<nums.Length;a++){
                num=nums[a];
                for(int i =1;i<nums.Length;i++){
                    if(num==nums[i]){
                        break;
                        r++;
                    }
                   
                    
                }
                if(r==0){
                    return num;
                }
        }
