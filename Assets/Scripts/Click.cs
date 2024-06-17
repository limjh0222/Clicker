using UnityEngine;

public class Click : MonoBehaviour
{
    public void OnClick()
    {
        GameManager.Instance.Count++;
    }
}
