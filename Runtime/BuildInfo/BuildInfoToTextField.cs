using UnityEngine;
using TMPro;
using TriInspector;

namespace qb.EnvironmentBuild
{
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
