using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EnemySpawnLocation : MonoBehaviour
{
    public GameObject enemyprefab;
    float time = 0;
    // Start is called before the first frame update
    PlayerMovement player;
    ScoreManager scoremanager;
    private void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerMovement>();
        scoremanager = FindObjectOfType<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(time>2.0f &&player!=null)
        {
            float value = Random.Range(-0.3f, 3.97f);
            GameObject enemyRef = Instantiate(enemyprefab);
            enemyRef.transform.position = new Vector3(value, 6.0f, 0);
            time = 0;
            
        }
        else if(player==null)
        {
            SceneManager.LoadScene(2);
         

        }
        



    }

}
