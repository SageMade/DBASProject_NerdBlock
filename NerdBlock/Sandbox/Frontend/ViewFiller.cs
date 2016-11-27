using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdBlock.Sandbox.Frontend
{
    public interface ViewFiller<T> where T : new()
    {
        void Fill(T value);
    }
}
