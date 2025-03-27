using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextBoxManager : MonoBehaviour
{
    public Text textBox;  // Assign your UI Text in Unity Editor
    public RectTransform textBoxBackground; // Assign the background panel
    public int maxLineLength = 50; // Adjust based on UI

    public void SetText(string message)
    {
        string formattedText = FormatText(message, maxLineLength);
        textBox.text = formattedText;
        StartCoroutine(AdjustTextBoxSize());
    }

    private string FormatText(string input, int maxLine)
    {
        string[] words = input.Split(' ');
        string formattedText = "";
        string line = "";

        foreach (string word in words)
        {
            if ((line + word).Length > maxLine)
            {
                formattedText += line + "\n";
                line = "";
            }
            line += word + " ";
        }
        formattedText += line;
        return formattedText;
    }

    IEnumerator AdjustTextBoxSize()
    {
        yield return null; // Wait for UI update
        LayoutRebuilder.ForceRebuildLayoutImmediate(textBoxBackground);
    }
}