using Synapse.Api.Plugin;

namespace BodyEject_Synapse_
{
    [PluginInformation(
    Author = "TypicalIllusion",
    Description = "BodyEject",
    LoadPriority = 0,
    Name = "BodyEject",
    SynapseMajor = 2,
    SynapseMinor = 4,
    SynapsePatch = 2,
    Version = "1.2.0"
)]
    class Plugin : AbstractPlugin
    {
        [Synapse.Api.Plugin.Config(section = "BodyEject")]
        public static Config Config;
        public override void Load()
        {
            SynapseController.Server.Logger.Info("BodyEject Loaded");
            new EventHandlers();
        }
    }
}
