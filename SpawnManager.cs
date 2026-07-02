using UnityEngine;
using UnityEngine.InputSystem;

public class SpawnManager : MonoBehaviour
{
    //creates am array for game ojects seeing that we have multiple of them in the hierarchy
    public GameObject[] animalPrefab;
    public InputAction spawnAction;
    private float xRange = 20.0f;
    private float spawnPositionz = 20.0f;
    private float startDelay = 2.0f;

    private float delayInterval = 1.5f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // spawns certain gameobjects verery couple of seconds
        InvokeRepeating("SpawnRandomAnimal", startDelay, delayInterval );
       // spawnAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnRandomAnimal()
    {
        // spawns gameobjects randomly starting from index 0 untill the last game object
        int animalIndex = Random.Range(0, animalPrefab.Length);
        // spawns gameobbjects at a random spot limiteed by borders on each side
        Vector3 spawmPos = new Vector3(Random.Range(-xRange,xRange),0,spawnPositionz);
        // spawns multiple of the gameobjects
        Instantiate(animalPrefab[animalIndex], spawmPos , animalPrefab[animalIndex].transform.rotation);
    }
}
