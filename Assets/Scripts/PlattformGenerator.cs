using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    public GameObject platformPrefab;  // Dein Plattform-Prefab
    public Transform player;  // Der Spieler-Transform
    public float spawnHeight = 10f;  // Höhe, ab der neue Plattformen generiert werden
    public float platformDistance = 4.0f;  // Abstand zwischen Plattformen
    public float horizontalRange = 5f;  // Horizontale Verteilung der Plattformen
    public float platformLifetime = 20f;  // Lebensdauer der Plattformen

    private float lastSpawnY;  // Letzte Höhe, auf der eine Plattform generiert wurde
    private List<GameObject> platforms = new List<GameObject>();  // Liste aller generierten Plattformen

    void Start()
    {
        lastSpawnY = player.position.y - platformDistance;  // Startposition anpassen, um die erste Plattform zu generieren
        SpawnPlatforms();
    }

    void Update()
    {
        if (player.position.y + spawnHeight > lastSpawnY)
        {
            SpawnPlatforms();
        }
        CleanupPlatforms();
    }

    void SpawnPlatforms()
    {
        while (player.position.y + spawnHeight > lastSpawnY)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(-horizontalRange, horizontalRange), lastSpawnY + platformDistance, 0);
            GameObject newPlatform = Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
            platforms.Add(newPlatform);
            lastSpawnY += platformDistance;
        }
    }

    void CleanupPlatforms()
    {
        for (int i = platforms.Count - 1; i >= 0; i--)
        {
            if (platforms[i].transform.position.y < player.position.y - platformLifetime)
            {
                Destroy(platforms[i]);
                platforms.RemoveAt(i);
            }
        }
    }

    public float GetLowestPlatformY()
    {
        if (platforms.Count == 0) return float.MaxValue;
        float lowestY = platforms[0].transform.position.y;
        foreach (GameObject platform in platforms)
        {
            if (platform.transform.position.y < lowestY)
            {
                lowestY = platform.transform.position.y;
            }
        }
        return lowestY;
    }
}
