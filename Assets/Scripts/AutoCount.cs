using System.Collections;
using UnityEngine;

public class AutoCount : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(AutoCounting());
    }

    IEnumerator AutoCounting()
    {
        while (true)
        {
            yield return new WaitForSeconds(GameManager.Instance.Stat.waitSeconds);

            GameManager.Instance.Count += GameManager.Instance.Stat.autoCount;
        }
    }
}
