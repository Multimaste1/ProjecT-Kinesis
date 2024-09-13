using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbofProtection : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void FollowMouse()
    {
      Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector2(mousePosition.x, mousePosition.y);
    }

    // Update is called once per frame
    void Update()
    {
        FollowMouse();
    }
}
