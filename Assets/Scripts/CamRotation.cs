using UnityEngine;
using UnityEngine.UIElements;

public class CamRotation : MonoBehaviour
{
    public Transform CamAxisTransform;
    public float RotationSpeed;
    public float MinAngle;
    public float MaxAngle;

    void Update()
    {
     transform.localEulerAngles = new Vector3(0, transform.localEulerAngles.y + Time.deltaTime * RotationSpeed * Input.GetAxis("Mouse X"), 0);
     var NewAngleX = CamAxisTransform.localEulerAngles.x + Time.deltaTime * RotationSpeed * -Input.GetAxis("Mouse Y");
     if (NewAngleX > 180)
         NewAngleX -= 360;
     NewAngleX = Mathf.Clamp(NewAngleX, MinAngle, MaxAngle);
        CamAxisTransform.localEulerAngles = new Vector3(NewAngleX, 0, 0);
    }
}
