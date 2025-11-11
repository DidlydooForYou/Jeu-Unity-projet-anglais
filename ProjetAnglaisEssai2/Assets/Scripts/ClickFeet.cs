using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ClickFeet : MonoBehaviour
{
    [SerializeField] Image image;
    [SerializeField] TextMeshProUGUI text;
    public void onClick()
    {
        image.gameObject.SetActive(true);
        text.text = "blah blah feets";
    }
}
