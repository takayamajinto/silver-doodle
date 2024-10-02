using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody rb;
    public Text countText;
    private int count;
    public Text winText;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 5;
        countText.text = "Count: 5";
        winText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        float dx = Input.GetAxis("Horizontal");
        float dz = Input.GetAxis("Vertical");
        var movement = new Vector3(dx, 0, dz);
        rb.AddForce(movement * 0.5f);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("coin"))
        {         
            count = count - 1;
            countText.text = "Count: " + count.ToString();
            if (count == 0)
            {
                winText.text = "GAME CLAER!!";
            }
        }
    }
}
