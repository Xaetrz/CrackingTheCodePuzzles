using System;
using System.Collections.Generic;
using System.Text;

namespace CrackingTheCodePuzzles.Chapters.ObjectOrientedDesign
{
    public enum Suit { Spade, Heart, Club, Diamond }

    public abstract class Deck<T> where T: Card
    {
        private List<T> _cards;  // Card, dealt or otherwise
        public int _dealtIndex = 0;  // Index of last dealt card

        public void Shuffle() { /*Generic Implementation. Rearrange _cards and reset _dealtIndex*/ }
        public T DealCard() { /*Generic Implementation.*/ throw new NotImplementedException(); } 
    }

    public abstract class Card
    {
        public Suit Suit { get; private set; }
        public int FaceValue { get; private set; }

        public Card(Suit suit, int val)
        {
            this.Suit = suit;
            this.FaceValue = val;
        }
    }

    public abstract class Hand<T> where T: Card
    {
        private List<Card> _hand;

        public Hand() { _hand = new List<Card>(); }

        public abstract int Score();
        public void AddCard(Card card)
        {
            _hand.Add(card);
        }
    }



    public class BlackjackHand: Hand<Card>
    {
        Deck<Card> _deck;

        public override int Score()
        {
            throw new NotImplementedException();
        }
    }

    /*
    public class BlackJackCard: Card
    {

    }
    */
}
