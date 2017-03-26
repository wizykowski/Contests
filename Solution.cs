using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows;
using System.Diagnostics;
using Deadline;
using System.Threading;

public class Solution : SolutionBase
{
    public Solution(IOClient client, int time = 0)
        : base(client, time)
    { }

    public override void GetData()
    {
        base.GetData();
    }

    public override bool Act()
    {
        SolveMini(0);
        ioClient.SaveResult(best);
        TakeBestAction();
        return true;
    }

    public bool SolveMini(int seed)
    {
        best = new Result(state);

        // solution

        return true;
    }
}
