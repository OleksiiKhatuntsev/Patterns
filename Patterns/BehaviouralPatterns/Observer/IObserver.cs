using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.BehaviouralPatterns.Observer
{
    public interface IObserver
    {
        void Subscribe();

        void UnSubscribe();
    }
}
