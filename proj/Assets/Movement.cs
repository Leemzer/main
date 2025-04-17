using UnityEngine;

public class movement : MonoBehaviour
{

    public float moveSpeed = 80f;
     public CharacterController characterHitBox; 
     public Vector2 moveInput;

    public GameObject directionPointer;
    void Start()
    {


    }

    void Update()
    {
        moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        print(Time.deltaTime);
    }

    void FixedUpdate()
    {
        
        Vector3 directionAndSpeed = new Vector3(moveInput.x, 0 , moveInput.y) * moveSpeed;
        directionAndSpeed = directionPointer.transform.TransformDirection(directionAndSpeed);
        characterHitBox.Move(directionAndSpeed * Time.deltaTime * 4);
    }

}