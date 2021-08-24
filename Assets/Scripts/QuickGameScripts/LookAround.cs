using UnityEngine;

public class LookAround : MonoBehaviour
{
 
    public float sensitivityHor = 9.0f;
    public float sensitivityVert = 9.0f;

    public float minmunVert = -45.0f;
    public float maxmunVert = 45.0f;

    public float _rotationX = 0;
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    void Update()
    {      
            _rotationX -= Input.GetAxis("Mouse Y") * sensitivityVert;
            _rotationX = Mathf.Clamp(_rotationX, minmunVert, maxmunVert);

            float delta = Input.GetAxis("Mouse X") * sensitivityHor;
            float rotationY = transform.localEulerAngles.y + delta;
            transform.localEulerAngles = new Vector3(_rotationX, rotationY, 0);       
    }
}
