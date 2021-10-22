using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFollowCamera : MonoBehaviour
{

    public float RotationSpeed;
    public Transform Gun;
    float GunAngel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RotateGun();
    }

    public void RotateGun()
    {
        GunAngel += Input.GetAxis("Mouse X") * RotationSpeed * -Time.deltaTime;
        GunAngel = Mathf.Clamp(GunAngel, -360, 360);
        Gun.localRotation = Quaternion.AngleAxis(GunAngel, Vector3.up);
    }
}
