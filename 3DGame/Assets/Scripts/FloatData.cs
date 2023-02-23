using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]

//All code is for testing purposes and is sourced from Anthony Romrell
public class FloatData : ScriptableObject
{
    public float value;
    public UnityEvent onMinEvent;
    public UnityEvent onMaxEvent;
    public UnityEvent onUpdateEvent;
    public void SetValue(float num)
    {
        value = num;
    }
    public void UpdateValue(float num)

    {
        value += num;
        onUpdateEvent.Invoke();
    }

    public void CheckMin(float num)
    {
        if (value <= num)
        {
            value = num;
            onMinEvent.Invoke();
        }
    }

    public void CheckMax(float num)
    {
        if (value >= num)
        {
            value = num;
            onMaxEvent.Invoke();
        }
    }

    public void Debuging()
    {
        Debug.Log("GameEND");
    }
}