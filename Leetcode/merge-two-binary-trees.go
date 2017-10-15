/**
 * Definition for a binary tree node.
 * type TreeNode struct {
 *     Val int
 *     Left *TreeNode
 *     Right *TreeNode
 * }
 */
 func mergeTrees(t1 *TreeNode, t2 *TreeNode) *TreeNode {
    if t1 == nil && t1 == nil return nil;

    lt1 := nil;
    rt1 := nil;
    lt2 := nil;
    rt2 := nil;
    node := TreeNode{};
    if t1 != nil
    {
        val += t1.Val;
        lt1 = t1.Left;
        rt1 = t1.Right;
    }
    if t2 != nil
    {
        val += t2.Val;
        lt2 = t2.Left;
        rt1 = t1.Right;
    }
    
}