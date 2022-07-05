namespace AlgorithmApi.Services
{
    public class NVazirService
    {
        public Array col;
        public List<int> answers = new List<int>();
        static int N;
        public NVazirService(int n)
        {
            col = Array.CreateInstance(typeof(int), new int[1] { n }, new int[1] { 1 });
            // col = (int[])Array.CreateInstance(typeof(int), N, 1);
            N = n;
           

        }
        public void Queens(int i)
        {
            if (Promising(i))
            {

                if (i == N)
                {

                    foreach (var item in col)
                    {
                        answers.Add((int)item);
                    }
                    return;
                }
                    
                else
                {
                    i++;
                    for (int j = 1; j <= N; j++)
                    {
                        col.SetValue(j, i);
                        Queens(i);
                    }

                }
            }
        }
        public bool Promising(int i)
        {
            int k;
            bool check;
            k = 1;
            check = true;
            while (k < i && check)
            {
                int col_i = Convert.ToInt32(col.GetValue(i));
                int col_k = Convert.ToInt32(col.GetValue(k));

                if (col_i == col_k || Math.Abs(col_i - col_k) == i - k)
                    check = false;
                k++;
            }
            return check;
        }
        //public void Queens(int i)
        //{
        //    //if (i == N)
        //    //    return;
        //    //else
        //    //{
        //    //    for (int p = 0; p < N; p++)
        //    //    {
        //    //        // if (Promising(i))
        //    //        {
        //    //            Col[i] = p;
        //    //            Queens(i + 1);
        //    //        }
        //    //    }
        //    if (Promising(i))
        //    {
        //        if (i == N)//moshkel payan
        //            return;
        //        else
        //        {
        //            for (int j = 1; j <= col.Length; j++)
        //            {

        //                col.SetValue(j, i+1);
        //                Queens(i + 1);

        //            }
        //        }
        //    }

        //}
        //}

        //public bool Promising(int i)
        //{
        //    //int k;
        //    //bool check = true;
        //    //k = 0;
        //    //while (k < i && check == true)
        //    //{

        //    //    if ((Col[i] == Col[k]) || Math.Abs(Col[i] - Col[k]) == i - k)
        //    //        check = false;
        //    //    k++;
        //    //}
        //    for (int k = 1; k <= i; k++)
        //    {
        //        int other = Col[i - k];
        //        if (other == p || other == p - i || other == p + i)
        //        {
        //            return false;
        //        }
        //        return check;
        //    }
        //}
    }
}
