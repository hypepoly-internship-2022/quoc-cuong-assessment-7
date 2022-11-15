using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LevelBtn : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textLevel;

    private TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        text = textLevel.GetComponent<TextMeshProUGUI>();
        text.text = this.name;
    }

    public void OnClickBtnLevel(){
        Debug.Log("Click: " + this.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
