using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Firebase.Database;
using Firebase.Extensions;

public class GraphController : MonoBehaviour
{
    [Header("UI Elements")]
    public Button stepButton;
    public Button fidgetButton;
    public RectTransform graphContainer;
    public GameObject pointPrefab;
    public GameObject linePrefab;

    [Header("Graph Decorations")]
    public GameObject axesContainer;
    public TMP_Text xLabel;
    public TMP_Text yLabel;

    private List<GameObject> graphPoints = new List<GameObject>();
    private DatabaseReference dbRef;

    void Start()
    {
        dbRef = FirebaseDatabase.DefaultInstance.RootReference;

        stepButton.onClick.AddListener(() => ShowGraph("StepHistory"));
        fidgetButton.onClick.AddListener(() => ShowGraph("FidgetHistory"));

        // Hide UI parts initially
        axesContainer.SetActive(false);
        xLabel.gameObject.SetActive(false);
        yLabel.gameObject.SetActive(false);
    }

    void ShowGraph(string type)
    {
        ClearGraph();

        // Show the axis and labels
        axesContainer.SetActive(true);
        xLabel.gameObject.SetActive(true);
        yLabel.gameObject.SetActive(true);

        dbRef.Child(type).GetValueAsync().ContinueWithOnMainThread(task =>
        {
            if (task.IsCompleted && task.Result.Exists)
            {
                var data = task.Result.Value as Dictionary<string, object>;
                List<string> timeLabels = new List<string>(data.Keys);
                timeLabels.Sort();

                float graphWidth = graphContainer.sizeDelta.x;
                float graphHeight = graphContainer.sizeDelta.y;
                float yMax = GetMaxY(data);

                Vector2 prevPoint = Vector2.zero;
                bool first = true;

                for (int i = 0; i < timeLabels.Count; i++)
                {
                    string time = timeLabels[i];
                    float value = float.Parse(data[time].ToString());

                    float xNorm = i / (float)(timeLabels.Count - 1);
                    float yNorm = value / yMax;

                    float xPos = ((i / (float)(timeLabels.Count - 1)) * graphWidth) - (graphWidth / 2f);
                    float yPos = ((value / yMax) * graphHeight) - (graphHeight / 2f);


                    GameObject point = Instantiate(pointPrefab, graphContainer);
                    point.GetComponent<RectTransform>().anchoredPosition = new Vector2(xPos, yPos);
                    graphPoints.Add(point);

                    if (!first)
                    {
                        DrawLine(prevPoint, new Vector2(xPos, yPos));
                    }

                    prevPoint = new Vector2(xPos, yPos);
                    first = false;
                }
            }
        });
    }

    void ClearGraph()
    {
        foreach (GameObject obj in graphPoints)
        {
            Destroy(obj);
        }
        graphPoints.Clear();
    }

    void DrawLine(Vector2 start, Vector2 end)
    {
        GameObject line = Instantiate(linePrefab, graphContainer);
        RectTransform rt = line.GetComponent<RectTransform>();
        Vector2 dir = (end - start).normalized;
        float dist = Vector2.Distance(start, end);

        rt.sizeDelta = new Vector2(dist, 3f);
        rt.anchoredPosition = start + dir * dist / 2f;
        rt.rotation = Quaternion.Euler(0, 0, Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg);

        graphPoints.Add(line);
    }

    float GetMaxY(Dictionary<string, object> data)
    {
        float max = 1f;
        foreach (var val in data.Values)
        {
            float f = float.Parse(val.ToString());
            if (f > max) max = f;
        }
        return max;
    }
}
