using HarmonyLib;
using System.Reflection;
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
            new Harmony("avaness.NoArmorEdges").PatchAll(Assembly.GetExecutingAssembly());
        }

        public void Update()
        {

        }
    }
}
