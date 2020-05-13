using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TmpObjectRotator : MonoBehaviour
{
    float currentAngle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Transform trans = transform.parent;

        Quaternion rotation = Quaternion.AngleAxis(currentAngle, Vector3.up);

        Vector3 p = (Vector3.forward * 0.8f) + (Vector3.up *0.4f);
        Vector3 point = rotation * p;
        Vector3 worldPoint = trans.TransformPoint(point);

        this.transform.position = worldPoint;

        currentAngle += Time.deltaTime * 20f;
    }
}
