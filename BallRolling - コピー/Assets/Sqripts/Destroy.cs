using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;
using static UnityEditor.Timeline.TimelinePlaybackControls;

public class Destroy : MonoBehaviour
{
   // public Text countText;
    //private int count;
     //Start is called before the first frame update
   // void Start()
   // {
        //count = 5;
        //countText.text = "Count: 5";
    //}
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag ("Player"))
        {
            Destroy(gameObject,0f);
           // count = count - 1;
           // countText.text = "Count: " + count.ToString();
        }
    }

    // Update is called once per frame
    
}
