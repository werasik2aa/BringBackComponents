﻿using UnityEngine;
using static UnhollowerBaseLib.IL2CPP;
namespace BringBackComponents
{
    public class WheelComponent
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
        public static Component AddComponent(Transform Wheel) { Component o = Wheel.gameObject.AddComponent<WheelCollider>(); if (o) return o; else return null; }
        public static bool Set_SteerAngle(Transform Wheel, float Value)
        {
            if (GetComponent(Wheel))
            {
                ResolveICall<WheelCollider.set_steerAngle>("UnityEngine.WheelCollider::set_steerAngle").Invoke(GetComponent(Wheel).Pointer, Value);
                return true;
            }
            return false;
        }
        public static float Get_SteerAngle(Transform Wheel)
        {
            if (GetComponent(Wheel))
                return ResolveICall<WheelCollider.get_steerAngle>("UnityEngine.WheelCollider::get_steerAngle").Invoke(GetComponent(Wheel).Pointer);
            return 0;
        }
        public static bool Set_MotorTorque(Transform Wheel, float Value)
        {
            if (GetComponent(Wheel))
            {
                ResolveICall<WheelCollider.set_motorTorque>("UnityEngine.WheelCollider::set_motorTorque").Invoke(GetComponent(Wheel).Pointer, Value);
                return true;
            }
            return false;
        }
        public static float Get_MotorTorque(Transform Wheel)
        {
            if (GetComponent(Wheel))
                return ResolveICall<WheelCollider.get_motorTorque>("UnityEngine.WheelCollider::get_motorTorque").Invoke(GetComponent(Wheel).Pointer);
            else return 0;
        }
        public static bool Set_BrakeTorque(Transform Wheel, float Value)
        {
            if (GetComponent(Wheel))
            {
                ResolveICall<WheelCollider.set_brakeTorque>("UnityEngine.WheelCollider::set_brakeTorque").Invoke(GetComponent(Wheel).Pointer, Value);
                return true;
            }
            return false;
        }
        public static float Get_BrakeTorque(Transform Wheel)
        {
            if (GetComponent(Wheel))
                return ResolveICall<WheelCollider.get_brakeTorque>("UnityEngine.WheelCollider::get_brakeTorque").Invoke(GetComponent(Wheel).Pointer);
            return 0;
        }
        public static Vector3 Get_Center(Transform Wheel)
        {
            if (GetComponent(Wheel))
                return ResolveICall<WheelCollider.get_center>("UnityEngine.WheelCollider::get_center").Invoke(GetComponent(Wheel).Pointer);
            return Vector3.zero;
        }
        public static bool Set_Center(Transform Wheel, Vector3 Value)
        {
            if (GetComponent(Wheel))
            {
                ResolveICall<WheelCollider.set_center>("UnityEngine.WheelCollider::set_center").Invoke(GetComponent(Wheel).Pointer, Value);
                return true;
            }
            return false;
        }
        public static float Get_Radius(Transform Wheel)
        {
            if (GetComponent(Wheel))
                return ResolveICall<WheelCollider.get_radius>("UnityEngine.WheelCollider::get_radius").Invoke(GetComponent(Wheel).Pointer);
            return 0;
        }
        public static bool Set_Radius(Transform Wheel, float Value)
        {
            if (GetComponent(Wheel))
            {
                ResolveICall<WheelCollider.set_radius>("UnityEngine.WheelCollider::set_radius").Invoke(GetComponent(Wheel).Pointer, Value);
                return true;
            }
            return false;
        }
        public static float Get_SuspensionDistance(Transform Wheel)
        {
            if (GetComponent(Wheel))
                return ResolveICall<WheelCollider.get_suspensionDistance>("UnityEngine.WheelCollider::get_suspensionDistance").Invoke(GetComponent(Wheel).Pointer);
            return 0;
        }
        public static bool Set_SuspensionDistance(Transform Wheel, float Value)
        {
            if (GetComponent(Wheel))
            {
                ResolveICall<WheelCollider.set_suspensionDistance>("UnityEngine.WheelCollider::set_suspensionDistance").Invoke(GetComponent(Wheel).Pointer, Value);
                return true;
            }
            return false;
        }
        public static float Get_Mass(Transform Wheel)
        {
            if (GetComponent(Wheel))
                return ResolveICall<WheelCollider.get_mass>("UnityEngine.WheelCollider::get_mass").Invoke(GetComponent(Wheel).Pointer);
            return 0;
        }
        public static bool Set_Mass(Transform Wheel, float Value)
        {
            if (GetComponent(Wheel))
            {
                ResolveICall<WheelCollider.set_mass>("UnityEngine.WheelCollider::set_mass").Invoke(GetComponent(Wheel).Pointer, Value);
                return true;
            }
            return false;
        }
        public static float Get_WheelDampingRate(Transform Wheel)
        {
            if (GetComponent(Wheel))
                return ResolveICall<WheelCollider.get_wheelDampingRate>("UnityEngine.WheelCollider::get_wheelDampingRate").Invoke(GetComponent(Wheel).Pointer);
            return 0;
        }
        public static bool Set_WheelDampingRate(Transform Wheel, float Value)
        {
            if (GetComponent(Wheel))
            {
                ResolveICall<WheelCollider.set_wheelDampingRate>("UnityEngine.WheelCollider::set_wheelDampingRate").Invoke(GetComponent(Wheel).Pointer, Value);
                return true;
            }
            return false;
        }
        public static float Get_ForceAppPointDistance(Transform Wheel)
        {
            if (GetComponent(Wheel))
                return ResolveICall<WheelCollider.get_forceAppPointDistance>("UnityEngine.WheelCollider::get_forceAppPointDistance").Invoke(GetComponent(Wheel).Pointer);
            return 0;
        }
        public static float Get_RPM(Transform Wheel)
        {
            if (GetComponent(Wheel))
                return ResolveICall<WheelCollider.get_rpm>("UnityEngine.WheelCollider::get_rpm").Invoke(GetComponent(Wheel).Pointer);
            return 0;
        }
        public static bool Set_ForceAppPointDistance(Transform Wheel, float Value)
        {
            if (GetComponent(Wheel))
            {
                ResolveICall<WheelCollider.set_forceAppPointDistance>("UnityEngine.WheelCollider::set_forceAppPointDistance").Invoke(GetComponent(Wheel).Pointer, Value);
                return true;
            }
            return false;
        }
        public static JointSpring Get_JointSpring(Transform Wheel)
        {
            JointSpring g = new JointSpring(); //SOULD BE NULL IF NOT ASSIGNED 
            if (GetComponent(Wheel))
                return ResolveICall<WheelCollider.get_suspensionSpring>("UnityEngine.WheelCollider::get_suspensionSpring").Invoke(GetComponent(Wheel).Pointer);
            return g;
        }
        public static bool Set_JointSpring(Transform Wheel, JointSpring newspring)
        {
            if (GetComponent(Wheel))
            {
                ResolveICall<WheelCollider.set_suspensionSpring>("UnityEngine.WheelCollider::set_suspensionSpring").Invoke(GetComponent(Wheel).Pointer, newspring);
                return true;
            }
            return false;
        }
    }
}
