using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardColorChanger : MonoBehaviour
{
    public CardInform cardInform;

    [Header("색상 바꿀 Renderer")]
    public Renderer[] cardRenderers;

    // 리스트에 있는 카드들의 Renderer.material.Color의 색 변경
    public void ChangeCardColors(Card card)
    {
        if (cardRenderers != null)
        {
            Color color = GetColorForCardType(card.cardType);
            ApplyColorToRenderers(color);
        }
    }

    private Color GetColorForCardType(Card.CardType rank)
    {
        switch (rank)
        {
            case Card.CardType.WarriorCard:
                return cardInform.WarriorColor;
            case Card.CardType.ArcherCard:
                return cardInform.ArcherColor;
            case Card.CardType.WizardCard:
                return cardInform.WizardColor;
            default:
                return Color.white;
        }
    }

    private void ApplyColorToRenderers(Color color)
    {
        foreach (Renderer renderer in cardRenderers)
        {
            if (renderer != null && renderer.material != null)
            {
                renderer.material.color = color;
            }
        }
    }
}
