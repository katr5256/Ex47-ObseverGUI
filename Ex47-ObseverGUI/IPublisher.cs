using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex47_ObseverGUI
{
    public interface IPublisher
    {
        void RegisterSubscriber(ISubscriber observer);
        void RemoveSubscriber(ISubscriber observer);
        void NotifySubscriber(string message);
    }
}
