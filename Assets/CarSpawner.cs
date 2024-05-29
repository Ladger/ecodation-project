using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    [SerializeField] float spawnRate;
    [SerializeField] float spawnCarSpeed;
    [SerializeField] List<GameObject> cars = new List<GameObject>();
    [SerializeField] List<Material> carPaints = new List<Material>();


    List<float> lanePositions = new List<float> { -3, 0, 3 };
    float lastSpawn;

    private void Update()
    {
        if (Time.time > lastSpawn + 1/spawnRate)
        {
            lastSpawn = Time.time;
            Spawn();
        }
    }

    void Spawn()
    {
        GameObject carPrefab = cars[Random.Range(0, cars.Count)];
        Material paint = carPaints[Random.Range(0, carPaints.Count)];

        Vector3 position = new Vector3(lanePositions[Random.Range(0, lanePositions.Count)], 1.5f, transform.position.z);
        Quaternion rotation = Quaternion.Euler(0, -90, 0);

        GameObject carInstance = Instantiate(carPrefab, position, rotation);

        Renderer renderer = carInstance.GetComponent<Renderer>();

        if (renderer != null)
        {
            Material[] materials = renderer.materials;
            materials[0] = paint;

            renderer.materials = materials;
        }
    }

    public float getCarSpeed()
    {
        return spawnCarSpeed;
    }
}
