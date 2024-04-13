using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hover : MonoBehaviour
{
    public GameObject UI;
    void OnMouseOver()
    {
        UI.SetActive(true);
    }
    void OnMouseExit()
    {
        UI.SetActive(false);
    }
}
