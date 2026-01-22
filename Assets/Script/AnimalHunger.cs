using UnityEngine;
using UnityEngine.UI;

public class AnimalHunger : MonoBehaviour
{
    [SerializeField] private Slider hungerSlider;
    [SerializeField] private int amountToBeFed;

    private int currentFedAmount;
    private GameManager gameManager;

    void Start()
    {
        hungerSlider.maxValue = amountToBeFed;
        hungerSlider.value = 0;
        hungerSlider.fillRect.gameObject.SetActive(false);

        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

    }


    void Update()
    {
        
    }

    public void FeedAnimal (int amount)
    {
        currentFedAmount += amount;
        hungerSlider.fillRect.gameObject.SetActive(true);
        hungerSlider.value = currentFedAmount;

        if (currentFedAmount >= amountToBeFed)
        {
            gameManager.AddScore(amountToBeFed);
            Destroy(gameObject, 0.1f);
        }
    }
}
