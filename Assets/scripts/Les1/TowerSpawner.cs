using UnityEngine;

public class TowerSpawner : MonoBehaviour
{
    [SerializeField] private GameObject towerPrefab;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SpawnTower();
        }
    }

    private void SpawnTower()
    {
        float x = Random.Range(-10f, 10f);
        float y = Random.Range(0.9f, 0.9f);
        float z = Random.Range(-10f, 10f);

        Vector3 spawnPosition = new Vector3(x, y, z);
        Instantiate(towerPrefab, spawnPosition, Quaternion.identity);
    }
}
