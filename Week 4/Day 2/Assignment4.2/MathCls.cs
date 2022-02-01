using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4._2
{
    internal class MathCls
    {
        // public properties

        public int IntNum1 { get; set; }
        public int IntNum2 { get; set; }
        public int IntNum3 { get; set; }
        public float FloatNum1 { get; set; }
        public float FloatNum2 { get; set; }
        public float FloatNum3 { get; set; }


        // public methods
        
        public int Add(int num1, int num2) // adds 2 ints
        {
            return num1 + num2;
        }

        public int Add(int num1, int num2, int num3) // adds 3 ints
        {
            return num1 + num2 + num3;
        }

        public float Multiply(float num1, float num2) // multiplies 2 floats
        {
            return num1 * num2;
        }

        public float Multiply(float num1, float num2, float num3) // multiplies 3 floats
        {
            return num1 * num2 * num3;
        }

        // constructors

        public MathCls(int[] arr) // accepts int array
        {
            this.IntNum1 = arr[0];
            this.IntNum2 = arr[1];
            if (arr.Length == 3)
            {
                this.IntNum3 = arr[2];
            }
        }

        public MathCls(int num1, int num2, int num3) // accepts 3 ints
        {
            this.IntNum1 = num1;
            this.IntNum2 = num2;
            this.IntNum3 = num3;
        }

        public MathCls(float[] arr) // accepts float array
        {
            this.FloatNum1 = arr[0];
            this.FloatNum2 = arr[1];
            if (arr.Length == 3)
            {
                this.FloatNum3 = arr[2];
            }
        }

        public MathCls(float num1, float num2) // accepts 2 floats
        {
            this.FloatNum1 = num1;
            this.FloatNum2 = num2;
        }

        public MathCls(float num1, float num2, float num3) // accepts 3 floats
        {
            this.FloatNum1 = num1;
            this.FloatNum2 = num2;
            this.FloatNum3 = num3;
        }

    }
}