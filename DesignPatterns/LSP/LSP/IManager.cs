using System;
using System.Collections.Generic;
using System.Text;

namespace LSP
{
    public interface IManager : IEmployee
    {
        void GeneratePerformanceReview();
    }
}
