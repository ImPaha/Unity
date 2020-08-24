using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetItem : MonoBehaviour
{
   public Text scoreview;
    int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreview.text = score.ToString();
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Hero")
        {

            PlayerPrefs.SetInt("score", PlayerPrefs.GetInt("score") + 1);
            Destroy(gameObject);
            
        }
    }

}
