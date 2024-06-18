using TMPro;
using UnityEngine;

public class UpgradeClick : UpgradeStat
{
    private int cost = 100;
    [SerializeField] private TextMeshProUGUI costTMP;
    [SerializeField] private TextMeshProUGUI clickTMP;

    private void Update()
    {
        costTMP.text = $"{cost}";
        clickTMP.text = $"Å¬¸¯ +1: {GameManager.Instance.Stat.clickCount}";
    }

    public override void Upgrade()
    {
        if (cost <= GameManager.Instance.Count)
        {
            GameManager.Instance.Stat.clickCount++;
            GameManager.Instance.Count -= cost;
            cost *= 2;
        }
    }
}
