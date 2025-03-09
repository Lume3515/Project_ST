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
        consol.text = "����\n\n2025.3.9 ~ ����";

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

        consol.text = "PM : ���¾�\n\n���� : ���¾�\n\n��ȹ : ���ؿ�, ��â��, ��ȣ��, ������\n\n QA : ���ؿ�, ��â��, ��ȣ��, ������";

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


