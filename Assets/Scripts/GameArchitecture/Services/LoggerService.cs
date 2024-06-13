using System;
using System.Collections.Generic;
using System.IO;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace GameArchitecture {

  [CreateAssetMenu(fileName = "LoggerService", menuName = "GameArchitecture/Services/LoggerService")]
  public class LoggerService: Service {
    public enum FormatType {
      Text,
      Html,
    }

    [SerializeField] FormatType type = FormatType.Html;
    [SerializeField] bool autoSave = false;

    public List<(string, LogType, DateTime)> Logs { get; private set; } = new();

    public override async UniTask InitializeAsync() {
        Application.logMessageReceived += HandleLog;

        Debug.Log("<color=#FFFF00>Logger</color> Service Initialized");
        await UniTask.DelayFrame(1); // Симуляция асинхронной задачи
    }

    public override async UniTask ShutdownAsync() {
        Debug.Log("Logger Service Shutdown");
        await UniTask.DelayFrame(1); // Симуляция асинхронной задачи
    }

    void HandleLog(string logString, string stackTrace, LogType logType) {
      Logs.Add(new(logString, logType, DateTime.Now));

      if (autoSave) {
        string ext = default;
        string data = default;
        switch (type) {
          case FormatType.Text: data = GetTextLog(); ext = "txt"; break;
          case FormatType.Html: data = GetHtmlLog(); ext = "html"; break;
        }
        File.WriteAllText($"{Application.persistentDataPath}/log.{ext}", data);
      }
    }

    string GetTextLog() {
      string text = "";
      foreach (var line in Logs) {
        text += $"[{line.Item3:HH:mm:ss}] {line.Item1}\n";
      }
      return text;
    }

    string GetHtmlLog() {
      string text = "";
      foreach (var line in Logs) {
        text += $"[<color=#7F8C8D>{line.Item3:HH:mm:ss}</color>] {line.Item1}<br>";
      }

      var htmlText = "<html>"
        + "<head><style> body { color: white; background-color: #121A22 } </style></head>"
        +"<body>"
        + text
        .Replace("<color=", "<font color=")
        .Replace("</color>", "</font>")
        + "</body></html>";

      return htmlText;
    }

  }
}
