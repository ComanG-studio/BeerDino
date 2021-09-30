using UnityEngine;

public class CooldownTimer : MonoBehaviour
{
    private float _currentTimeValue;
    public float Time { get; set; }

    private void Update()
    {
        if (_currentTimeValue > 0)
            _currentTimeValue -= UnityEngine.Time.deltaTime;

        else if (_currentTimeValue == 0) _currentTimeValue = Time;
    }
}