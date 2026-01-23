using UnityEngine;
using UnityEngine.Rendering;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] animalPrefabs;
    [SerializeField] private float sideSpawnX;
    [SerializeField] private float sideSpawnMinZ;
    [SerializeField] private float sideSpawnMaxZ;



    private float spawnRangeX = 15;
    private float spawnPosZ = 20;
    private float startDelay = 2f;
    private float spawnInterval = 3.5f;

    private void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
        InvokeRepeating("SpawnLeftAnimal", startDelay, spawnInterval);
        InvokeRepeating("SpawnRightAnimal", startDelay, spawnInterval);

    }

    private void Update()
    {
    }

    private void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }

    private void SpawnLeftAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        Vector3 spawnPos = new Vector3(-sideSpawnX, 0, Random.Range(sideSpawnMinZ, sideSpawnMaxZ));
        Vector3 rotation = new Vector3 (0, 90, 0);

        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(rotation));
    }

    private void SpawnRightAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        Vector3 spawnPos = new Vector3(sideSpawnX, 0 , Random.Range(sideSpawnMinZ, sideSpawnMaxZ));
        Vector3 rotation = new Vector3(0, -90, 0);


        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(rotation));

    }
}
