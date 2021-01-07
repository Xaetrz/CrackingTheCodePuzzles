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

    public abstract class Hand<T> where T: Card
    {
        protected List<Card> _hand;

        public Hand() { _hand = new List<Card>(); }

        public abstract int Score();
        public void AddCard(Card card)
        {
            _hand.Add(card);
        }
    }

    public abstract class Card
    {
        public Suit Suit { get; protected set; }
        protected int FaceValue { get; set; } // True value of card (see Value method) differs by type of game 

        public Card(Suit suit, int val)
        {
            this.Suit = suit;
            this.FaceValue = val;
        }

        public abstract int Value();
    }

    public class BlackjackHand: Hand<BlackJackCard>
    {
        public override int Score()
        {
            int total = 0;
            foreach (Card c in base._hand)
            {
                total += c.Value();
            }
            return total;
        }
    }

    
    public class BlackJackCard: Card
    {
        public BlackJackCard(Suit suit, int val) : base(suit, val) { }

        public override int Value()
        {
            if (base.FaceValue == 1) return 11;
            else if (base.FaceValue >= 10 && base.FaceValue <= 12) return 10;
            return base.FaceValue;
        }

    }
    
}
