using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("Spawn Settings")]
    public GameObject[] obstacles; // Prefabs de obstáculos
    public GameObject coinPrefab; // Prefab de moneda
    public Transform[] spawnPoints; // Lista de puntos de spawn
    public float spawnInterval = 2f; // Tiempo entre cada spawn
    public float coinChance = 0.3f; // Probabilidad de generar una moneda

    private Transform lastSpawnPoint; // Último punto de spawn usado

    void Start()
    {
        InvokeRepeating("SpawnObstacle", 1f, spawnInterval);
    }

    void SpawnObstacle()
    {
        // Selecciona un punto de spawn aleatorio que no sea el anterior
        Transform selectedSpawnPoint;
        do
        {
            selectedSpawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];
        } while (selectedSpawnPoint == lastSpawnPoint);

        lastSpawnPoint = selectedSpawnPoint; // Guarda la última posición usada

        // Instanciar un obstáculo aleatorio
        int index = Random.Range(0, obstacles.Length);
        Instantiate(obstacles[index], selectedSpawnPoint.position, Quaternion.identity);

        // Probabilidad de generar una moneda
        if (Random.value < coinChance)
        {
            Vector3 coinPosition = selectedSpawnPoint.position + new Vector3(0, 1.5f, 0);
            Instantiate(coinPrefab, coinPosition, Quaternion.identity);
        }
    }
}
