using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class StartScene : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI consol;

    private Color consolColor;

    private void Start()
    {
        consolColor = new Color(255 / 255, 255 / 255, 255 / 255, 0);
        consol.color = consolColor;

        StartCoroutine(StartCutScene());
    }

    private IEnumerator StartCutScene()
    {
        consol.text = "개발\n\n2025.3.9 ~ 미정";

        while (consolColor.a < 1)
        {
            consolColor.a += Time.deltaTime;
            consol.color = consolColor;
            yield return null;
        }

        yield return new WaitForSeconds(1.5f);

        while (consolColor.a > 0)
        {
            consolColor.a -= Time.deltaTime;
            consol.color = consolColor;
            yield return null;
        }

        consol.text = "Project ST";

        while (consolColor.a < 1)
        {
            consolColor.a += Time.deltaTime;
            consol.color = consolColor;
            yield return null;
        }

        yield return new WaitForSeconds(1.5f);

        while (consolColor.a > 0)
        {
            consolColor.a -= Time.deltaTime;
            consol.color = consolColor;
            yield return null;
        }

        consol.text = "PM : 이태언\n\n개발 : 이태언\n\n기획 : 김준우, 이창현, 김호경, 조시현\n\n QA : 김준우, 이창현, 김호경, 조시현";

        while (consolColor.a < 1)
        {
            consolColor.a += Time.deltaTime;
            consol.color = consolColor;
            yield return null;
        }

        yield return new WaitForSeconds(1.5f);

        while (consolColor.a > 0)
        {
            consolColor.a -= Time.deltaTime;
            consol.color = consolColor;
            yield return null;
        }   

        SceneManager.LoadScene(1);
    }

}


