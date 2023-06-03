using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class Scrapbook : MonoBehaviour
{
    public List<Collectible> collectiblesList;
    public List<GameObject> indexList;

    public GameObject scrapbookPage;

    // Start is called before the first frame update
    void Start()
    {
        int count = 0;
        foreach(Collectible collectible in collectiblesList)
        {
            if(collectible.collected)
            {
                indexList[count].GetComponentInChildren<TextMeshProUGUI>().text = collectible.title;
                indexList[count].GetComponent<Image>().sprite = collectible.picture;
                indexList[count].GetComponent<Image>().color = Color.white;            }
            else
            {
                indexList[count].GetComponent<Image>().sprite = collectible.background;
            }
            count++;
        }
    }

    public void FillPage(int index)
    {
        if(collectiblesList[index].collected)
        {
            scrapbookPage.GetComponent<FillPage>().collectible = collectiblesList[index];
            scrapbookPage.SetActive(true);
        }
    }
}
