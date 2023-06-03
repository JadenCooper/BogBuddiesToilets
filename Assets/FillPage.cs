using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FillPage : MonoBehaviour
{
    public Collectible collectible;

    public GameObject background;
    public GameObject picture;
    public TextMeshProUGUI title;
    public TextMeshProUGUI description;

    void OnEnable()
    {
        if(collectible)
        {
            Debug.Log(collectible.background);
            background.GetComponent<Image>().sprite = collectible.background;
            picture.GetComponent<Image>().sprite = collectible.picture;
            title.text = collectible.title;
            description.text = collectible.description;
        }
    }
}
