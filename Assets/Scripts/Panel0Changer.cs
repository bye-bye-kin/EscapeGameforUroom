using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Panel0Changer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public Image BedImage;
    public Sprite openbed;

    public void OnClickBed()
    {
        BedImage.sprite = openbed;
    }

}
