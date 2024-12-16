using UnityEngine;

public class WASDMovement: MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody rb;
    public Color[] colors = {Color.red, Color.green, Color.blue, Color.yellow};
    private Renderer sphereRenderer;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        sphereRenderer = GetComponent<Renderer>();

        rb.collisionDetectionMode = CollisionDetectionMode.Continuous;

        randomColor();
    }

    void Update()
    {
        if (rb == null) 
        {
            return;  
        }

        if (sphereRenderer == null) 
        {
            return;  
        }

        float moveX = 0f;
        float moveZ = 0f;

        if (Input.GetKey(KeyCode.W)) moveZ = 1f;
        if (Input.GetKey(KeyCode.S)) moveZ = -1f;
        if (Input.GetKey(KeyCode.A)) moveX = -1f;
        if (Input.GetKey(KeyCode.D)) moveX = 1f;

        Vector3 movement = new Vector3(moveX, 0f, moveZ) * speed * Time.deltaTime;
        rb.MovePosition(rb.position + movement);
    }
    void randomColor()
    {
        int randomIndex = Random.Range(0, colors.Length);  
        Color selectedColor = colors[randomIndex]; 
        sphereRenderer.material.color = selectedColor;
    }
}
