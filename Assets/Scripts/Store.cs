using UnityEngine;

public class Store : MonoBehaviour
{
    public void PanelToggle()
    {
        gameObject.SetActive(!gameObject.activeInHierarchy);
    }
}
