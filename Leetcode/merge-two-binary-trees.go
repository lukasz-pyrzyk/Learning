/**
 * Definition for a binary tree node.
 * type TreeNode struct {
 *     Val int
 *     Left *TreeNode
 *     Right *TreeNode
 * }
 */
 func mergeTrees(t1 *TreeNode, t2 *TreeNode) *TreeNode {
    if t1 == nil && t2 == nil {
        return nil;
    }

   var lt1, lt2, rt1, rt2 *TreeNode;
   node := &TreeNode{};
   if t1 != nil {
       node.Val += t1.Val;
       lt1 = t1.Left;
       rt1 = t1.Right;
   }
   if t2 != nil {
       node.Val += t2.Val;
       lt2 = t2.Left;
       rt2 = t2.Right;
   }
   node.Left = mergeTrees(lt1, lt2);
   node.Right = mergeTrees(rt1, rt2);
   return node;
}