using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_sayur : MonoBehaviour
{
    public GameObject sayurPrefab;
    public float respawnTime = 1.0f;
    private Vector2 screenBounds;
    public float rangeJatuh;

    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToViewportPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(sayurWave());
    }
    private void spawnSayur()
    {
        GameObject a = Instantiate(sayurPrefab) as GameObject;
        a.transform.position = new Vector2(screenBounds.y * rangeJatuh, Random.Range(-screenBounds.x, screenBounds.x));
    }
    IEnumerator sayurWave()
    {
        while (true) {
            yield return new WaitForSeconds(respawnTime);
            spawnSayur();

        }
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
