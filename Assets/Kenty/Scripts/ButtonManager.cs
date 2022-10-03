using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    [SerializeField]
    GameObject hideObject;
    //[SerializeField]
    //GameObject clearButton;
    //private string originalText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hideObject.activeSelf)
        {

        }
        else
        {
            if (Input.GetMouseButtonDown(0))
            {
                hideObject.SetActive(true);
            }
        }
    }

    public void OnHide(){
        if (hideObject.activeSelf)
        {
            hideObject.SetActive(false);
        }

        //if (hideObject.activeSelf)
        //{
        //    hideObject.SetActive(false);
        //    clearButton.GetComponent<Image>().color = new Color(255, 255, 255, 0);
        //    originalText = clearButton.transform.GetChild(0).GetComponent<Text>().text;
        //    clearButton.transform.GetChild(0).GetComponent<Text>().text = "";
        //}
        //else
        //{
        //    hideObject.SetActive(true);
        //    clearButton.GetComponent<Image>().color = new Color(255, 255, 255, 255);
        //    clearButton.transform.GetChild(0).GetComponent<Text>().text = originalText;
        //}
    }
}
