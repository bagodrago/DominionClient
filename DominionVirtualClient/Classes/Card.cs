using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DominionVirtualClient.Classes
{
    internal abstract class Card
    {
        public string Name { get; internal set; }
        public int Cost { get; internal set; }
        public Player Owner { get; set; }

    }

    internal abstract class PlayableCard : Card 
    { public abstract void Effect(); }

    internal abstract class ActionCard : PlayableCard { }
    internal abstract class AttackCard : ActionCard { }
    internal abstract class ReactionCard : ActionCard { }

    internal abstract class TreasureCard : PlayableCard 
    { 
        public int Value { get; internal set; }
        public override void Effect() { Owner.Treasure += Value; }
    }

    internal abstract class VictoryCard : Card 
    { 
        public int Value { get; internal set; }
    }

    internal abstract class VariableVictoryCard : VictoryCard
    {
        // Victory cards worth different values at game end (e.g. Gardens)
        VariableVictoryCard() { Value = 0; }
        public abstract int CalculateValue();
    }
}
