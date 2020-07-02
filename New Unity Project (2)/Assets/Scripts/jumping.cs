using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumping : MonoBehaviour {

    public Vector2 jumpoffset;
    public float jumpwait = 0.5f;
    [HideInInspector]
    public bool inair = false;
    [HideInInspector]
    public float jmptpsd;

    private void Start()
    {
        gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);
        jmptpsd = jumpwait;
    }

    // Update is called once per frame
    void FixedUpdate () {
        //jumping effect timer
        jmptpsd += 1f * Time.deltaTime;

        //jump up
        if (inair == false && jmptpsd >= jumpwait)
        {
            gameObject.GetComponent<RectTransform>().anchoredPosition += jumpoffset;
            inair = true;
            jmptpsd = 0f;
        }

        //fall down
        if (inair == true && jmptpsd >= jumpwait)
        {
            gameObject.GetComponent<RectTransform>().anchoredPosition -= jumpoffset;
            inair = false;
            jmptpsd = 0f;
        }
    }
}
