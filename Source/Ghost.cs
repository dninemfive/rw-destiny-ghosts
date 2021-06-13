using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse;
using RimWorld;

namespace RWGhosts
{
    public class Ghost : Apparel 
    {
        /// <summary>
        /// Holds a Pawn instance for use in creating <c>DirectPawnRelations</c>. Only used for its <c>Pawn_RelationsTracker</c>, otherwise ignored.
        /// Try to make most of these fields static?
        /// </summary>
        public Pawn DummyPawn;
    }
}
