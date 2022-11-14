using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelPopup : MonoBehaviour
{

    [SerializeField] private GameObject prefabLevel;
    [SerializeField] private GameObject inventory;

    [SerializeField] private int levelUWant;

    // Start is called before the first frame update
    void Start()
    {
        spawnLevelBtn(levelUWant);
    }

    void spawnLevelBtn(int idx){
        for(int i=0; i<idx; i++){
            GameObject game = Instantiate(prefabLevel, new Vector3(0,0,0), Quaternion.identity);
        }   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
