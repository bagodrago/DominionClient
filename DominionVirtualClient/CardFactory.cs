using DominionVirtualClient.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DominionVirtualClient
{
    internal class CardFactory
    {
        private Dictionary<string, Type> cardTypes;
        public CardFactory()
        {
            // Checks for all Card classes in the program and makes them for you
            cardTypes = new Dictionary<string, Type>();

            foreach (Type type in Assembly.GetExecutingAssembly().GetTypes())
            {
                if (type.IsSubclassOf(typeof(Card)))
                {
                    cardTypes.Add(type.Name, type);
                }
            }
        }

        public CardDummy MakeCard(string cardName)
        {
            if (!cardTypes.ContainsKey(cardName)) 
            { 
                throw new ArgumentException("Card type does not exist: " + cardName); 
            }

            return new CardDummy(cardName, cardTypes[cardName]);
        }
    }

    struct CardDummy
    {
        public string Name { get; private set; }
        public Type CardType { get; private set; }

        public CardDummy(string name, Type cardType)
        {
            Name = name;
            CardType = cardType;
        }

        // Get a singleton of the card you need
        public Card soul()
        {
            if (!CardType.IsSubclassOf(typeof(Card)))
            {
                return null;
            }
            return (Card)Activator.CreateInstance(CardType);
        }

        public override string ToString() { return Name; }
    }
}
