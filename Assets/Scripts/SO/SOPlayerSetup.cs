using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

[CreateAssetMenu]
public class SOPlayerSetup : ScriptableObject
{
    [Header("Key Binding")]
    public KeyCode jumpButton = KeyCode.Space;
    public KeyCode runButton = KeyCode.LeftShift;

    [Header("Movement Settings")]
    public float speed = 20f;
    public float speedRun = 1.5f;
    public float turnSpeed = 1f;
    public float forceJump = 18;
    public bool isGrounded = true;
    public float minVelocityMagnitude = 0.1f;
}
