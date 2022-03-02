using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttributesTest
{
    [Serializable]
    [Obsolete("This class will not be a part of release 2.4")]
    internal class CustomAttributes
    {
    }

    // custom attribute
    [AttributeUsage(AttributeTargets.All)]
    public class DeveloperInfo : Attribute
    {
        private string email;
        private float buildnumber;
        public DeveloperInfo(string email, float build)
        {
            this.email = email;
            this.buildnumber = build;
        }
        public float Build
        {
            get { return this.buildnumber; }
            set { this.buildnumber=value; }
        }
        public string Email
        {
            get { return this.email; }
            set { this.email=value; }
        }
    }
}