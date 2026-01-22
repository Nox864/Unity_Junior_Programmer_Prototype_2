using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;

    [SerializeField] private float speed;
    [SerializeField] private float xRange = 15;
    [SerializeField] private float zMax = 16;
    [SerializeField] private float zMin = -1;
    [SerializeField] private Transform projectileSpawnPoint;

    [SerializeField] private GameObject projectile;


    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.z > zMax)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zMax);
        }
        if (transform.position.z < zMin)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zMin);
        }

        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);


        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject go = Instantiate(projectile, projectileSpawnPoint.position, transform.rotation);
        }
    }  
}
