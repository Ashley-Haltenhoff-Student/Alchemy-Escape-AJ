using UnityEngine;


public class TurnObject : MonoBehaviour
{

    public void Turn()
    {
        transform.Rotate(0.0f, 0.0f, 90.0f, Space.Self);
    }
}
