using HarmonyLib;
using VRage.Plugins;

namespace avaness.NoArmorEdges
{
    public class Main : IPlugin
    {
        public void Dispose()
        {

        }

        public void Init(object gameInstance)
        {
            Harmony harmony = new Harmony("avaness.NoArmorEdges");
            harmony.PatchAll();
        }

        public void Update()
        {

        }
    }
}
