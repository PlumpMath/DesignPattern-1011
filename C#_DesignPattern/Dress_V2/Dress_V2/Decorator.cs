using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dress_V2
{
    class Decorator:Component
    {
        protected Component component;

        public void SetComponent(Component component)
        {
            this.component = component;
        }

        public  override void  Operation()
        {
 	        if (component != null)
            {
                component.Operation();
            }
        }
    }
}
