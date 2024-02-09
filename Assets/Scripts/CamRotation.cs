using UnityEngine;
using UnityEngine.UIElements;

public class CamRotation : MonoBehaviour
{
    public Transform CamAxisTransform;
    public float RotationSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     transform.localEulerAngles = new Vector3(0, transform.localEulerAngles.y + Time.deltaTime * RotationSpeed * Input.GetAxis("Mouse X"), 0);
     CamAxisTransform.localEulerAngles = new Vector3(CamAxisTransform.localEulerAngles.x + Time.deltaTime * RotationSpeed * -Input.GetAxis("Mouse Y"), 0, 0);
    }
}
