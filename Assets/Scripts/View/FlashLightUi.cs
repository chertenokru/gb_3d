using UnityEngine;
using UnityEngine.UI;


namespace Geekbrains
{
    public sealed class FlashLightUi : MonoBehaviour
    {
        private Text _text;
        private Image _image;

        public float Progress
        {
            get => _image.fillAmount;
            set => _image.fillAmount = value;
        }


        private void Awake()
        {
            _text = GetComponentInChildren<Text>();
            _image = GameObject.FindGameObjectWithTag("FlashLightUI_Image").GetComponent<Image>();
        }
        

        public float Text
        {
            set => _text.text = (value > 0.01)? $"{value:0.0}":"Off";
        }

        public void SetActive(bool value)
        {
            _text.gameObject.SetActive(value);
        }
    }
}
