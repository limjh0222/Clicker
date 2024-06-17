using System.Collections;
using UnityEngine;

public class AutoCount : MonoBehaviour
{
    [SerializeField] private float waitSeconds = 2;

    private void Start()
    {
        StartCoroutine(AutoCounting());
    }

    IEnumerator AutoCounting()
    {
        while (true)
        {
            yield return new WaitForSeconds(waitSeconds);

            GameManager.Instance.Count++;
        }
    }
}
