# Arcade-Mechanics-BO

## De opdracht
tijdens deze eindopdracht is het de bedoeling dat we een game maken met minimaal 4 mechanics 

## Beoordeling:
Tijdens de opdracht worden we beoordeeld op de volgende punten:


#### Game Development:
- Wij moeten minimaal 4 tutorials uitgewerkt en afgetekend hebben.
- De code in ons project moet minimaal een van de volgende vorm van     collection bevatten:
    - Array
    - List
    - overige vorm
- De game moet minimaal 3 van de volgende mechancs bevatten:
  - lopen of rennen (geanimeerd character 3rd person)
  - shieten en vernietigen van obstakels / enemies (kogels en impact zijn mooi afgewerkt met effecten en geluiden)
  - lekker springen (geanimeerd en niet "floaty")
  - enemies schieten op de speler (netjes afgewerkt met animaties en effecten)
  - Mooi afgewerkt scoresysteem incl. UI waarbij er dmv effecten aandacht wordt getrokken naar het scorebord
  - Traps die worden getriggered als de speler deze raakt of langs loopt. inclusief effecten en animaties
  - Powerups/Pickups systeem waarbij er items opgepakt kunnen worden die zichtbaar een buff voor de speler opleveren. Inclusief effecten op de pickup en om de buff aan te tonen.
  - Timing systeem, waarbij er een UI is met een timer en de speler binnen de tijd een doel moet bereiken. Incl. effecten als de tijd bijna op is en op is. Het systeem moet spanning creeren.

#### Game Engines:
Ook moeten de volgende Unity systemen aantoonbaar gebruikt zijn:

- De animator controller
- Een particle system
- Prefabs
- de Input manager
- Unity Events (voor afspelen geluiden).

#### Onze uitdagingen:
Tijdens dit project hebben wij enkele uitdagingen gehad met het maken van onze game. Onze grootste uiddaging hiervan was om de wapens te laten schieten met een bepaalde kracht en richtingen ect. Hierbij hebben wij samen gekeken hoe we dit het best konden oplossen met behulp van elkaar en internet. Voor het schieten hebben wij nu bij het schieten de richtingen vastgeleged, hierna word de kogel vooruit geschoten doormiddel van de "Forward" as van de wapen. 

Het laten lopen en achtervolgen van de zombie's was ook niet makkelijk. Dit kosten veel tijd om de animatie's te laten werken en de damage systeem te laten werken. Dit hebben wij opgelost met state's voor de animatie's en voor de hits hebben wij een ontzichtbare sphere op de arm van de enemy met de tag zombieHand. wanneer deze sphere met de tag in contact komt met de player zal er een vooraf meegegeven damage van de speler health afgetrokken worden.

