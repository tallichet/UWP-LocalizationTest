using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;

namespace MyStrings
{
    public class ResourcesProvider
    {
        private static ResourcesProvider _instance;

        public static ResourcesProvider Instance => (_instance ?? (_instance = new ResourcesProvider()));

        public ResourcesProvider()
        {
            
            this.Resources = new ResourceManager(typeof(Resource));
        }

        public ResourceManager Resources { get; }
    }
}
