using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor;


public class Showscore : MonoBehaviour
{
    public TextMeshProUGUI Scoretext;
    public BlockSpawner _blockspawner;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        string score = _blockspawner.totalsummon.ToString();
        Scoretext.text = score;
    }
}
