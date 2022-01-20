
int [] nums = {1,2,3,4,4,9,56,90};
int target = 8;
int [] dummy = new int[2];
int num = 0;
bool result=false;
for(int i = 0;i<nums.Length;i++){
    num=nums[i];
    for(int j = 1;j<nums.Length;j++){
        
        if(i!=j && num+nums[j]==target){
            result=true;
            dummy[0]=i+1;
            dummy[1]=j+1;
            break;
        }
        
    }
    if(result){
        break;
    }
}

   
foreach (int a in dummy){
    Console.Write(a);
}
