using qb.Pattern;
using TMPro;
using TriInspector;
using UnityEngine;
namespace qb.Datas
{
    [AddComponentMenu("qb/UI/Shared Datas/InputFieldSharedDataBinder")]
    public class InputFieldSharedDataBinder : MonoBehaviour
    {

        [SerializeField,Required,InlineEditor]
        String_SharedData sharedData;
        [SerializeField, Required]
        TMP_InputField inputField;

        public bool dispatchUdpateEvenOnSameValue = true;

        private void OnEnable()
        {
            if (sharedData)
            {                
                var d = SOWithGUID.GetSourceFromGUID(sharedData) as String_SharedData;
                if(d!=null && d!=sharedData)
                    sharedData = d;

                inputField.text = sharedData;
                inputField.onSubmit.AddListener(UpdateSharedData);
            }
        }
        private void OnDisable()
        {
            if (sharedData)
                inputField.onSubmit.RemoveListener(UpdateSharedData);
        }
        private void UpdateSharedData(string value)
        {
            if (sharedData)
            {

                if (sharedData.Value == value && dispatchUdpateEvenOnSameValue)
                    sharedData.DispatchChangeEvent();
                else
                    sharedData.Value = value;
            }
        }
        public void Submit()
        {
            UpdateSharedData(inputField.text);
        }
    }
}
