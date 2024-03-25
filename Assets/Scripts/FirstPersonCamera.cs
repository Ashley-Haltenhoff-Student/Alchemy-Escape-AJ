using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{

    private float xAxis;
    private float yAxis;

    public float xAxisTurnRate = 360f;
    public float yAxisTurnRate = 360f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }


    void LateUpdate()
    {
        Quaternion newRotation = Quaternion.Euler(xAxis, yAxis, 0f);

        Camera.main.transform.rotation = newRotation;
    }

    public void AddXAxisInput(float input)
    {
        xAxis -= input * xAxisTurnRate;
        xAxis = Mathf.Clamp(xAxis, -90f, 90f);
    }

    public void AddYAxisInput(float input)
    {
        yAxis += input * yAxisTurnRate;
    }
}
