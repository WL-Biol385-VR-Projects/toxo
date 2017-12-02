using System;
using System.Text;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class VoiceOn : MonoBehaviour
{
    //place this script onto the GameObject that will hold the audio source

    private string[] m_Keywords;

    private KeywordRecognizer m_Recognizer;
    public String Name;
    public GameObject thingon;
    public GameObject thingoff;

    void Start()
    {
        m_Keywords = new string[1];
        m_Keywords[0] = Name;
        m_Recognizer = new KeywordRecognizer(m_Keywords);
        m_Recognizer.OnPhraseRecognized += OnPhraseRecognized;
        m_Recognizer.Start();
    }

    private void OnPhraseRecognized(PhraseRecognizedEventArgs args)
    {
        if (args.text == m_Keywords[0])
        {
            thingon.SetActive(true);
            thingoff.SetActive(false);
        }
    }
}