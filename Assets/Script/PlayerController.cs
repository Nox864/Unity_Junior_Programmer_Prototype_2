using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    [SerializeField] private float speed;
    


    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        if (transform.position.x <10)
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
        }
        
    }
}
