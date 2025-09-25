using UnityEngine;

public class Tilt : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public float speed = 5f;
    public float limit = 100f;
    // Update is called once per frame
    void Update()
    {
        float rotationH = Input.GetAxis("Horizontal") * speed;
        float rotationV = Input.GetAxis("Vertical") * speed;
        //rotationH *= Time.deltaTime;
        //rotationV *= Time.deltaTime;
        transform.rotation = Quaternion.Euler(rotationV, 0f, rotationH);
        

    }
}
