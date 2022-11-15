using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBtn : MonoBehaviour
{
    [SerializeField] private GameObject textLevel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnClickBtnLevel(){
        Debug.Log($"Click: " + textLevel.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
