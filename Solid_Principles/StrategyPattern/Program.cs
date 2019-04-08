using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    /*
     * STRATEGY PATTERN DEFINES AS 
     *
     * Strategy  (SortStrategy) :- declares an interface common to all supported algorithms. Context uses this interface to call the algorithm
                                   defined by a ConcreteStrategy
        ConcreteStrategy        :-(QuickSort, ShellSort, MergeSort) | implements the algorithm using the Strategy interface
        Context  (SortedList)   :-is configured with a ConcreteStrategy object  maintains a reference to a Strategy object may define an interface 
        that lets Strategy access its data.
     */
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
