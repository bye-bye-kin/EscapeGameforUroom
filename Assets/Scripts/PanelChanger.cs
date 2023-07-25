using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelChanger : MonoBehaviour
{
  
    void Update()
    {
    }
        public void OnRightArrow()
    {
        this.transform.position = new Vector2(transform.position.x - 18f, 0);

        if(this.transform.position.x < - 54f)
        {
            this.transform.position = new Vector2(0, 0);
        }

    }

   public void OnLeftArrow()
    {
        this.transform.localPosition = new Vector2(0, 0);
    } 



}
