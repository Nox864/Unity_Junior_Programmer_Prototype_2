using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private GameManager gameManager;

    private void Awake()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Dog"))
        {
            other.GetComponent<AnimalHunger>().FeedAnimal(1);
            Destroy(gameObject);
        }
        else if (other.gameObject.CompareTag("Player"))
        {
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }
        
    }
}
