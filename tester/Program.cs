

static void printArray(int [] nums){
    for(int i=0;i<nums.Length;i++){
        Console.WriteLine(nums[i] + " ");
    }
}

static void swap(int []nums,int i, int j){
    int temp = nums[i];
    nums[i] = nums[j];
    nums[j] = temp;
}
static void printPermutations(int[] nums,int cid){

    if(cid == nums.Length-1){
        Console.WriteLine(nums);
        return ;
    }
    for(int i=cid;i<nums.Length;i++){
        swap(nums, i, cid);
        printPermutations(nums,cid+1);
        swap(nums, i, cid);
    }

}


static void Main(String []args){
int [] nums = {1,2,3};
printPermutations(nums,0);
}

