using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ClickTorso : MonoBehaviour
{
    [SerializeField] Image image;
    [SerializeField] TextMeshProUGUI text;
    public void onClick()
    {
        image.gameObject.SetActive(true);
        text.text = "blah blah torsos";
    }
}
