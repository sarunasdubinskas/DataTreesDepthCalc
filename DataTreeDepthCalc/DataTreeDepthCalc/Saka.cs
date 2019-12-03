using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataTreeDepthCalc
{
    class Saka
    {
        private int depth = 0;
        private int maxDepth = 0;

        private List<Saka> sakos;

        public Saka()
        {
            sakos = new List<Saka>();
        }
        public void AddBranch(Saka saka)
        {
            sakos.Add(saka);
        }
        
        public int BranchDepth()
        {
            if (sakos.Count > 0)
            {
                foreach (Saka saka in sakos)
                {
                    depth = saka.BranchDepth();
                    if (maxDepth < depth)
                    {
                        maxDepth = depth+1;
                    }
                }
            }
            else
            {
                return 1;
            }
            return maxDepth;
        }
    }
}
