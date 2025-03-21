﻿
using System.Collections.Generic;
using System;
using UnityEngine;
using Verse;
using RimWorld;

namespace AlphaMemes
{

    public class ThingSetMaker_Horses : ThingSetMaker
    {
        protected override void Generate(ThingSetMakerParams parms, List<Thing> outThings)
        {

           
                PawnKindDef horse = InternalDefOf.Horse;

                PawnGenerationRequest request = new PawnGenerationRequest(horse, Faction.OfPlayer, PawnGenerationContext.NonPlayer, -1, false, false, false, false, true, 1f);
                Pawn pawn = PawnGenerator.GeneratePawn(request);
                Pawn pawn2 = PawnGenerator.GeneratePawn(request);
                outThings.Add(pawn);
                outThings.Add(pawn2);

            
            

        }

        protected override IEnumerable<ThingDef> AllGeneratableThingsDebugSub(ThingSetMakerParams parms)
        {
            throw new NotImplementedException();
        }



    }
}

