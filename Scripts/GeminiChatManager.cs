using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using System.Collections;
using System.Text;
using TMPro;
using System;

[System.Serializable]
public class GeminiResponse
{
    public Candidate[] candidates;
}

[System.Serializable]
public class Candidate
{
    public Content content;
}

[System.Serializable]
public class Content
{
    public Part[] parts;
}

[System.Serializable]
public class Part
{
    public string text;
}

public class GeminiChatManager : MonoBehaviour
{
    public TMP_InputField UserInputField;
    public Button sendButton;

    public GameObject chatbox; // Scroll View Content
    public ScrollRect scrollRect; // Reference to the Scroll View

    public GameObject userMessagePrefab;
    public GameObject aiMessagePrefab;

    private string apiKey = "AIzaSyB6kE734r_1BCXHn8jvV1zZOeTHFc6Dok8"; // Replace with actual API key
    private string apiUrl = "https://generativelanguage.googleapis.com/v1beta/models/gemini-1.5-pro-latest:generateContent?key=";

    void Start()
    {
        if (sendButton != null)
        {
            sendButton.onClick.AddListener(SendMessageToAI);
        }
        else
        {
            Debug.LogError("SendButton is not assigned in the Inspector.");
        }
    }

    public void SendMessageToAI()
    {
        string userMessage = UserInputField.text + "\n Reply with minimum words possible";
        if (string.IsNullOrEmpty(userMessage)) return;

        // **Create User Message**
        //CreateMessage(userMessage, userMessagePrefab);

        UserInputField.text = "";
        StartCoroutine(GetAIResponse(userMessage));
    }

    IEnumerator GetAIResponse(string message)
    {
        if (string.IsNullOrEmpty(apiKey))
        {
            Debug.LogError("API Key is missing!");
            yield break;
        }

        string fullUrl = apiUrl + apiKey;
        string jsonData = "{\"contents\": [{\"parts\": [{\"text\": \"Act as a funny AI guide for new students in VIT college. Crack jokes about campus life. User asks: " + message + "\"}]}]}";

        byte[] bodyRaw = Encoding.UTF8.GetBytes(jsonData);

        using (UnityWebRequest request = new UnityWebRequest(fullUrl, "POST"))
        {
            request.uploadHandler = new UploadHandlerRaw(bodyRaw);
            request.downloadHandler = new DownloadHandlerBuffer();
            request.SetRequestHeader("Content-Type", "application/json");

            yield return request.SendWebRequest();

            if (request.result == UnityWebRequest.Result.Success)
            {
                string responseText = request.downloadHandler.text;
                string aiResponseText = ExtractAIResponse(responseText);

                // **Create AI Message**
                CreateMessage(aiResponseText, aiMessagePrefab);
            }
            else
            {
                Debug.LogError("API Request Error: " + request.error);
            }
        }
    }

    private string ExtractAIResponse(string jsonResponse)
    {
        try
        {
            GeminiResponse response = JsonUtility.FromJson<GeminiResponse>(jsonResponse);

            if (response.candidates != null && response.candidates.Length > 0 &&
                response.candidates[0].content != null && response.candidates[0].content.parts != null &&
                response.candidates[0].content.parts.Length > 0)
            {
                return response.candidates[0].content.parts[0].text;
            }
            else
            {
                return "AI is confused";
            }
        }
        catch (Exception e)
        {
            Debug.LogError("Error parsing JSON: " + e.Message);
            return "Something went wrong!";
        }
    }

    private void CreateMessage(string message, GameObject prefab)
    {
        GameObject messageObj = Instantiate(prefab, chatbox.transform);
        TMP_Text messageText = messageObj.GetComponentInChildren<TMP_Text>();
        messageText.text = message;

        // Force layout update to position elements properly
        LayoutRebuilder.ForceRebuildLayoutImmediate(chatbox.GetComponent<RectTransform>());

        // Auto-scroll to the latest message
        Canvas.ForceUpdateCanvases();
        scrollRect.verticalNormalizedPosition = 0f;
    }
}
