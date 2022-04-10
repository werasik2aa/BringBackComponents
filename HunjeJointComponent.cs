using UnityEngine;
using static UnhollowerBaseLib.IL2CPP;

namespace BringBackComponents
{
    public class HunjeJointComponent
    {
        public static Component GetComponent(Transform Wheel)
        {
            Component[] all = Wheel.GetComponents<Component>();
            Component request = null;
            foreach (var e in all)
            {
                if (e.ToString().Equals("UnityEngine.WheelCollider") || e.ToString().Contains("UnityEngine.WheelCollider"))
                {
                    request = e;
                }
            }
            return request;
        }
        public static JointLimits Get_JointLimits(Transform Wheel)
        {
            JointLimits g = new JointLimits();
            if (GetComponent(Wheel))
                return ResolveICall<HingeJoint.get_limits>("UnityEngine.WheelCollider::get_limits").Invoke(GetComponent(Wheel).Pointer);
            return g;
        }
        public static bool Set_JointLimits(Transform Wheel, JointLimits Value)
        {
            if (GetComponent(Wheel))
            {
                ResolveICall<HingeJoint.set_limits>("UnityEngine.WheelCollider::set_motorTorque").Invoke(GetComponent(Wheel).Pointer, Value);
                return true;
            }
            return false;
        }
        public static JointMotor Get_Motor(Transform Wheel)
        {
            JointMotor g = new JointMotor();
            if (GetComponent(Wheel))
                return ResolveICall<HingeJoint.get_motor>("UnityEngine.WheelCollider::get_motor").Invoke(GetComponent(Wheel).Pointer);
            return g;
        }
        public static bool Set_JointMotor(Transform Wheel, JointMotor Value)
        {
            if (GetComponent(Wheel))
            {
                ResolveICall<HingeJoint.set_motor>("UnityEngine.WheelCollider::set_motorTorque").Invoke(GetComponent(Wheel).Pointer, Value);
                return true;
            }
            return false;
        }
        public static JointSpring Get_Spring(Transform Wheel)
        {
            JointSpring g = new JointSpring();
            if (GetComponent(Wheel))
                return ResolveICall<HingeJoint.get_spring>("UnityEngine.WheelCollider::get_spring").Invoke(GetComponent(Wheel).Pointer);
            return g;
        }
        public static bool Set_Spring(Transform Wheel, JointSpring Value)
        {
            if (GetComponent(Wheel))
            {
                ResolveICall<HingeJoint.set_spring>("UnityEngine.WheelCollider::set_spring").Invoke(GetComponent(Wheel).Pointer, Value);
                return true;
            }
            return false;
        }
        public static bool Get_IsUseSpring(Transform Wheel)
        {
            JointMotor g = new JointMotor();
            if (GetComponent(Wheel))
                return ResolveICall<HingeJoint.get_useSpring>("UnityEngine.WheelCollider::get_useSpring").Invoke(GetComponent(Wheel).Pointer);
            return false;
        }
        public static bool Set_IsUseSpring(Transform Wheel, bool Value)
        {
            if (GetComponent(Wheel))
            {
                ResolveICall<HingeJoint.set_useSpring>("UnityEngine.WheelCollider::set_spring").Invoke(GetComponent(Wheel).Pointer, Value);
                return true;
            }
            return false;
        }
        public static bool Get_IsUseMotor(Transform Wheel)
        {
            JointMotor g = new JointMotor();
            if (GetComponent(Wheel))
                return ResolveICall<HingeJoint.get_useMotor>("UnityEngine.WheelCollider::get_useMotor").Invoke(GetComponent(Wheel).Pointer);
            return false;
        }
        public static bool Set_IsUseMotor(Transform Wheel, bool Value)
        {
            if (GetComponent(Wheel))
            {
                ResolveICall<HingeJoint.set_useMotor>("UnityEngine.WheelCollider::set_useMotor").Invoke(GetComponent(Wheel).Pointer, Value);
                return true;
            }
            return false;
        }
        public static bool Get_IsUseLimits(Transform Wheel)
        {
            JointMotor g = new JointMotor();
            if (GetComponent(Wheel))
                return ResolveICall<HingeJoint.get_useLimits>("UnityEngine.WheelCollider::get_useLimits").Invoke(GetComponent(Wheel).Pointer);
            return false;
        }
        public static bool Set_IsUseLimits(Transform Wheel, bool Value)
        {
            if (GetComponent(Wheel))
            {
                ResolveICall<HingeJoint.set_useLimits>("UnityEngine.WheelCollider::set_useMotor").Invoke(GetComponent(Wheel).Pointer, Value);
                return true;
            }
            return false;
        }
        public static float Get_Velocity(Transform Wheel)
        {
            if (GetComponent(Wheel))
                return ResolveICall<HingeJoint.get_velocity>("UnityEngine.WheelCollider::get_velocity").Invoke(GetComponent(Wheel).Pointer);
            return 0;
        }
        public static float Get_Angle(Transform Wheel)
        {
            if (GetComponent(Wheel))
                return ResolveICall<HingeJoint.get_angle>("UnityEngine.WheelCollider::get_velocity").Invoke(GetComponent(Wheel).Pointer);
            return 0;
        }
    }
}
