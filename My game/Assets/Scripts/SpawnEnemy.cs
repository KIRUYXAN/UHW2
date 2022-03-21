using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject fiery;
    public Transform spawnp;
    private bool _spawn;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P)) _spawn = true;
    }
    private void FixedUpdate()
    {
        if(_spawn)
        {
            _spawn = false;
            spawn(fiery);
        }
    }
    private void spawn(GameObject enemyp)
    {
        Instantiate(enemyp, spawnp.position, spawnp.rotation);
    }
}