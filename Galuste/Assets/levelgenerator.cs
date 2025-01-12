using UnityEngine;

public class levelgenerator : MonoBehaviour
{
    public GameObject platformus;
    public int numardeplatformus = 200;
    public float latimenivel = 3f;
    public float minY = .1f;
    public float maxY = 1.3f;

    void Start()
    {
        Vector3 spawnPosition = new Vector3();
        for (int i = 0; i < numardeplatformus; i++)
        {
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x = Random.Range(-latimenivel, latimenivel);
            Instantiate(platformus, spawnPosition, platformus.transform.rotation);
        }
    }

    void Update()
    {
        
    }
}
