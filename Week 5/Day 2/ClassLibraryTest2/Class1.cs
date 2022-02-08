using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTest2
{
    // dll : dynamic linked library

    internal class internalClass
    {

    }

    public abstract class Beverage
    {
        public string BevName { get; set; }
        public int Temp { get; set; }

        public abstract void MakeBeverage();
        public virtual void CalculateCost()
        {
            // discount
        }
    }

    public class Coffee : Beverage
    {
        public string Bean { get; set; }
        private int Calories { get; set; }
        protected int GrindSize { get; set; }
        public override void MakeBeverage()
        {
            // logic
        }
        public override void CalculateCost()
        {
            base.CalculateCost();
        }
    }

    public sealed class Espresso : Coffee
    {
        
        public sealed override void CalculateCost()
        {
            base.CalculateCost();
        }
    }
}
