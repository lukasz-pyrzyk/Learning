public class QuickFindUF 
{
    private int[] ids;

    public ClassName(int n)
    {
        ids = new int[n];
        for (int i = 0; i < n; i++)
        {
            ids[i] = i;
        }
    }

    public bool Connected(int p, int q) => ids[p] == ids[q];

    public void Union(int p, int q)
    {
        int pId = ids[p];
        int qId = ids[q];
        for (int i = 0; i < ids.Length; i++)
        {
            if(ids[i] = pId)
            {
                ids[i] = qId;
            }
        }
    }
}