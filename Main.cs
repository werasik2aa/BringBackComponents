using UnityEngine;
using MelonLoader;
using UnhollowerRuntimeLib;
namespace BringBackComponents
{
    public class FixMod : MelonMod
    {
        public override void OnApplicationLateStart()
        {
            MelonLogger.Msg("PATCHING: WheelCollider | HinjeJoint");
            ClassInjector.RegisterTypeInIl2Cpp<WheelCollider>();
            ClassInjector.RegisterTypeInIl2Cpp<HingeJoint>();
            MelonLogger.Msg("PATCHED");
        }
    }
}
