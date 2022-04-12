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
                if (e.ToString().Equals("UnityEngine.HingeJoint") || e.ToString().Contains("UnityEngine.HingeJoint"))
                {
                    request = e;
                }
            }
            return request;
        }
        public static Component AddComponent(Transform Wheel) { Component o = Wheel.gameObject.AddComponent<HingeJoint>(); if (o) return o; else return null; }
        public static JointLimits Get_JointLimits(Transform Wheel)
        {
            JointLimits g = new JointLimits();
            if (GetComponent(Wheel))
                return ResolveICall<HingeJoint.get_limits>("UnityEngine.HingeJoint::get_limits_Injected").Invoke(GetComponent(Wheel).Pointer);
            return g;
        }
        public static bool Set_JointLimits(Transform Wheel, JointLimits Value)
        {
            if (GetComponent(Wheel))
            {
                ResolveICall<HingeJoint.set_limits>("UnityEngine.HingeJoint::set_limits_Injected").Invoke(GetComponent(Wheel).Pointer, Value);
                return true;
            }
            return false;
        }
        public static JointMotor Get_Motor(Transform Wheel)
        {
            JointMotor g = new JointMotor();
            if (GetComponent(Wheel))
                return ResolveICall<HingeJoint.get_motor>("UnityEngine.HingeJoint::get_motor_Injected").Invoke(GetComponent(Wheel).Pointer);
            return g;
        }
        public static bool Set_JointMotor(Transform Wheel, JointMotor Value)
        {
            if (GetComponent(Wheel))
            {
                ResolveICall<HingeJoint.set_motor>("UnityEngine.HingeJoint::set_motor_Injected").Invoke(GetComponent(Wheel).Pointer, Value);
                return true;
            }
            return false;
        }
        public static JointSpring Get_Spring(Transform Wheel)
        {
            JointSpring g = new JointSpring();
            if (GetComponent(Wheel))
                return ResolveICall<HingeJoint.get_spring>("UnityEngine.HingeJoint::get_spring_Injected").Invoke(GetComponent(Wheel).Pointer);
            return g;
        }
        public static bool Set_Spring(Transform Wheel, JointSpring Value)
        {
            if (GetComponent(Wheel))
            {
                ResolveICall<HingeJoint.set_spring>("UnityEngine.HingeJoint::set_spring_Injected").Invoke(GetComponent(Wheel).Pointer, Value);
                return true;
            }
            return false;
        }
        public static bool Get_IsUseSpring(Transform Wheel)
        {
            JointMotor g = new JointMotor();
            if (GetComponent(Wheel))
                return ResolveICall<HingeJoint.get_useSpring>("UnityEngine.HingeJoint::get_useSpring").Invoke(GetComponent(Wheel).Pointer);
            return false;
        }
        public static bool Set_IsUseSpring(Transform Wheel, bool Value)
        {
            if (GetComponent(Wheel))
            {
                ResolveICall<HingeJoint.set_useSpring>("UnityEngine.HingeJoint::set_spring").Invoke(GetComponent(Wheel).Pointer, Value);
                return true;
            }
            return false;
        }
        public static bool Get_IsUseMotor(Transform Wheel)
        {
            JointMotor g = new JointMotor();
            if (GetComponent(Wheel))
                return ResolveICall<HingeJoint.get_useMotor>("UnityEngine.HingeJoint::get_useMotor").Invoke(GetComponent(Wheel).Pointer);
            return false;
        }
        public static bool Set_IsUseMotor(Transform Wheel, bool Value)
        {
            if (GetComponent(Wheel))
            {
                ResolveICall<HingeJoint.set_useMotor>("UnityEngine.HingeJoint::set_useMotor").Invoke(GetComponent(Wheel).Pointer, Value);
                return true;
            }
            return false;
        }
        public static bool Get_IsUseLimits(Transform Wheel)
        {
            JointMotor g = new JointMotor();
            if (GetComponent(Wheel))
                return ResolveICall<HingeJoint.get_useLimits>("UnityEngine.HingeJoint::get_useLimits").Invoke(GetComponent(Wheel).Pointer);
            return false;
        }
        public static bool Set_IsUseLimits(Transform Wheel, bool Value)
        {
            if (GetComponent(Wheel))
            {
                ResolveICall<HingeJoint.set_useLimits>("UnityEngine.HingeJoint::set_useMotor").Invoke(GetComponent(Wheel).Pointer, Value);
                return true;
            }
            return false;
        }
        public static float Get_Velocity(Transform Wheel)
        {
            if (GetComponent(Wheel))
                return ResolveICall<HingeJoint.get_velocity>("UnityEngine.HingeJoint::get_velocity").Invoke(GetComponent(Wheel).Pointer);
            return 0;
        }
        public static float Get_Angle(Transform Wheel)
        {
            if (GetComponent(Wheel))
                return ResolveICall<HingeJoint.get_angle>("UnityEngine.HingeJoint::get_velocity").Invoke(GetComponent(Wheel).Pointer);
            return 0;
        }
    }
}
