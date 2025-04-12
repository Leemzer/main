using UnityEngine;

public class DirectionPointer : MonoBehaviour
{
    public GameObject cameraObject;


     void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cameraAngles = cameraObject.transform.eulerAngles;
        cameraAngles.x = 0;
        cameraAngles.z = 0;
        transform.eulerAngles = cameraAngles;
        
    }
}
