using HarmonyLib;
using System;
using UnityEngine;

namespace BringBackComponents
{
    [HarmonyPatch(typeof(WheelCollider), "LoadWheelCollider")] // FUCK THE OBJ
    public class WheelCollider : Collider
    {
        public extern WheelCollider(IntPtr Value);
        public static Il2CppSystem.Type Il2CppType { get; }
        public float radius;
        public bool isGrounded { get; }
        public float steerAngle;
        public float brakeTorque;
        public float motorTorque;
        public WheelFrictionCurve sidewaysFriction;
        public WheelFrictionCurve forwardFriction;
        public float wheelDampingRate;
        public float mass;
        public float forceAppPointDistance;
        public JointSpring suspensionSpring;
        public float suspensionDistance;
        public float sprungMass;
        public Vector3 center;
        public float rpm;
        public delegate void ConfigureVehicleSubsteps(IntPtr ptr, ref float speedThreshold, ref int stepsBelowThreshold, ref int stepsAboveThreshold);
        public delegate void GetWorldPose(IntPtr ptr, out Vector3 ptr2, out Quaternion ptr3);
        public delegate Vector3 get_center(IntPtr ptr, out Vector3 ptr2);
        public delegate void set_centerS(IntPtr ptr, Vector3 Value);
        public delegate WheelFrictionCurve get_forwardFriction(IntPtr ptr); //FORWARD FR
        public delegate void set_forwardFriction(IntPtr ptr, WheelFrictionCurve Value);
        public delegate WheelFrictionCurve get_sidewaysFriction(IntPtr ptr); //SIDEWAY FR
        public delegate void set_sidewaysFriction(IntPtr ptr, WheelFrictionCurve Value);
        public delegate JointSpring get_suspensionSpring(IntPtr ptr); //SUS SPRING
        public delegate void set_suspensionSpring(IntPtr ptr, JointSpring Value);
        public delegate void ResetSprungMasses();
        public delegate float get_motorTorque(IntPtr ptr); //Torque motor
        public delegate void set_motorTorque(IntPtr ptr, float Value);
        public delegate float get_brakeTorque(IntPtr ptr); // BrakeToque
        public delegate void set_brakeTorque(IntPtr ptr, float Value);
        public delegate float get_steerAngle(IntPtr ptr); // steerAngle
        public delegate void set_steerAngle(IntPtr ptr, float Value);
        public delegate float get_radius(IntPtr ptr); // Radius
        public delegate void set_radius(IntPtr ptr, float Value);
        public delegate float get_sprungMass(IntPtr ptr); // MASS sprung
        public delegate void set_sprungMass(IntPtr ptr, float Value);
        public delegate float get_suspensionDistance(IntPtr ptr); // Suspension dist
        public delegate void set_suspensionDistance(IntPtr ptr, float Value);
        public delegate float get_mass(IntPtr ptr); //MASS
        public delegate void set_mass(IntPtr ptr, float Value);
        public delegate float get_wheelDampingRate(IntPtr ptr); // WHEEL damping rate
        public delegate void set_wheelDampingRate(IntPtr ptr, float Value);
        public delegate float get_forceAppPointDistance(IntPtr ptr); // WHEEL damping rate
        public delegate void set_forceAppPointDistance(IntPtr ptr, float Value);
        public delegate float get_rpm(IntPtr ptr); //RMP
    }
    [HarmonyPatch(typeof(HingeJoint), "LoadWheelCollider")] // FUCK THE OBJ
    public class HingeJoint : Component
    {
        public extern HingeJoint(IntPtr Value);
        public static Il2CppSystem.Type Il2CppType { get; }
        public JointMotor motor;
        public JointLimits limits;
        public JointSpring spring;
        public bool useMotor;
        public bool useLimits;
        public bool useSpring;
        public float velocity;
        public float angle;

        public delegate JointLimits get_limits(IntPtr ptr); // Limits
        public delegate void set_limits(IntPtr ptr, JointLimits Value);
        public delegate JointMotor get_motor(IntPtr ptr); // MOTOR
        public delegate void set_motor(IntPtr ptr, JointMotor Value);
        public delegate JointSpring get_spring(IntPtr ptr); // Spring
        public delegate void set_spring(IntPtr ptr, JointSpring Value);
        public delegate bool get_useMotor(IntPtr ptr); // isUseMotor
        public delegate void set_useMotor(IntPtr ptr, bool Value);
        public delegate bool get_useLimits(IntPtr ptr); // isUsLimit
        public delegate void set_useLimits(IntPtr ptr, bool Value);
        public delegate bool get_useSpring(IntPtr pt); // isUseSpring
        public delegate void set_useSpring(IntPtr ptr, bool Value);
        public delegate float get_velocity(IntPtr ptr); // Velocity
        public delegate float get_angle(IntPtr ptr); // Angle
    }
}
