using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace FacturaElectronicaSii.Extensions
{
    public class SimpleBehaviorExtensionElement : BehaviorExtensionElement
    {
        public override Type BehaviorType
        {
            get
            {
                return typeof(SimpleEndpointBehavior);
            }
        }

        protected override object CreateBehavior()
        {
            return new SimpleEndpointBehavior();
        }
    }
}
