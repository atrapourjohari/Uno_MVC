using UnityEngine;

public class CardView : MonoBehaviour
{
    public CardData cardData; 
    private MeshRenderer _meshRenderer;

    private void Awake()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
    }

    public void InitCard()
    {
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _meshRenderer.materials[0].mainTexture=cardData.texture;
        _meshRenderer.materials[1].mainTexture = cardData.texture;
        _meshRenderer.materials[2].mainTexture = cardData.texture;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
