using UnityEngine;
using TMPro;
using TriInspector;

namespace qb.EnvironmentBuild
{
    /// <summary>
    /// Displays build information in a TMP_Text component at startup.
    /// </summary>
    [RequireComponent(typeof(TMP_Text))]
    public class BuildInfoToTextField : MonoBehaviour
    {
        [SerializeField, Required]
        private BuildInfo buildInfo;

        void Start()
        {
            GetComponent<TMP_Text>().text = buildInfo.ToString();
        }

    }
}
