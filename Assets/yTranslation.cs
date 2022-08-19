using System.Collections;
using UnityEngine;

public class yTranslation : MonoBehaviour
{
    [SerializeField] private Vector3 initialPos;
    [SerializeField] private float zAmplitude;
    [SerializeField] private float zFrequency;
    [SerializeField] private float yAmplitude;
    [SerializeField] private float yFrequency;
    [SerializeField] private float xAmplitude;
    [SerializeField] private float xFrequency;

    // Update() is called once *per frame*. It is called *after* the Start()
    // method, which is only called once when the component is enabled for the
    // first time. You'll find that the execution order of these lifecycle
    // methods matters, and this can be fairly nuanced when components reference
    // each other, and/or if you are enabling and disabling components at
    // runtime.
    //
    // Recommended reading:
    // - https://docs.unity3d.com/Manual/ExecutionOrder.html
    private void Update()
    {        
        transform.position =  this.initialPos + Vector3.up * this.yAmplitude * Mathf.Cos(Time.time * this.yFrequency) +  Vector3.forward * this.zAmplitude * Mathf.Sin(Time.time * this.zFrequency) + Vector3.right * this.xAmplitude * Mathf.Sin(Time.time * this.xFrequency);
    }
}
