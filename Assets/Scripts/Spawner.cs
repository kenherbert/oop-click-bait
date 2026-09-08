using Unity.VisualScripting;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spawnedObj;
    public float spawnDistance = 5f;
    public float spawnInitialDelay = 3f;
    public float spawnRate = .75f;
    public GameObject[] spawningObjs;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Invoke("spawnObject", 1);
        InvokeRepeating("SpawnObject", spawnInitialDelay, spawnRate);
    }

    public void Stop()
    {
        CancelInvoke(); //Stop spawning new enemies
    }

    public void SpawnObject()
    {
        Vector3 newPos = Random.insideUnitCircle.normalized * spawnDistance;
        spawnedObj = spawningObjs[(int)Random.Range(0, spawningObjs.Length)];
        Instantiate(spawnedObj, transform.position + newPos, transform.rotation);
    }
}
