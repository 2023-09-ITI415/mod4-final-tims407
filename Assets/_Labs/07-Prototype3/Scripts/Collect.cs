using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collect : MonoBehaviour
{
    public Text countText;
    public Text endText;
    public Text restartButton;

    private Rigidbody rb;
    private int count;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        endText.text = "";
        restartButton.text = "";
    }
    void OnTriggerEnter(Collider pick)
    {
        if (pick.gameObject.CompareTag("Pick Up"))
        {
            pick.gameObject.SetActive(false);
            count++;
            SetCountText();
        }
    }
    void SetCountText()
    {
        countText.text = "Elements Collected: " + count.ToString();
        if(count >= 21)
        {
            endText.text = "All elements collected";
            restartButton.text = "Click to restart";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
