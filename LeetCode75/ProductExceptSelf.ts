function productExceptSelf(nums: number[]): number[] {
  const product = nums.reduce((acc, num) => (num === 0 ? acc : acc * num), 1);
  const zeroCount = nums.filter((num) => num === 0).length;

  return nums.map((num) => (zeroCount >= 2 ? 0 : zeroCount === 1 ? (num === 0 ? product : 0) : product / num));
}
