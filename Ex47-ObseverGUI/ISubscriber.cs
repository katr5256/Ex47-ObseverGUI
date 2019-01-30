using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex47_ObseverGUI
{
    public interface ISubscriber
    {
        void Update(IPublisher publisher, string message)
        {

        }
    }
}
