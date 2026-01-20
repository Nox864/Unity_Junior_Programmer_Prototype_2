using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    [SerializeField] private float speed;
    [SerializeField] private float xRange = 15;
    [SerializeField] private GameObject projectile;


    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject go = Instantiate(projectile, transform.position, transform.rotation);
        }
    }  
}
