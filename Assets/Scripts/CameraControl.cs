using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject target;
    [SerializeField] Vector3 positionOffset;
    
    // Start is called before the first frame update
    void Start()
    {
        positionOffset = transform.position - target.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = target.transform.position + positionOffset;
    }
}
