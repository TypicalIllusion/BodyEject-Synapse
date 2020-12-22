using Synapse.Config;
using System.ComponentModel;

namespace BodyEject_Synapse_
{
    public class Config : AbstractConfigSection
    {
        [Description("Remove items?")]
        public bool RemoveItems = true;
    }
}
