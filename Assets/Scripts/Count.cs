using TMPro;
using UnityEngine;

public class Count : MonoBehaviour
{
    private TextMeshProUGUI countTMP;

    private void Awake()
    {
        countTMP = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        countTMP.text = $"{GameManager.Instance.Count}";
    }
}
