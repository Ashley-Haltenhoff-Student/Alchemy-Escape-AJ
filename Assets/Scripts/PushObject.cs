using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PushObject : MonoBehaviour
{

    private Rigidbody rigidbody;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    public void Push(float strength)
    {
        Vector3 pushDirection = transform.position - Camera.main.transform.position;
        pushDirection.Normalize();

        rigidbody.AddForce(pushDirection * strength, ForceMode.Impulse);
    }
}
