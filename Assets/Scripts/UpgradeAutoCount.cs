using TMPro;
using UnityEngine;

public class UpgradeAutoCount : UpgradeStat
{
    private int cost = 150;
    [SerializeField] private TextMeshProUGUI costTMP;
    [SerializeField] private TextMeshProUGUI autoCountTMP;

    private void Update()
    {
        costTMP.text = $"{cost}";
        autoCountTMP.text = $"ÀÚµ¿ +1: {GameManager.Instance.Stat.autoCount}";
    }

    public override void Upgrade()
    {
        if (cost <= GameManager.Instance.Count)
        {
            GameManager.Instance.Stat.autoCount++;
            GameManager.Instance.Count -= cost;
            cost *= 2;
        }
    }

}
