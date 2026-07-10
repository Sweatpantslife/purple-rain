# PURPLE RAIN — Location Bible (v1.0)

> **Phase 2 production storyboard.** All **30 registered locations** of *Purple Rain*, grouped by story region, at blockout-brief depth. Companion to [`SCENES.md`](SCENES.md) (scene-by-scene storyboard) and [`CHARACTERS.md`](CHARACTERS.md). Derived exclusively from the narrative canon: [`../narrative/STORY.md`](../narrative/STORY.md), [`../narrative/MYSTERY_LOGIC.md`](../narrative/MYSTERY_LOGIC.md), [`../narrative/TIMELINE.md`](../narrative/TIMELINE.md). This document adds staging and level-design depth, not new canon; any conflict resolves in favor of the narrative docs.
>
> **Spoiler policy:** total spoilers throughout. Playtesters and blind contractors should not read this document.

## Legend

- **Location IDs** (`LOC-*`), scene IDs (`A<act>-S<scene>`), character IDs (`CH-*`), clue/red-herring/reveal tags (`C-##`, `RH-##`, `R0`–`R5`) are canonical and shared with the narrative docs and the rest of the storyboard.
- **Anchors:** every location exposes an HTML anchor equal to its ID in lowercase (`#loc-<name>`), per the link convention in `SCENES.md`. Do not rename anchors without updating every `LOCATIONS.md#loc-*` link.
- **Entry format:** ID / Name → Description → Atmosphere → Layout notes for level design → Used in scenes → State changes.
- **"Used in scenes"** lists are copied verbatim from the canonical registry: primary scenes first, then *(sec)* secondary uses. A location's blockout must serve every scene on its list.
- **Structure assumption** (STORY.md §10): hub-based — the Lantern as safehouse hub from Act II, districts unlocked by Kray-passage; Acts 0–I linear. Locations below are authored sets and corridors, not open-world cells.

## The palette doctrine — purple and rain, used deliberately

The title is the oldest clue in the game (STORY.md §3.2, §8), so the art direction must ration its two title elements like plot information.

**Purple is earned.** The color obeys the reveal ladder:

1. **Act 0 — purple as commerce and consecration.** Violet appears only in things that *lie about it or encode it*: Ascension ad glow, the St. Brigid's window (C-33), the buffed-and-repainted graffiti (C-02), flashbulbs strobing the wet street "violet-white" at the raid. **Never in water.** The player must leave Act 0 having seen purple everywhere and never once in the element it belongs to.
2. **Act I — purple withdrawn.** The Fall is played in institutional bone-grey and sodium orange. The frame's venues (courthouse, news studios) are deliberately colorless; the one violet note is the name "Violet Marsh" (C-35) — purple as a word, weaponized.
3. **Act II — first blood.** A2-S03 is the first time in the entire game that purple appears *in water* (live leachate, R0 begins). Protect this: audit every Undercroft asset upstream of A2-S03 for accidental violet. From here purple below = the wound (leachate, sump slick, stained tide-lines); purple above = the lie (branding, bunting, glass).
4. **Act III — purple as receipt.** The window decoded (C-24), the mauveine relics of the Voss house, the Trust's civic-purple branding: the conspiracy's vanity color, always dry, always behind glass.
5. **Act IV — the sky testifies.** A4-S07 spends the whole budget: first-draw glass, fountain, streets, rain. After it, the epilogue returns to *clean* rain — the absence of purple as the happy ending.

**Rain is a register, not weather.** Authoring scale, used throughout the entries below: **mist → soft → steady → hard → storm → Vesper** — plus a valence axis: *warm rain* (Act 0 domesticity, the epilogue), *indifferent rain* (A3-S08, canon), *hostile rain* (chases, Vesper). Interiors are characterized by how they treat rain sound: the rowhouse lets it in as comfort, the courthouse excludes it entirely, the Undercroft replaces it with drips and pump-throb, and the Lantern turns it into shelter-noise.

**Light sources are factions.** Tungsten/lantern amber = the discarded and the domestic. Fluorescent/bone = the institutions. Sodium orange = the streets and the hunt. Candle-and-brass = the Vestry's liturgical spaces. Broadcast white = the finale. Violet is never a light source until A2-S03, and never a *dominant* one until A4-S07.

## Index of locations by story region

| Region | Locations |
|--------|-----------|
| **1. Adam's old life — Lowmarsh & the surface city** | [LOC-vale-rowhouse](#loc-vale-rowhouse) · [LOC-meridian-streets](#loc-meridian-streets) · [LOC-marsh-gate](#loc-marsh-gate) · [LOC-waterworks](#loc-waterworks) · [LOC-lowmarsh](#loc-lowmarsh) · [LOC-lowmarsh-restaurant](#loc-lowmarsh-restaurant) · [LOC-st-brigids](#loc-st-brigids) · [LOC-betting-cafe](#loc-betting-cafe) |
| **2. Institutional Meridian — the machine's public face** | [LOC-courthouse](#loc-courthouse) · [LOC-archive-annex](#loc-archive-annex) · [LOC-depot](#loc-depot) · [LOC-ag-office](#loc-ag-office) |
| **3. The Below — the Undercroft** | [LOC-undercroft](#loc-undercroft) · [LOC-lantern](#loc-lantern) · [LOC-forge-shop](#loc-forge-shop) · [LOC-nightingale-hall](#loc-nightingale-hall) · [LOC-seal-chamber](#loc-seal-chamber) |
| **4. Vestry & the old city — Cathedral Hill and the consecrated ledger** | [LOC-vestry-row](#loc-vestry-row) · [LOC-st-albans](#loc-st-albans) · [LOC-vestry-crypt](#loc-vestry-crypt) · [LOC-voss-house](#loc-voss-house) |
| **5. Conspiracy spaces — the deal's territory** | [LOC-meridian-trust](#loc-meridian-trust) · [LOC-ascension-plaza](#loc-ascension-plaza) · [LOC-aegis-vault](#loc-aegis-vault) · [LOC-airfield](#loc-airfield) · [LOC-cordell-cabin](#loc-cordell-cabin) |
| **6. Margins — spaces of loss and reckoning** | [LOC-duval-flat](#loc-duval-flat) · [LOC-squat](#loc-squat) · [LOC-cemetery](#loc-cemetery) · [LOC-transit-yard](#loc-transit-yard) |

---

# REGION 1 — ADAM'S OLD LIFE: LOWMARSH & THE SURFACE CITY

*The Flats and the workplaces of the life that gets amputated. These sets carry Act 0's warmth and Act I's collapse, and several return, transformed, in Acts III–IV. Design brief for the region: everything here must be worth losing — density of loved, ordinary detail is the region's production value.*

<a id="loc-vale-rowhouse"></a>
### LOC-vale-rowhouse — The Vale rowhouse

- **ID / Name:** LOC-vale-rowhouse — The Vale rowhouse
- **Description:** A narrow two-storey brick rowhouse on Lowmarsh's nicer edge — high enough up the grade that the chronic flooding stops two streets short of the stoop, which is precisely the social distance Adam's salary bought. Ten years of marriage visible in every object: the notebook shelf with forty-one dated spines, wedding photos up the stair, an anniversary card beading condensation on the fridge, Mara's clinic rota magnetized beside it. On screen it reads instantly as *modest, loved, lived-in* — the camera should never find a luxury, only care. It is the site of the good life (A0-S01), the raid (A0-S08), the siege (A1-S04/S05), and the beginning of the run (A1-S08): the same rooms performing four different tragedies.
- **Atmosphere:** Warm tungsten interior against blue-grey soft spring rain on the bay window; radiators tick; the kettle is the first sound cue of the game. Purple discipline: only a faint Ascension-billboard glow reflected in wet slate roofs across the street — subliminal. Sound: rain-as-comfort in Act 0 (the house *lets rain in* acoustically); by A1-S05 the mix inverts — canon: "the house is empty and the rain is very loud." Raid state: hard rain, breach clatter, flashbulbs strobing the street violet-white through the open door.
- **Layout notes for level design:**
  - Two floors plus shallow cellar. Ground: entry hall (door with chain — the breach point), front room (sofa, TV, wedding photos, bay window onto the street), kitchen/dining at the rear (the A1-S05 table), scullery door to a walled back yard, yard gate to a service alley.
  - Upper: bedroom (game's opening shot: rain on glass, alarm at 6:40), bathroom, and Adam's box-room study — desk with the drawer (C-07 badge, present in A0-S01, **missing** in the A0-S06 evening beat), home terminal (QA email bounce, C-09), the notebook shelf (examinable spines; after A0-S08 the emptied shelf is the room's wound).
  - The stair landing is the raid's blocking: player held kneeling at the hall's midpoint, officers two-abreast (hall width must allow it), evidence-bag path from study → stairs → door crossing the player's fixed sightline; the warrant readable for a scripted two seconds at ~1 m (C-10).
  - Interactive props by scene: kettle/radio/fridge card/notebook shelf (A0-S01 tutorial); desk drawer (A0-S06); terminal, TV news drip, phone calls, blinds-peek at the news vans (A1-S04); the kitchen table dressed with three documents in a row (A1-S05 — must play from a locked cutscene camera *and* a slow player orbit); chess app ping in the dark front room, single lamp (A1-S07).
  - A1-S08 escape route: bedroom wake → rear window or scullery → yard → alley gate (front of house already strobing blue-red). The alley connects toward LOC-lowmarsh chase fabric. Verticality minimal; the yard wall vault is the tutorialized mantle move.
  - Stealth/action affordances: none in Act 0 (deliberate); the house only becomes traversal geometry in A1-S08 — same rooms, new verbs, which is the design point.
- **Used in scenes:** A0-S01, A0-S08, A1-S04, A1-S05, A1-S07; *(sec)* A0-S06 (that evening — the desk drawer), A1-S08 (the run begins here).
- **State changes:**
  - **A0-S01:** pristine domestic warm; every prop in its loved place.
  - **A0-S06 (eve):** dusk lighting; the drawer beat — one object missing from an established set.
  - **A0-S08:** raid dressing — door off the chain, drawers pulled, muddy boot tracks on the runner, notebook shelf stripped to dust-lines, evidence tape.
  - **A1-S04:** siege — curtains drawn at noon, TV never off, dishes multiplying, mail drifting at the door, news-van light bleeding through blinds.
  - **A1-S05:** the table set with three documents; afterward Mara's absences read as negative space — coat hooks, bathroom shelf, her side of the wardrobe.
  - **A1-S07:** near-dark, one lamp, a half-packed bag; the house already a memory Adam is standing in.
  - **Not revisited after A1-S08** — deliberate: the epilogue's new house (A4-S10, under LOC-meridian-streets montage) is explicitly *not* this one. Restoration is refused at the level-design level.

<a id="loc-meridian-streets"></a>
### LOC-meridian-streets — Meridian streets & tramways

- **ID / Name:** LOC-meridian-streets — Meridian streets & tramways
- **Description:** The surface-city traversal fabric: tram lines stitching the three vertical layers together — brick terraces and chronic puddles in the Flats, the glass-and-lobby downtown of Glasswater, and the granite shoulder of Cathedral Hill above. Built as a *moving establishing shot*: the tram window is the game's widest lens, and the walk segments are its documentary close-ups — scaffolding under Ascension billboards, a WHOSE WATER? protest sticker on tram glass, laundry lines, sandbags stacked with the resignation of habit. This is where the player learns the city's grammar before learning its secret.
- **Atmosphere:** Act 0: steady morning rain, wistful; sodium and daylight-grey; Ascension ads supply the only saturated color — civic violet, dry, backlit (palette doctrine rule 1: an Ascension ad reflected in a curbside puddle is the one sanctioned purple-touches-water image, and it's *advertising*, i.e. a lie). Sound: tram hum and bell, rain on the roof skin, street vendors, distant river horns. Epilogue: ordinary clean rain, warmer grade, remediation cranes on the skyline where billboards used to be.
- **Layout notes for level design:**
  - Authored corridor, not open world: a tram spine with three walkable segments (Lowmarsh terrace street → Marsh Gate approach → MWA frontage) and two scripted vista nodes (the elevated curve revealing Cathedral Hill / Vestry Row; the river bend revealing the shuttered Halcyon works far off).
  - The tram itself is a set: seats, straps, window-wipe reveal timing for the Cathedral Hill vista; the protest sticker at eye level by the door.
  - Interaction pockets: the pigeon-feeding folktale teller (optional NPC, A0-S02 — the purple-rain tale, C-02 support), journal-able posters and plaques (T-1871 historical flavor), the tram-stop shelter where the player first stands still long enough to hear the rain change register.
  - Puzzle props: none — this fabric deliberately contains zero puzzle grammar; it exists to establish normalcy and scale.
  - A4-S10 reuses the fabric as a citywide epilogue montage (see State changes): build the Act 0 segments so set-dressing swaps (billboards → cranes; sandbags → new curb drains; wanted posters → weathered court-notice paste-ups) can retell the city without new geometry.
- **Used in scenes:** A0-S02, A4-S10 (citywide montage).
- **State changes:**
  - **A0-S02:** spring rain, Ascension saturation, the intact ordinary city — everything the game will spend 30 weeks dismantling.
  - **A4-S10 (≈ V + 5 months):** same routes re-dressed — remediation cranes over the Vats on the skyline, Kray's licensed boats visible from the river bend, the Lantern's legal signage glimpsed at a grate, Ascension branding scrubbed to ghost-lettering (rhyming with the buffed graffiti motif), rain ordinary and staying that way. The montage's thesis: not restored — *begun*.

<a id="loc-marsh-gate"></a>
### LOC-marsh-gate — Marsh Gate underpass & steps

- **ID / Name:** LOC-marsh-gate — Marsh Gate underpass & steps
- **Description:** A road underpass at Lowmarsh's downhill edge where the embankment swallows the street, and beside it a flight of worn stone steps dropping to a chained storm-tunnel gate. On the underpass wall, the graffiti: **WHEN THE RAIN RUNS PURPLE** — fresh letters over the buffed ghosts of every previous repainting, a palimpsest the city keeps trying to erase and unknown hands keep restoring (C-02). It is the game's title said by the city, and the canonical threshold between surface and Below: the player passes it as color in Act 0 and *descends through it* fleeing for his life in Act I.
- **Atmosphere:** Sodium lamps in permanent dusk under the span; water sheets off the road above in curtains at the underpass mouths. The graffiti's letters are deep violet — the largest sanctioned purple element in Act 0, and it is *paint*: folklore, not yet fact. Sound: traffic drumming overhead, echo-wet footsteps, the gate's chain. A1-S08: storm register, drone rotors, spotlight sweeps that the underpass geometry defeats — this is a camera dead-zone and the level design should make the player *feel* surveillance failing here.
- **Layout notes for level design:**
  - Three elements: the underpass (a two-lane span with pedestrian margins), the graffiti wall (full-height, lit by one surviving sodium lamp — hold-able camera beat in both scenes), and the step flight down to a landing with the storm-tunnel grate (the Undercroft threshold; connects to LOC-undercroft).
  - A0-S02 use: walk-through with optional lingering; graffiti examine → journal entry; the folktale teller sits within earshot (fabric handoff with LOC-meridian-streets).
  - A1-S08 use: chase funnel — approach lanes from the Lowmarsh yards converge here; the underpass kills the drone light-cones (scripted); the steps are the point of no return (one-way drop; design the landing camera to look back *up* at the graffiti as the player goes under — the title over the descent into hell).
  - The grate: chained in A0 (examine only), forced/ajar in A1-S08 (scripted entry, swallowed by rising water beyond — leads to the near-drowning sequence in LOC-undercroft).
  - Stealth/action affordances: pillar cover, deep shadow margins, a maintenance recess (hide spot) — all tuned for one high-speed traversal, not repeat play.
- **Used in scenes:** *(sec)* A0-S02, A1-S08.
- **State changes:**
  - **A0-S02:** daylight-grey, wet, ordinary; graffiti freshly repainted; gate chained.
  - **A1-S08 (Day 18, 5:55 AM, swelling storm):** pre-dawn black, spotlights, water already ankle-deep at the landing; the gate is the mouth of the flood. Same geometry, register flipped from *omen* to *prophecy in progress*.

<a id="loc-waterworks"></a>
### LOC-waterworks — Meridian Water Authority offices

- **ID / Name:** LOC-waterworks — Meridian Water Authority offices
- **Description:** MWA headquarters: a mid-century civic block with a colonnaded street frontage, a badge-gated lobby, an open-plan **flow-map floor** built around a central projection table where the city's water renders live, a records room of terminals and microfiche, and a rooftop cafeteria under a rain awning with one chessboard worn smooth by two decades of lunches. This is Adam's competence made architecture — the place where he is *the one they call when the numbers feel wrong* — and the stage of four Act 0 scenes including the tripwire (A0-S04) and the most expensive nothing in the game (A0-S05). In the epilogue it returns as the field office where the creed is handed on.
- **Atmosphere:** Confident, mundane fluorescence; the flow-map table throws cool cartographic blue-cyan across faces — the game's *clean* water color, established here precisely so that violet-in-water reads as violation later. Rain is visible through big windows but acoustically distant: work as shelter. The rooftop is the exception — rain on the awning, the city's three layers visible in one pan (Heights / Flats / river), warm paternal light for the Cordell scene. No purple anywhere inside MWA, ever: this institution believes itself clean.
- **Layout notes for level design:**
  - Four sub-sets on one footprint: (1) **street frontage & lobby** — colonnade (A0-S06 Theo intercept plays here, outside the badge gates: the brother who can't come in), badge-gate turnstiles, elevator bank; (2) **flow-map floor** — desks orbiting the projection table; the Sector 9 anomaly puzzle (A0-S03) runs on the table: this set is the *classroom* for the game's tracer-logic puzzle grammar, so its UI staging must be reusable in later evidence-board and valve-network contexts; Adam's desk with inbox (CLEARWATER memo, C-03) and the P.E. stamp framed casually like a stapler; (3) **records room** — terminal bay + fiche drawers; the A0-S04 discrepancy-spot interaction (archived Fig. 12 vs notebook #29) needs a two-document comparison UI station; (4) **rooftop cafeteria** — chess table with parapet backdrop, vending, the awning line where rain becomes audible again.
  - Circulation: lobby → elevator → floor → records is the player's daily loop; make it comfortable by the third traversal — the comfort is what Act I amputates.
  - Puzzle props: flow-map table (Sector 9), records terminal (TS-19/44 pull), notebook #29 (inventory-check interaction). No locks, no stealth — the only building in the game Adam enters entirely by right, once.
  - Epilogue re-dress (A4-S10, *(sec)*): a satellite **field office** variant — same visual language, smaller: one flow-map desk, a terrified rookie engineer, a blank field notebook prop for the final handoff. Can be a re-dressed corner of set (2).
- **Used in scenes:** A0-S03, A0-S04, A0-S05 (rooftop cafeteria), A0-S06 (street outside); *(sec)* A4-S10 (epilogue field office).
- **State changes:**
  - **Act 0:** intact, confident, mundane — Adam's standing legible in colleagues' body language.
  - **A4-S10:** the field-office variant, months after the fall of the frame; TS-19/44 re-certified, Adam reinstated, remediation-era paperwork on every desk; light grade warmer, rain ordinary. The chessboard on the rooftop is *not* revisited — leave that grief where it lives.

<a id="loc-lowmarsh"></a>
### LOC-lowmarsh — Lowmarsh (the Flats), street level

- **ID / Name:** LOC-lowmarsh — Lowmarsh (the Flats), street level
- **Description:** The riverside working district dye built and then poisoned: brick terraces shoulder to shoulder, ginnels and walled yards, laundry lines strung under dripping eaves, sandbagged doorways, high-water stains at knee height on every façade, St. Brigid's spire as the constant landmark. The shuttered Halcyon Dye Works broods at the district's downhill end. Chronic flooding, chronic sickness, and a folklore nobody upstairs listens to — Adam's childhood ground, and the place whose sick kids (C-01) the entire conspiracy is priced against. On screen it must read poor but *not* pitiable: dense with maintenance, improvisation, and neighbors.
- **Atmosphere:** Brick reds gone brown with damp; puddle-mirror language everywhere (Lowmarsh is where the game teaches the player to read reflections); sodium lamps against blue dusk. Sound: rain in every register across its three uses — steady and domestic (A0-S02), swelling storm with drones and dogs (A1-S08), Vesper apocalyptic with the streets themselves becoming drains (A4-S07). Purple: absent at street level until A4-S07, when the floodwater sheets *violet downhill* — the district's folklore paying off through its own gutters.
- **Layout notes for level design:**
  - Fabric set with three tunings, one geometry: a downhill street lattice (the grade matters — everything in Lowmarsh drains toward the river and, in A4-S07, toward Ascension Plaza), yard-and-ginnel interiors behind the terrace faces, a flood-channel cut with footbridges.
  - **A1-S08 chase tuning:** the waking-district evasion gauntlet — route: rowhouse alley → yard vaults (fence mantles) → ginnel junctions (route choice under drone light-cones) → flood channel (water slows sprint — first hostile-water mechanic) → Marsh Gate approach. Affordances: under-stoop hides, laundry-line visual breaks, wall vaults, one scripted near-catch at a dead-end that a neighbor's opened gate resolves (Lowmarsh protects its own — theme as level design).
  - **A0-S02 tuning:** ambient walk-through segment shared with LOC-meridian-streets fabric.
  - **A4-S07 tuning (sec):** broadcast-cutaway dressing — streets running purple, residents at windows filming; needs hero shots down the grade toward the plaza; playability not required (cutscene coverage), but build the drainage logic visibly: gutters → channel → plaza gutter mouths, so the finale's hydraulics read as *real plumbing*, not magic.
  - Puzzle props: none at street level; Lowmarsh's evidence lives in its people and its stains (environmental storytelling: tide-lines, parish notices, decades of patched brick).
- **Used in scenes:** A1-S08; *(sec)* A0-S02, A4-S07 (streets running purple).
- **State changes:**
  - **A0-S02:** morning, wistful, ordinary.
  - **A1-S08:** pre-dawn hunt — spotlights, rotor wash, rising water; the district as gauntlet.
  - **A4-S07:** Vesper peak — the purple flood; the folklore, the graffiti, and the title paid off in the district that kept the record when no institution would.

<a id="loc-lowmarsh-restaurant"></a>
### LOC-lowmarsh-restaurant — The anniversary restaurant

- **ID / Name:** LOC-lowmarsh-restaurant — The anniversary restaurant
- **Description:** A small family-run Lowmarsh restaurant directly across the street from St. Brigid's — the church where Adam and Mara married ten years ago, which is why this is *their* table. One warm room: candles in jars, steamed glass, a proprietor who knows their order. Through the window, across the rain, the church's violet-tinted glass is visible and unread (C-33). Outside, under an awning, a stranger photographs them and does not lower the phone (C-08). The whole set is one composition: the marriage in the foreground, the truth glowing unnoticed behind it, the surveillance in the margin.
- **Atmosphere:** The warmest interior in Act 0 — candlelight amber, food steam, laughter acoustics; rain thickening outside on glass. Palette discipline: interior entirely warm; the *only* cool note is the violet glow of the window across the street, softened by rain — purple as consecrated background radiation, deliberately composed just off the conversation's eyeline. Sound: room murmur, cutlery, rain building from steady toward hard over the scene's length (the storm that will break as Purple Dawn is already assembling).
- **Layout notes for level design:**
  - Cutscene-first set; minimal but exact. One room (six tables, counter, kitchen pass), a street exterior slice with the awning opposite, and the St. Brigid's façade backdrop with the lit window (share the actual LOC-st-brigids façade asset for continuity — the player will stand *inside* that window's light in A3-S06).
  - The load-bearing sightline triangle: **their table ↔ the window glass across the street ↔ the stranger under the awning.** Camera coverage must be able to hold all three in varying emphasis without cheating geometry.
  - Interaction: brief playable dialogue beats at the table (the toast: "Ten years. Nothing about us in the papers. May it stay boring."); an attentive player can *notice* the photographer (C-08 — no mechanic response; the game does not flag it; the journal accepts it if noticed).
  - Puzzle props: none. This set's job is to be worth grieving.
- **Used in scenes:** A0-S07 *(sec: LOC-st-brigids visible through the window)*.
- **State changes:** Single visit. (Optional epilogue nod is *not* canon — the registry does not return here; resist the temptation. The A4-S10 coffee is elsewhere and is a first date, not an anniversary.)

<a id="loc-st-brigids"></a>
### LOC-st-brigids — St. Brigid's church & free clinic

- **ID / Name:** LOC-st-brigids — St. Brigid's church & free clinic
- **Description:** Lowmarsh's parish church and its attached free clinic — the district's one institution that belongs to it. The church: a soot-darkened Victorian nave, votive racks, and above the side altar where local weddings are held, **the violet window** — St. Brigid holding back a violet flood, installed in the 1975 "restoration," its donor panel a payment cipher in glass: a receipt for the Quiet Covenant hidden in the one building Lowmarsh would never tear down (C-24, C-33). The sacristy keeps framed wedding photos of parish couples — Adam and Mara among them, laughing, the flood rising in glass behind them the entire time. The clinic wing: triage desk, records room of handwritten ledgers, and the night ward with its cribs — Mara's kingdom, and the source of the cluster map (C-01).
- **Atmosphere:** Church: candle-and-brass in deep brown dark; at night the window comes alive when lightning or streetlamps pass through it, laying violet across the stone floor — the game's most sacred use of the color (purple as *witness*, not wound). Sound: rain on slate high above, candle hiss, the building's held breath. Clinic: low-wattage night-ward hush, monitor pips, crib rustle; whispering as the enforced dialogue register (A3-S15 is staged entirely between cribs). 
- **Layout notes for level design:**
  - Two wings, two entrances, two moods: **church porch** (public, front) and **clinic side door** (where a fugitive enters, A3-S15). Interior connection through the sacristy corridor.
  - Church set: nave with pews, side altar under the window, votive rack, the **donor panel** (1975 restoration plaque) at reading height beside the window, sacristy with the wedding-photo wall (the A3-S06 gut-punch — one examinable frame among dozens).
  - **Window cipher staging (A3-S06):** three-element puzzle station — donor panel names/amounts, lancet inscriptions, and the Verger's Concordance folio cross-reference; needs a night-lighting state where the window is legible in detail (scaffold lamp the Verger brings — diegetic light source). The decode should physically re-light the window as understanding lands (art-direction beat: the glass goes from *pretty* to *documentary*).
  - Clinic set: triage desk sightline down the ward, ledger room (C-01 cluster-map material — Mara's twenty years of triage ledgers as an examinable archive), the night ward with cribs arranged so a whispered walking two-hander can be blocked between them without waking anyone (canon staging).
  - Stealth affordance (A3-S15): Adam's face is bounty-known by now — entry via side door at shift-change, one nurse to avoid (unregistered NPC), tension tuned social, not mechanical.
- **Used in scenes:** A3-S06, A3-S15 (clinic night ward); *(sec)* A0-S07 (exterior/window visible from the restaurant).
- **State changes:**
  - **A0-S07:** exterior only — the window glowing across the rain, unread.
  - **A3-S06 (Week 19, night):** empty nave, the Verger's keys and lamp; the window decoded — after this scene the window's lighting state is permanently *knowing* (subtle grade shift on revisit/flashback).
  - **A3-S15 (Week 28, night ward):** the clinic in use; security consciousness raised (his face on the news for two acts); Mara's terrain, her rules.

<a id="loc-betting-cafe"></a>
### LOC-betting-cafe — The betting café

- **ID / Name:** LOC-betting-cafe — The betting café
- **Description:** A Lowmarsh gambling café: OTB screens over a formica counter, tote slips drifted like leaves, vinyl booths mended with tape, a bathroom in the back where the taps run to cover crying. Theo's habitat and hiding place — the room where he holds court too brightly, presses cash on his brother "for the lawyers," and lies badly (A1-S06). The set's function is dramatic irony: the player can find what Adam cannot let himself see.
- **Atmosphere:** Fluorescent-and-screen-glow; the screens supply the room's only saturation (racing greens, odds-board amber). Stale coffee, wet coats, extractor-fan drone. Rain streaks the front glass; sodium outside. No purple — Theo's world is sodium and fluorescence, the palette of small debts. Sound design carries the scene's grief: the bathroom taps running behind the dialogue's final beats.
- **Layout notes for level design:**
  - Small single-interior set: entry from street, counter + screens, Theo's booth (blocking anchor), bathroom corridor (door ajar — audio staging for the taps), rear exit to a yard (established here because Theo always knows the back way out; pays forward to his A2-S13 panic literacy).
  - Player-findable evidence (the scene's core loop, examine-based): **fresh betting slips, paid off** (examine: stamped settled — who pays off a loser's slips?); **a burner phone with one saved number** (examine: no name; calling it is not offered — the game withholds the verb, as Adam withholds the thought). Both feed the journal as unresolved entries; payoff at A2-S13 / A4-S09.
  - Dialogue staging: booth two-hander with interruptions (regulars, a race call) tuned to let Theo perform; the performance *is* the clue (behavioral fair-play per MYSTERY_LOGIC).
  - No stealth, no puzzle mechanics. Camera note: hold Theo in medium-close through his over-laughs; the lie must be visible to the player over Adam's shoulder.
- **Used in scenes:** A1-S06.
- **State changes:** Single visit. (NG+ note: every line and both props re-read completely on second playthrough — flag this set for NG+ QA pass.)

---

# REGION 2 — INSTITUTIONAL MERIDIAN: THE MACHINE'S PUBLIC FACE

*The venues the conspiracy owns or feeds: law, records, logistics, prosecution. Design brief: these spaces are never gothic — their horror is administrative (STORY.md §7). Fluorescent light, procedural sound, and the total exclusion of rain. The frame lives here, and it is beige.*

<a id="loc-courthouse"></a>
### LOC-courthouse — Justice center (courthouse, remand & proffer rooms)

- **ID / Name:** LOC-courthouse — Justice center (courthouse, remand & proffer rooms)
- **Description:** Meridian's legal machine on one civic block: a WPA-era granite courthouse fused to a modern remand annex. Booking counters, a fingerprint-and-flash intake loop, a dayroom with a bolted TV, the proffer room where the plea is slid across the table, the fraud task force's borrowed offices, and — the set's true star — **the steps**: the media scrum arena where bail, vertigo, and (three hundred days later) vindication are all staged. This is where the system demonstrates that it is not malfunctioning; it is functioning, for someone else.
- **Atmosphere:** Bone-white fluorescence, marble echo, brass rails, flag colors; the driest place in the game — rain is *visible* through high windows and never audible (the institution excludes weather and, with it, truth's element). Palette: no purple, ever, per doctrine — the frame's venue is colorless. Sound: buzzing locks, intercom consonants, chair scrape; on the steps, shutter-clatter and shouted questions mixed like weather. The intake flash rhymes deliberately with the raid's flashbulbs (violet-white strobe — the one spectral echo allowed).
- **Layout notes for level design:**
  - Five sub-sets: (1) **intake/booking** — counter, print station, flash station (A1-S01; the charge-sheet examine is the document-reading tutorial: 46 counts scrollable, Count 31 findable, C-11); (2) **remand dayroom** — bolted furniture, the TV mount (Hale's "author" presser; later Skerry's surfacing plays on the same screen in A1-S07's world — reuse the screen language); (3) **proffer room** — table, two chairs and a better chair, mirror glass, the plea document as a hero interactive prop (A1-S02: the allocution's date range must be player-readable); (4) **task-force offices** — bullpen + Hale's glassed office for the A3-S02 interleaved cutscene (Whitlock's desk dressed with the H.G. print and the Fidelis thread; Hale's written refusal printed and *filed* — the obstruction going on the record as set dressing); (5) **the steps** — wide stair to street, mic-stand chokepoint, van line at the curb.
  - **A1-S03 first-person scrum:** the steps played as an evasion-of-attention set — microphones as weapons, flash blindness, a car door as objective; Whitlock's watching car positioned for a held glance.
  - **A4-S09 re-use:** the same steps in light rain for the exoneration presser — staged and shot to rhyme exactly with A1-S03, *minus Adam* (he is at LOC-cemetery; the location performs without him — the design's point).
  - Stealth/action: none; this is procedure-as-gameplay. The player is moved through it, which is the experience.
- **Used in scenes:** A1-S01, A1-S02 (proffer room), A1-S03 (steps), A3-S02 (task-force offices), A4-S09 (fallout stage).
- **State changes:**
  - **Act I (Days 1–6):** the machine at full confidence — Adam processed as object.
  - **A3-S02 (Week ~15):** back-corridor register; the same institution now contains a quiet parallel investigation (Whitlock's desk is the one warm-lit workstation in the bullpen).
  - **A4-S09 (Days V+1…V+10):** light rain finally audible on the steps; injunction-era clutter (courier boxes, federal seals); the venue's confidence inverted — same marble, opposite valence.

<a id="loc-archive-annex"></a>
### LOC-archive-annex — County Archive Annex

- **ID / Name:** LOC-archive-annex — County Archive Annex
- **Description:** A county records warehouse on a canal spur: high steel shelving in numbered bays, rolling ladders, caged evidence bays (Bay 9 holds the original TS-19/44, raw data, and custody fiche), a sodium-lit loading dock over black water. The stage of the midpoint heist (A2-S07) — and, invisibly, the conspiracy's most elegant move: the entire infiltration is choreography staged *for* Adam (C-17), a fact the player learns only at A4-S02 when their proudest win is re-graded before their eyes. Every oddity must therefore be built twice-readable: luck to a trusting player, staging to a careful one.
- **Atmosphere:** Sodium and shadow; dust in torch beams; the smell of old paper implied by sound (dry rustle, ladder rumble) against the wet slap of canal water at the dock. Rain on the high roof, distant. Palette: amber/black with the canal's oil-sheen — *no violet*; the purple motif stays out of the conspiracy's own stagecraft. Music note (canon): the escape scores as triumph — "the music says so; the music is lying."
- **Layout notes for level design:**
  - Ingress (per canon: planned with Nine's floor plans, Kray's exfil): water-level service door off the canal → sub-floor records corridor → main floor. Egress: Bay 9 → loading dock → boat (scripted chase on the canal, survivable by design — the alarm trips on *exit only*, C-17).
  - Main floor: bay grid with shelf-top traverse (rolling-ladder verticality; guards patrol the aisles, player owns the tops), a guard office with the **roster board** (readable: skeleton crew on a purge week — C-17 oddity #1), purge-schedule paperwork (oddity context).
  - **Bay 9 cage:** the box **pre-staged near the loading dock**, not in its bay (oddity #2 — a careful player who checks Bay 9's actual shelf finds the gap and a fresh drag-scuff); the **evidence seal already broken** (oddity #3 — examine prompt with a deliberately unremarked prompt string; the game must not editorialize).
  - **Alarm panel** near the dock: visibly exit-armed only (oddity #4, legible to players who read security panels — teach that literacy in LOC-depot first).
  - Stealth systems: light/shadow lanes between shelving, sound surfaces (grate vs concrete), two guards + one dock watchman (skeleton roster as *mechanical* fact — the level is genuinely easy, which is the trap).
  - The boat chase: canal course with low bridges (duck timing), one spotlight boat, scripted survivable — tune tension high, lethality low; it was designed (in-fiction) to be escaped.
  - **A4-S02 re-grade support:** every C-17 oddity needs a flashback-still capture (the choreography memo's exhibits) — build the four oddities as camera-ready vignettes from fixed angles for the stitch montage.
- **Used in scenes:** A2-S07 *(sec: LOC-undercroft exfil)*.
- **State changes:** Single playable visit. Re-experienced twice at a distance: A2-S09 (news framing: "fugitive raids public archive" — exterior stock shot dressing) and A4-S02 (the choreography memo re-grades the whole level; flashback stills). No physical revisit.

<a id="loc-depot"></a>
### LOC-depot — Medical distribution depot

- **ID / Name:** LOC-depot — Medical distribution depot
- **Description:** A surface pharmaceutical distribution depot: chain-link perimeter, floodlit yard of trailers, dock doors, racking aisles, a chilled room where the insulin lives, and a dispatch office with a coffee ring on every surface. Security by **Aegis Meridian** — the player's first sight of the logo that will hunt them for the whole game, guarding, of all things, medicine from the people who need it. The Lantern's pharmacy run (A2-S02): Adam's first crime, committed for other people's insulin, and the worst part is how good he is at it.
- **Atmosphere:** Floodlight white over wet asphalt in the yard; sodium at the fence line; interior warehouse dark cut by skylight grey. Night rain, steady — hostile register debut, but tuned survivable: this is hell's *warm* crime. Palette: Aegis slate-and-white livery introduced clinically (brand as antagonist); cold-room blue for the insulin cage. No purple. Sound: compressor hum (masks footsteps — teach sound-masking here), fence rattle, one radio playing in dispatch.
- **Layout notes for level design:**
  - Stealth-infiltration tutorial: one full patrol loop (two guards, offset timing), light/shadow lanes across the yard, crouch-surface variety (gravel alarm strips vs concrete), a climbable trailer line (verticality intro), and the **lockpick tutorial** on the pharmacy cage door.
  - Objective chain: fence gap (scripted entry) → yard crossing → dock man-door → racking aisles → cold room (crate objective) → exit carrying weight (slow-walk mechanic under one patrol pass — the crime made physical).
  - **Security-panel literacy:** place a readable alarm panel by the dock man-door (armed zones legible) — this teaches the skill the archive annex's exit-only panel (C-17) assumes at A2-S07. Deliberate curriculum link; do not cut.
  - Optional intel: dispatch office desk carries Pier District redevelopment freight paperwork (RH-02 texture per MYSTERY_LOGIC — part of the A2-S02 haul that seeds the wrong-building misdirection).
  - Fail-states tuned forgiving (detection → chase-out, not reload) — the tutorial teaches consequence, not punishment.
- **Used in scenes:** A2-S02.
- **State changes:** Single visit. (Epilogue montage may show an Aegis-contract-cancelled sign on the fence in A4-S10 stock footage — optional dressing, non-registry, cut freely.)

<a id="loc-ag-office"></a>
### LOC-ag-office — State Attorney General's office

- **ID / Name:** LOC-ag-office — State Attorney General's office
- **Description:** A capitol-side prosecutorial office in another register of power entirely: long marble corridor, frosted-glass doors with gilt lettering, a conference room with a table too large for the meeting that matters. This is where Whitlock's file — the H.G. anachronism, the Fidelis-to-Aegis thread, Hale's on-record obstruction — finally lands (A4-S01 prep suite), producing not an arrest but the needed inch: Dr. Amara Chen's mandate to conduct the ceremony's first-draw sampling with sealed duplicates.
- **Atmosphere:** Institutional like the courthouse but *older money*: warmer marble, brass fittings, portrait oils. Quiet as leverage — the loudest sound is a file box set down on a table. Light rain on tall windows, audible here (unlike the courthouse): this institution is outside the Vestry's acoustic seal, which is the point of coming to it. No purple.
- **Layout notes for level design:**
  - Cutscene-adjacent micro-set (one prep-suite beat, Whitlock's thread): corridor (walk-and-talk lane), anteroom (a gatekeeper desk — the wait is part of the scene), conference room (table, the file box as hero prop, a state seal on the wall for the establishing frame).
  - Interactive requirement: minimal — the beat is witnessed from Adam's remote perspective per the prep-suite's interleaved structure; build for camera, not traversal.
  - Reuse potential: corridor asset can dress A4-S09's "State AG and federal validators descend" montage shots.
- **Used in scenes:** *(sec)* A4-S01.
- **State changes:** Single beat; none.

---

# REGION 3 — THE BELOW: THE UNDERCROFT

*Hell, and the one place the conspiracy is blind. The drowned under-city: storm drains, dye-works tunnels, sunken streets, and the machine that hides the crime. Design brief: chthonic but never haunted — the Below is* populated. *Its darkness holds the warmest light in the game (the Lantern) and its deepest chamber holds the running lie (the Nightingale). Water level is a systemic mechanic across the whole region; violet is only ever the wound.*

<a id="loc-undercroft"></a>
### LOC-undercroft — The Undercroft (tunnels & drowned waterways)

- **ID / Name:** LOC-undercroft — The Undercroft (tunnels & drowned waterways)
- **Description:** The flooded under-city at large: nineteenth-century brick storm drains in barrel vaults, glazed-tile dye-works tunnels with violet stains at their old waterlines, sunken streets where façades descend into black water and cellar windows glow beneath the surface, chapel crypts and cellars abandoned when the lower pumps were shut off in 1968. Kray's boat routes stitch it together; her magnificent map has one blank quarter — *"No one ferries to the Vats. Toll's too high."* Off the map, off the grid, home to the people the city threw away — and structurally, the conspiracy's blind spot: everything Adam finds down here is invisible to the Vestry, because the discarded people are the one ledger it never kept.
- **Atmosphere:** Absolute dark held back by lantern amber and torch beams; water in every sound layer — drips, wakes, weir-rush, and beneath it all a subliminal bass throb the player will only later identify as the Nightingale running (plant this in the mix from A1-S09 onward; its payoff at A2-S11 is acoustic recognition). Cold-breath VFX in the deep sections. Palette: brick brown-black, lamplight amber, bioslick greens — and violet exactly where the wound weeps: leachate seams, stained tide-lines, the A2-S03 wall. Rain does not exist down here; it arrives as *level change* — the Below experiences weather as rising water, which is the region's whole mechanical identity.
- **Layout notes for level design:**
  - **Network structure, hub-and-spoke:** the Lantern (own entry below) as hub; spokes unlocked by Kray-passage per the game's district structure. Traversal modes: on foot (walkways, weirs, ledges), by boat (Kray-ferried early, self-poled later), and wading/swimming (stamina- and cold-limited).
  - **Water level as gate and clock:** authored levels per act (see State changes) plus scene-local dynamics (A2-S13 floodgate chaos; A4-S05 Vesper surge closing routes in real time). Build every junction with a visible high-water datum line so the player can read danger the way Adam does.
  - **Named sub-sites the blockout must serve:**
    - **The water-feed junction** (A2-S03): gravity-fed supply gallery with the game's first full-depth hydraulics puzzle (valve network, contamination isolation) routed deliberately past the **leachate wall** — violet sheeting live down Works-era brick (R0 begins; C-02 payoff #1). Stage the wall like an altar: the puzzle's final valve turn re-lights the chamber and reveals it. Sample-taking interaction (notebook #42 logging).
    - **Kray's waters / mooring** (A2-S04): a broad drowned crossroads with her barge, hanging lamps, the map table (examinable — the blank quarter is a readable prop), toll box. Negotiation staging afloat.
    - **Drop sites** (A2-S09 *(sec)*): a supply cache vault hit by the Aegis snatch squad — post-raid dressing (scorch, dropped crates, a Lantern token in the mud) seen after the fact.
    - **The meet site** (A2-S13): a half-drowned loading vault with an operable floodgate — the wire-trap arena. Requirements: multiple Aegis ingress points in the walls (gantries, pipe galleries), an inviolable no-harm-Theo design envelope (no friendly-fire verbs exist in the scene), a floodgate release as the scripted chaos-escape (water as ally for once), and an underwater egress carrying Theo (assisted-swim mechanic).
    - **The barge-burn viewpoint** (A3-S11 *(sec)*): a vantage across open water to watch Aegis torch the decoy barge at dawn — pure staging: the fire's reflection must reach the player's boat.
    - **The Vats route** (A4-S01, A4-S05 *(sec)*): the blank quarter finally run — a route of drowned works-yards and settling channels toward LOC-nightingale-hall; in A4-S05 it is the descent corridor, "water already violet at the seams" (seam-glow dressing on every junction).
    - **Meet-site variants** (A3-S12 *(sec)*): the canary trap uses three meets across three channels; two are Undercroft sub-sites (re-dress existing vaults), the third is an unnamed surface church (see registry note — no LOC ID exists; keep it a cutscene exterior).
  - **Stealth/action affordances:** darkness as systemic cover; boats as moving hides; water masks sound but chills a timer; bounty-era (post–A2-S12) adds hostile scavenger patrols and watcher posts at major junctions — the Below itself turns ambivalent, which the level population must express.
  - **Puzzle props:** valve networks and sluice controls recur as the region's grammar (established A2-S03, echoed at gates and weirs, culminating at LOC-nightingale-hall). Hymn-board/cipher props belong to Region 4, not here — keep the two puzzle families spatially distinct per canon.
- **Used in scenes:** A2-S03, A2-S04, A2-S12, A2-S13; *(sec)* A1-S08, A1-S09, A2-S07 (exfil), A2-S09 (drop site), A3-S11 (barge burn), A4-S01 (Vats route), A4-S05 (staging).
- **State changes:**
  - **A1-S08/S09:** first contact — near-drowning blackout, then ferried refuge; the Below as terror, then as strange grace.
  - **Act II (Weeks 3–11):** home and workplace; routes learned, economy joined; water at seasonal normal.
  - **Post–A2-S12 (bounty era):** even Undercroft eyes change — watcher posts, colder receptions, the safe network shrinking to Lantern-vouched routes.
  - **Post–A3-S11:** allied network — Kray's flag protects, Nine's channels feed false coordinates upward; one clean week of silence in the soundscape (mix note: drop the threat layers entirely; the quiet should feel *loud*).
  - **A4-S01→S05 (Vesper):** the surge — levels rising scene over scene, familiar routes closing, violet seam-glow spreading; the Below finally in open revolt alongside its people.

<a id="loc-lantern"></a>
### LOC-lantern — The Lantern

- **ID / Name:** LOC-lantern — The Lantern
- **Description:** The Verger's shelter and the game's hub from Act II: a dry raised vault at the meeting of three tunnels, reached by causeway plank or by water, behind a door with a riddle-hatch — the Verger's filter for cops and fools. Inside: heat, soup, long tables, lamplight, and the three rules chalked where the door-light lands: *"No paper. No questions. No one knows where anyone sleeps."* Off the main hall: the war-room alcove where the evidence board is born (A2-S08) and grows for three acts, and the Verger's nook of ledgers and hymnals above the forty-year hide of the Concordance. Hell's hearth — the warmest room in the game, at the bottom of the world.
- **Atmosphere:** Lantern amber and stove glow; steam off soup; wet wool and candle smoke. The acoustics of shelter: the Undercroft's drips and the surface's storm arrive muffled, translated into safety (rain never falls here, but its distant register tells the player what the world above is doing — mix storm state to match the calendar). Palette: warm browns and brass, chalk white; **no violet inside, ever** — the Lantern is sanctuary, and the wound stops at its threshold (art-direction rule; the one exception is evidence *photographs* of violet on the board, which is purple domesticated into information).
- **Layout notes for level design:**
  - **Approach:** water landing + causeway plank to the **riddle door** (A1-S09: first diegetic riddle, simple, teachable; the hatch conversation is a reusable interaction for every re-entry — later visits auto-resolve with a knock pattern, texture of belonging).
  - **Main hall:** long tables, stove, soup pot (recurring interaction — ladling soup is the hub's heartbeat verb), the rules chalked on brick, the favor board (quest-giver surface for the Undercroft economy: "everything below costs a favor; every favor is a mission").
  - **War-room alcove:** the **evidence board** — the game's diegetic quest log and its single most important interactive surface. Debuts A2-S08 (original TS-19/44 vs doctored copy vs notebook #29 vs tunnel sample); grows by act (cork, string, stolen fiche at A3-S01; the C-25 memo sits on it *provenance-less* from late Act II — flag its card visually distinct-if-scrutinized, per fair-play rules; corpus-analysis layout for A3-S12's canary trap; full lattice by A4). Build as a versioned set-piece with per-act dressing states; every reveal scene lights it differently.
  - **The Verger's nook:** ledger shelf, hymnal stack, his cot nobody has ever seen him use (rule 3), and the flagstone hide where the **coffin-shaped waterproof case** surfaces at A4-S01.
  - **Half-seen wall detail (A2-S01):** the Vestry brand-scar symbol, half-hidden among older markings (RH-04 plant) — position at eye height in peripheral shadow near the Verger's nook; must be findable, never highlighted.
  - **Sleeping:** deliberately unmapped — alcoves and curtains, and the player's own cot *changes location between acts* (level-design expression of rule 3; also quietly explains why the A2-S09 leak never burned the Lantern itself).
  - **Exits:** three minimum (shelter doctrine): the riddle door, a water-gate under the floor, and a crawl-bolt into the tunnel maze. The A2-S09 aftermath adds visible new procedure (a watch bell, a second plank pulled at night).
- **Used in scenes:** A1-S09, A2-S01, A2-S06, A2-S08, A2-S09, A2-S14, A3-S01, A3-S04, A3-S12, A3-S14, A3-S16, A4-S01, A4-S03, A4-S04; *(sec)* A4-S10.
- **State changes:**
  - **A1-S09:** first entry — riddle door, soup, the rules; Adam writes his name in #42 just to see it.
  - **A2 (orientation era):** favor board active; Nine's corner table; wary warmth.
  - **A2-S08 onward:** evidence board alive and growing — the hub visibly becomes an investigation.
  - **Post–A2-S09:** raided-adjacent wariness — drop procedures changed, the watch bell, fewer faces.
  - **Act III:** war room proper — map overlays, role assignments (A3-S01), the board's despair state after A3-S07 (ash of the paper strategy) and its cold clarity at A3-S12.
  - **A4-S01→S04:** prep workshop and, at the eve (A4-S04), the game's warmest lighting state: soup, lamplight maxed, benediction — held breath before Vesper.
  - **A4-S10 *(sec)*:** the legal Lantern — licensed, daylight let down a new grate, same three rules chalked fresh; the Verger keeping the door.

<a id="loc-forge-shop"></a>
### LOC-forge-shop — Nine's forge-shop

- **ID / Name:** LOC-forge-shop — Nine's forge-shop
- **Description:** Nine's document workshop in a dry cellar run: a counterfeit of a shopfront (counter, bell, banter) concealing the real back room — presses, a guillotine, ink stones, seal dies, a UV lamp, drying lines pegged with half-born "papers," and the best coffee below. The best document man in the Undercroft works here, charming and genuinely fond of Adam — and every brokered job is reported upward to Marr, who holds Nine's imprisoned sister over him. The shop is the stage of his unmasking (A3-S11), played sorrowful, not shouting, and later of his redemption shift: the finale's credentials forged for the good guys (A4-S01).
- **Atmosphere:** Warm task-lighting islands (lamp, UV violet-white over the light table, press lamp) in cellar dark; solvent and coffee smell implied through prop density. Sound: press thump, paper whisper, the bell on the counterfeit shopfront door. Palette: ink blacks, paper creams, brass dies; the UV lamp is the room's only violet-adjacent source — a tool for *detecting* forgery, in the forger's own shop (irony as set dressing).
- **Layout notes for level design:**
  - Two-room set plus approach: shopfront (counter, bell, small talk staging), back room (the real work: light table center, presses along one wall, drying lines overhead, seal-die cabinet), and **two exits** (a forger always has two — the second is a crawl to the tunnel run; established visually in A3-S11, used narratively for the A4-S03 extraction logistics off-screen).
  - **A3-S11 staging:** Adam lays the correlation out *like a proof* on Nine's own light table — the confrontation is document-shaped: the player places evidence cards (C-15, C-20, C-21 pattern data, Krebs's geotagged notes) onto the lit surface one at a time; Nine folds when the last card lands. The sister's photograph must be present as pre-existing set dressing (a small frame by the press, visible on any earlier visit if the player looks), so the reveal's mechanism re-reads as always-visible.
  - **A4-S01 re-dress:** allied workshop at full burn — every lamp lit, drying lines full of ceremony credentials, Kray's rag-trade suit hanging in the corner rhyme; the counter bell taped silent (small joke, big tell: no more customers, one client).
  - Stealth/action: none; this is a dialogue-and-evidence set. Keep traversal footprint tight for camera intimacy.
- **Used in scenes:** A3-S11; *(sec)* A4-S01.
- **State changes:**
  - **A3-S11:** the unmasking — dressed as any working night until the light table fills with proof; end-state: Nine flipped, the first counterfeed already outbound.
  - **A4-S01 *(sec)*:** the redemption shift — same room, maximum warmth and industry; the sister's photo now facing outward.

<a id="loc-nightingale-hall"></a>
### LOC-nightingale-hall — The Nightingale pump hall & the Vats

- **ID / Name:** LOC-nightingale-hall — The Nightingale pump hall & the Vats
- **Description:** The buried cathedral of the lie: a cathedral-sized Victorian interception-pump hall at the edge of the Halcyon waste basins — cast-iron columns, brick vaults, great pump sets on greased rails, gantry cranes, valve galleries stacked three levels high, a sump crawling with violet slick, and a clipboard hanging at the duty station. **Running.** Maintained since 1974 as the Nightingale service: the machine that catches seventy years of leachate before it daylights, the physical fact of the Quiet Covenant — not a cover-up but an operating utility with a maintenance schedule (contractor of record: Larkspur Facility Services, C-19; budget line: $3.1M/yr of "fountain & waterscape maintenance," C-34). Outside its walls, the Vats: unlined waste basins, berm moonscape, warning signage decades out of date. It is the game's R0 revelation (A2-S11), its finale lever (A4-S06), and its epilogue's remediation site.
- **Atmosphere:** The most important *sound* in the game: the machine — rhythmic, enormous, patient; a bass throb seeded into the Undercroft mix acts earlier, resolved here into its source (the A2-S11 approach should be scored by the sound alone getting louder; no music until the doors). Work-lights strung along Victorian iron: bare-bulb amber against rust, brass, black water; the sump's violet slick is the room's one saturated element — purple as industrial secretion. A4-S06: storm register — the hall *screaming* at load, steam, spray, emergency lighting mixing red into everything, floodwater climbing the column bases. Rain never reaches here; Vesper arrives as pressure.
- **Layout notes for level design:**
  - **Three-level vertical set:** sump floor (water, slick, the great pump bays), main floor (duty station, clipboard, maintenance log — the A2-S11 lift objective; rails and crane bases as cover), and two stacked **valve galleries** ringing the hall (the finale puzzle's playfield), linked by cage stairs, ladders, and one gantry crane traverse. Verticality is the set's identity: sump to gantry should feel like a cathedral's crypt-to-triforium climb.
  - **A2-S11 tuning (recon-stealth):** night crew of three on realistic maintenance rounds (not guards — their inattention is verisimilitude, their radios the threat); objectives: photograph (framed shots: machinery, greased rails, violet sump, fresh bootprints, the clipboard) and lift the maintenance log (C-19). The scripted near-catch: the player hides *inside a de-clutched pump casing* while the crew works the housing — hiding inside the machine that hides the crime (canon beat; build the casing as an enterable hide with a heartbeat-audio interior).
  - **A4-S06 tuning (setpiece + R5 payoff):** the final full-grammar hydraulics puzzle — a valve-network re-route across both galleries under time and rising floodwater: the player does not destroy anything (design thesis: an engineer's masterstroke, not a saboteur's) — they open doors: sequence sends intercepted leachate to the storm drains, the plaza fountain loop, and the ceremonial first-draw main (three routing objectives, each with a legible destination readout; failure states are setbacks, not deaths). Floodwater rises between puzzle stages, closing lower routes and forcing the climb. Then the standoff: Marr and the Aegis crew enter at the main doors — staging on the main floor, player on the mid gallery; canonically **no combat**: Marr reads the file, voids the contract, walks (branch: refuse the standoff → the game's hardest fight, using the hall's flood mechanics; converges).
  - **Exterior (the Vats):** approach across berms and settling channels from the Undercroft route; the last quarter-mile is *waded* (Kray still won't ferry it in Act II — her boats appear here only in A4). Sightline requirement: from the berm crest, the hall's roof monitors glowing below grade — the buried cathedral discovered from above.
  - **Puzzle props:** the valve galleries' wheels, sluice indicators, and destination gauges must share visual grammar with A2-S03's junction puzzle (curriculum continuity); the duty-station clipboard and log are examine props with C-19's contractor name legible.
- **Used in scenes:** A2-S11, A4-S06; *(sec)* A4-S05 (descent), A4-S10 (remediation, exterior).
- **State changes:**
  - **A2-S11 (Week 11, night):** running-hidden — immaculate maintenance, low amber, the horror of good housekeeping.
  - **A4-S05 *(sec)*:** the descent approach at Vesper's onset — water violet at the seams, the machine's rhythm already labored.
  - **A4-S06 (Day V, storm load):** screaming machinery, red emergency light, rising flood; end-state: re-routed, the lie daylighted, the hall spent and quiet.
  - **A4-S10 *(sec)*:** months later, exterior — remediation cranes over the Vats, containment rigs, the consent decree made visible; the machine stopped, honestly, at last.

<a id="loc-seal-chamber"></a>
### LOC-seal-chamber — The 1988 seal chamber

- **ID / Name:** LOC-seal-chamber — The 1988 seal chamber
- **Description:** The old outfall seal chamber where it all began: a small brick rotunda at the foot of a disused outfall run, its cornerstone carrying the 1988 closure seal — the place whose paperwork Raymond Cordell signed falsely as a young man (the First Lie), now drowning in rising violet water on the night the lie dies. Final confrontation set (A4-S08): no boss bar — an old man, a chessboard set on a survey crate, and the game's whole argument in dialogue while the flood climbs the walls. The player valve (drown / abandon / save) resolves canonically with Adam hauling his mentor up through the rising violet dark: *"You are what you sign. Sign this."*
- **Atmosphere:** One lantern on the crate; black water rising with a violet cast (the leachate is in everything tonight); the storm above arriving only as deep percussion through masonry. Sound: water gaining on the dialogue — the mix's water layer rises in scripted steps tied to conversation beats, so the scene's clock is audible, never HUD-shown. Palette: black, brick, violet, one warm point of lantern light between the two men.
- **Layout notes for level design:**
  - **Single chamber + two verticals:** the rotunda floor (crate, chessboard, cornerstone), the approach passage (waded in, sealed behind by surge — no retreat), and the exit shaft: a ladder-and-hoist climb to the waterline landing above, where **Whitlock waits** (the delivery point; her presence staged as silhouette and torchlight from above).
  - **The cornerstone:** examine prop — the 1988 date and closure seal; the scene's thesis object. Position so the rising water visibly gains on it during the dialogue (the flood erasing the inscription as Cordell defends it — art direction's closing argument).
  - **Valve staging:** all three choices play from identical blocking at the crate (per the game's valve-design rule): *save* = assisted-climb mechanic hauling Cordell up the shaft (weight, slips, effortful inputs — earning it physically); *abandon* = the climb alone, with the lantern left below; *drown* = remain until a scripted cut. Converges at the waterline landing.
  - **The chessboard:** set on the survey crate mid-game (Cordell has been sitting with it); one optional interaction — touching a piece — with no mechanical consequence: the game offers the old ritual one last time and lets the player decline it.
  - No combat verbs load in this space at all (harder guarantee than "no boss bar" — remove the affordances, not just the encounter).
- **Used in scenes:** A4-S08.
- **State changes:** Single visit — but the location is the story's oldest: it was "visited" by the plot thirty-eight years before the player arrives, and every prop (seal, cornerstone, the survey crate's vintage) must date-read 1988. The state change is the water: the chamber begins the scene damp and ends it drowned.

---

# REGION 4 — VESTRY & THE OLD CITY: CATHEDRAL HILL AND THE CONSECRATED LEDGER

*The Vestry writes everything down — in cipher, in glass, in stone: the city is the ledger (STORY.md §3.3). This region's spaces are the ledger's pages: the club, the drowned mother-chapel, the crypt, the dying patriarch's house. Design brief: liturgical residue, never fantasy — candle-and-brass menace, granite silence, and puzzles that are the Vestry's own century-old filing system.*

<a id="loc-vestry-row"></a>
### LOC-vestry-row — Vestry Row (the Vestry clubhouse)

- **ID / Name:** LOC-vestry-row — Vestry Row (the Vestry clubhouse)
- **Description:** The unlisted civic club on Cathedral Hill: a granite terrace with no signage, one door whose boot-scraper has been worn hollow by a century and a half of members, shutters that are never open and never dusty. Meridian's true government meets here — part board, part congregation, part conspiracy of continuity — and the game shows it almost entirely from outside: a granite silence glimpsed from the tram in Act 0, unreadable and unremarkable, exactly as designed. Its one interior appearance is the post-credit sting (A4-S11): the sealed correspondence room, decades of ciphered letter-books to eleven other cities, and one recent envelope, unsent, with an unfamiliar stamp.
- **Atmosphere:** Granite grey, oxblood door paint, brass gone dark with polish rather than neglect. The exterior's design language is *withholding* — no purple, no emblem, nothing to photograph. Interior (A4-S11): candle-and-brass residue under court-ordered work lights — evidence tags fluorescent against oxblood leather; the collision of the two lighting factions (liturgical vs institutional) is the sting's whole look. Sound: the Row's exterior is the quietest street audio in the game (even rain falls softer here — mix it 20% down; wrongness by subtraction). Interior: HVAC silence and one archivist's trolley wheel.
- **Layout notes for level design:**
  - **Exterior:** a street elevation for the A0-S02 tram glimpse (vista node — needs to read at distance and speed: the granite terrace, the one anomalous door) and for any Act III surface traversals that route past Cathedral Hill.
  - **Interior (A4-S11 only):** a single room — the correspondence room: letter-book shelves floor to ceiling, a long reading table, **eleven pigeonholes** (the other cities), court-seal tape across cabinets, evidence tags. Hero props: a ciphered letter-book open under a document camera; the **unsent envelope** with the unfamiliar stamp (final camera move of the game). Camera-only set; no traversal verbs required.
  - Do not build more of the club than this. The Vestry's interior spaces stay off-screen on principle — the organization the player never fully sees remains the organization the city never fully saw.
- **Used in scenes:** A4-S11; *(sec)* A0-S02 (glimpsed from the tram).
- **State changes:**
  - **A0-S02:** occupied, silent, sovereign — and completely illegible to a player who doesn't yet know what they're looking at.
  - **A4-S11:** sealed by court order — the ledger finally in evidence; the sting's envelope pointing at eleven rains elsewhere.

<a id="loc-st-albans"></a>
### LOC-st-albans — St. Alban's drowned chapel

- **ID / Name:** LOC-st-albans — St. Alban's drowned chapel
- **Description:** The Vestry's birthplace: the chapel in whose vestry room the mill-owners' guild first met in 1877 — flooded since the pumps stopped in 1968 and abandoned to the water, which is the only reason it survived unedited. A boat glides up the nave between pew-tops; the hymn board still holds the numbers of a service no one finished; dedication plaques line the walls like ledger entries (because they are); a stair descends underwater toward the crypt (LOC-vestry-crypt). Its steps to the surface break water at the chapel's edge — the flooded chapel steps where Adam and Mara speak on the eve of Vesper. The Verger's confessional cathedral (A2-S10) and the plan's final image (A3-S16: notebook #42, *Make the water testify*).
- **Atmosphere:** Storm grates far overhead throw slow, moving water-light down the nave — the game's most painterly lighting set. Candles the Verger lights one by one during his A2-S10 telling (scripted diegetic lighting: the history illuminates as it is spoken). Sound: water lap against stone, candle hiss, the huge soft acoustics of a drowned room; voices carry unnervingly far. Palette: submerged greens and stone grey, candle amber; violet only as the deep stain at the old waterline — the flood that killed the chapel was the same water that keeps the secret.
- **Layout notes for level design:**
  - **The nave (by boat):** pew-top channel, pulpit island, the **hymn board** (numbers frozen since 1968 — interactive cipher key), the **dedication-plaque wall** (cipher text surface). The A2-S10 puzzle: hymn-board numbers key the plaque cipher, yielding the 1974 covenant fragment and the word *Nightingale* (C-19 opens). Build the two surfaces with boat-positioning as part of the puzzle (reading angle matters; the boat is the cursor).
  - **The chancel:** raised and half-dry — the Verger's telling is staged here (candles, his brand-scar shown, RH-04 debunked); seating for a long scene: crate pews, his lamp.
  - **The crypt stair:** descending into black water; sealed/impassable until A4-S02 (visible earlier as negative space — let the player wonder for two acts what the Vestry's first hall holds).
  - **The chapel steps (exterior, surface edge):** where the drowned chapel meets the open air — flooded steps half in the tide. A4-S04's Adam-and-Mara scene plays here (two figures, lamplight, rising rain — keep blocking minimal and coverage close); A3-S16's act-turn image (Adam writing the plan's first line) uses the same steps at the chapel edge.
  - Traversal: boat-first; wading margins; no combat ever stages here (sanctuary rule shared with the Lantern).
- **Used in scenes:** A2-S10; *(sec)* A3-S16 (chapel edge), A4-S04 (flooded steps), A4-S10 (epilogue).
- **State changes:**
  - **A2-S10 (Week 10, night):** dark, confessional, candle-lit section by section as the Verger speaks.
  - **A3-S16 *(sec)*:** nine days out — storm building in the grates' light; the war council's edge; #42 open to a fresh page.
  - **A4-S04 *(sec)*:** eve of Vesper — rain beginning on the steps and not stopping for three scenes.
  - **A4-S10 *(sec)*:** epilogue — the crypt drained (see LOC-vestry-crypt), and the Verger seen once, sweeping, "like a man who might someday hold a service": light let into the nave for the first time in sixty years; grade the water-light warmer and higher.

<a id="loc-vestry-crypt"></a>
### LOC-vestry-crypt — The Vestry crypt (beneath St. Alban's)

- **ID / Name:** LOC-vestry-crypt — The Vestry crypt (beneath St. Alban's)
- **Description:** The club's first hall, below its birth-chapel, flooded since 1968: chest-deep black water over a floor of **ledger-stones** — flagstones carved with entries, the city-as-ledger doctrine literalized underfoot — chamber after chamber of cipher in stone, ending at a twin-lock strongroom holding the **Concordance** in its coffin-shaped waterproof case's original hide, and, appended in a younger hand, the routing copy of Cordell's 1988 certificate with the Quorum's annotation: *"The young man signed. He will be of use for thirty years."* The game's final riddle gauntlet (A4-S02) and the room where R4 lands. Silent but for water.
- **Atmosphere:** Torch- and lamp-light only; cold-breath VFX; water dead calm — every player movement wrecks perfect black mirrors (art direction: the crypt punishes haste visually). Palette: stone, bone-dry above the waterline where carvings survive, wet-black below. Sound: the game's quietest level — water displacement, breath, stone echo; **no music through the entire gauntlet**, and none under the R4 reveal (canon: "the room is silent except for water").
- **Layout notes for level design:**
  - **Gauntlet structure — the exam the whole curriculum built to:** three-to-four chambers in sequence, each keyed to a Vestry cipher mode the player has already learned, in teaching order: (1) hymn-number cipher (from A2-S10), (2) dedication/plaque cipher (from A2-S10/A3-S06), (3) **ledger-stone** navigation — reading the floor itself to find the true path/stone (new combination of known grammar, not new grammar), (4) the **twin lock**: Voss's watch-fob key (C-23) + the Verger's remembered word/sequence — the two exiles' halves united (thematically load-bearing; require both inputs in one interaction: the player carries the key, the Verger speaks his half).
  - **Water as puzzle texture, not hazard:** chest-deep wading, air-pocket ceilings in one connecting passage (breath-hold traverse, generous), no timer, no enemies, no fail-deaths — tension by atmosphere and irreversibility of tone, not mechanics.
  - **The strongroom:** the Concordance case's hide (recess beneath a founder's ledger-stone), the reading ledge where the R4 documents are staged: the cipher-minutes 1877–1974, the Covenant vote, the 1988 certificate with annotation, and the **archive-heist choreography memo** (C-17 payoff) — a document-examination sequence with the A2-S07 flashback-still stitch (see LOC-archive-annex).
  - Entry via the crypt stair from LOC-st-albans (opened for A4-S02); exit the same way — the return climb, carrying what he now knows, should be staged slower (walk-speed override; let it weigh).
- **Used in scenes:** A4-S02.
- **State changes:** Single playable visit. **Drained state** appears in the A4-S10 epilogue montage (registered under LOC-st-albans *(sec)*): pumps out the water, the ledger-stones drying in lamplight, the Verger sweeping — the ledger finally open to the air.

<a id="loc-voss-house"></a>
### LOC-voss-house — The Voss house

- **ID / Name:** LOC-voss-house — The Voss house
- **Description:** The dye dynasty's mausoleum-house on Cathedral Hill: a pile of Victorian money in which exactly one room is still alive. Shrouded furniture down dark enfilades, ancestors in oils (Aldous among them), a conservatory gone to glass-roofed dusk — and at the corridor's end, the sickroom: oxygen hiss, a nurse paid to be deaf, and Konstantin Voss, 81, dying of the dye-worker's cancer his family gave Lowmarsh (C-32), asking for the fugitive. He half-confesses in Vestry idiom — *"ask the window what the rain paid for"* (C-23) — presses the watch-fob key into Adam's hand, and is dead four days later, ambiguously, forever (RH-05 collapsing). Deathbed gothic, administered.
- **Atmosphere:** One amber lamp in a dead house; dust sheets as pale ghosts in every doorway; the green glint of oxygen tubing; rain on the conservatory glass — the house's only weather sound, remote and mineral. A clock somewhere too far away. Palette: amber, dust-white, oil-portrait browns — and one sanctioned violet relic: a **mauveine swatch under glass** in the corridor's display case (the fortune's founding molecule, museum-labeled — purple as heirloom; T-1856 codex flavor).
- **Layout notes for level design:**
  - **Ingress (scripted, quiet):** service door → servants' stair → the enfilade corridor (dust-sheet gauntlet — pure atmosphere traversal, one nurse-avoidance beat played social, not systemic: she is paid to be deaf, and the level should let the player slowly realize she *knows* he's there).
  - **The sickroom:** bed, oxygen rig, a window onto the drive (headlight-sweep source), a chair placed for a visitor who never comes — the two-hander staging. The **watch-fob key handoff** is the scene's close-quarters hero interaction (the prop travels to A3-S14's strongbox and A4-S02's twin lock — persistent inventory item with its own examine model).
  - **Egress (the garden run):** Aegis headlights sweep the drive mid-scene-end — exit through the conservatory into the walled garden: espaliers, an iron gate, light-sweep timing beats (two sweeps, one hold), out onto the Hill's dark lanes. Tension tuned brief and survivable — the scene's dread is upstairs, not in the hedges.
  - Examinable texture (optional): the portrait line (Aldous → Konstantin — the dynasty aging into its disease), the mauveine case, a family photo with one figure scratched out at the edge? — no: keep Lena's estrangement verbal-only (canon gives no such prop; do not invent contradictions).
- **Used in scenes:** A3-S05.
- **State changes:** Single visit. Four days later the house appears only as a news image (hearse lights on the drive — dressing for A3's TV drip). The family archive strongbox the key opens is **not** here — it surfaces with Lena at the Lantern (A3-S14); resist the urge to stage a return burglary.

---

# REGION 5 — CONSPIRACY SPACES: THE DEAL'S TERRITORY

*Where Meridian Ascension lives: the Trust's glass, the ceremony's temple, Aegis's vault, the exits the principals keep. Design brief: glittering, dry, and controlled — these are the only spaces in the game that believe they own the weather. Purple appears here as branding: the conspiracy's vanity color, always behind glass, until A4-S07 shames it with the real thing.*

<a id="loc-meridian-trust"></a>
### LOC-meridian-trust — Meridian Trust tower

- **ID / Name:** LOC-meridian-trust — Meridian Trust tower
- **Description:** Kessler's domain: a Glasswater tower whose double-height lobby and mezzanine host the Renewal's victory-lap gala — champagne, string quartet, civic-purple Ascension branding on every banner — above which sits the private floor: deal rooms, the escrow archive, and the two documents that invert the game (the **indemnity annex** and the **escrow schedule** with its three remediation contractors and its $3.1M/yr Larkspur line — C-22, C-34). The social-stealth setpiece (A3-S03): a man whose face is on every screen hiding in plain sight among people who only ever looked at his mugshot — and the champagne-table scene the whole act is remembered for, where Kessler recognizes him and *talks*.
- **Atmosphere:** Champagne gold and glass; rain sheeting the curtain wall in silence (triple glazing — the storm as decoration); the quartet ducking under crowd wash. The Ascension branding supplies saturated civic violet — dry, backlit, trademarked: the conspiracy wearing the city's wound as a logo. Private floor: task-lit hush, file-room neutrality — the scariest room in the game is beige (administrative horror doctrine). Kessler ascendant in grey against the gold.
- **Layout notes for level design:**
  - **Vertical structure:** lobby (credential check — Nine's forged invitation, an interaction with a held breath) → gala mezzanine (the social-stealth playfield) → service core (staff corridors, the stealth lanes — jacket swap opportunity per Kray's rag-trade suit setup) → private floor (keycard gates, the escrow room, Kessler's suite) → service dock exfil.
  - **Social-stealth systems:** suspicion by proximity-and-dwell (guests who look too long), waiter-tray cover routes, conversation circles as mobile concealment; two named threats — a Trust security chief working the room, and the wall of rolling news (his own face on the lobby screens as ambient hazard: stand near a screen too long and gazes triangulate).
  - **The champagne-table scene:** scripted island mid-level — Kessler catches him, security is *not* called, two minutes of everything true and nothing helpful ("You're looking for the man who decided. Keep looking. There hasn't been one since before I was born."). Design: the player keeps dialogue camera but loses movement; the room keeps moving around them — the conversation is a cage made of poise. Her calculus is canon: she lets him leave.
  - **The theft:** escrow room document work — two objectives (annex; schedule), each a brief examine-and-photograph loop; the Larkspur budget line must be player-readable (C-34's plant is visual, here, in the player's own hands).
  - **Exit under the leak-clock:** Aegis response arrives *too fast* (Nine-brokered job — C-21 tick); exfil via service dock with a tightening cordon — tension from compression, not combat. Rook's anomalous pre-mission warning ("Gala's too hot. Abort," C-29) should be surfaced in the mission brief UI so its ambiguity is on the record.
- **Used in scenes:** A3-S03.
- **State changes:** Single visit. (A4-S09's fallout montage may reuse the lobby for asset-seizure dressing — optional, non-registry.)

<a id="loc-ascension-plaza"></a>
### LOC-ascension-plaza — Ascension Plaza & the Waterworks Cathedral

- **ID / Name:** LOC-ascension-plaza — Ascension Plaza & the Waterworks Cathedral
- **Description:** The renovated old pump station made a secular temple — the Vestry's aesthetic self-portrait, purchased with public money: retained flywheels as sculpture, a nave of polished turbine housings under a new glass roof, and before it the plaza — showcase fountain (maintained, the escrow schedule says, by Larkspur Facility Services), sampling pavilion, broadcast dais, crowd pens, camera cranes. The finale's stage: the livestreamed ratification vote as Vesper hits (A4-S05), and THE SCENE (A4-S07) — the first-draw glass filling faint violet, the fountain erupting lavender, Lowmarsh's floodwater running purple downhill into the plaza around the stage, the sky over Meridian testifying on a million phones.
- **Atmosphere:** Broadcast white and civic-purple bunting against a blackening storm sky — the game's largest lighting contrast held in one frame. Vesper builds through A4-S05 from theatrical (rain the ceremony *planned for*) to biblical. Sound: PA reverb, crowd, rotor and rain — then, at the turn, one beat of **pure broadcast silence** (canon) before the fountain erupts. Palette scripting is the scene: the bunting's *fake* purple must be visibly shamed by the arriving *real* violet — grade the two purples apart (branding lilac vs living leachate-violet) so the eye reads the difference before any line says it.
- **Layout notes for level design:**
  - **Hydraulic theater — the space is plumbing:** every water element must have legible flow logic, because Adam's re-route (LOC-nightingale-hall, A4-S06) arrives here as *cause and effect the player authored*: (1) the ceremonial **first-draw main** feeding the dais tap and glass; (2) the **fountain loop** (Larkspur's showpiece — C-34's referent made monumental); (3) the **storm-drain gutter mouths** at the plaza's uphill edge, where Lowmarsh's grade delivers the purple flood downhill *into* the plaza and around the stage. Build the gutter geometry to sheet water photogenically around the dais risers.
  - **Stations for the cross-cut (A4-S05):** sampling pavilion (Whitlock + Dr. Chen — sealed-duplicate kit as hero props; credentials checked in a beat that must land as Nine's masterpiece), the dais (Deane, Hale rereading his own doubts, Kessler in grey), press risers, service perimeter checkpoints (the forged-credential entry route for Adam's people), and camera positions that will carry A4-S07 (the scene is *shot as broadcast* — build real broadcast coverage: jib, dais lock-off, drone; the player watches the payoff substantially through the world's own cameras).
  - **Playable footprint:** A4-S05 is Mixed — Adam and Lena traverse the service undercroft beneath the plaza (descent toward the Nightingale, water violet at the seams) while the surface stations set; the plaza surface itself is primarily authored/cutscene space with brief playable insertion beats at the perimeter.
  - **A4-S07 staging:** cutscene; no player traversal. The location performs: glass → fountain → streets → sky, in that order, escalating scale — do not reorder (the reveal ladder in water). Chen's on-camera draw-seal-state is the legal hinge; stage her station center-frame with the storm behind.
  - Crowd tech: the finale needs the game's largest crowd budget; pen geometry should allow the purple flood to part and pool around *feet* — the testimony arrives at ankle height first.
- **Used in scenes:** A4-S05, A4-S07; *(sec uses within these scenes: LOC-undercroft staging, LOC-nightingale-hall descent, LOC-lowmarsh streets running purple — see those entries).*
- **State changes:**
  - **A4-S05:** ceremony rising — bunting taut, fountain performing, storm building; the machine's confidence at maximum.
  - **A4-S07:** the same space re-colored by truth — violet in the glass, the fountain, the gutters, the rain; bunting sodden; the crowd's phones as a lighting layer (a thousand small screens filming the sky). End-state: Kessler straightening her jacket amid the flood, making calls.

<a id="loc-aegis-vault"></a>
### LOC-aegis-vault — Aegis contingency vault

- **ID / Name:** LOC-aegis-vault — Aegis contingency vault
- **Description:** Aegis Meridian's secure archive: badge airlock, white corridors, caged rows of the firm's institutional "insurance" — and in a numbered drawer, the Vestry's succession-and-containment dossier: post-vote cleanup protocols and the designated next author-of-all-crimes, **MARR, S.** (C-31). The target of Nine's triple-cross masterpiece (A4-S03) — an extraction that happens **off-screen** per canon: the player experiences the vault at one remove, and the scene's temperature comes from what the documents say, not how they were taken.
- **Atmosphere:** The anti-Undercroft: white light, dry air, silence by specification. The only rain-proof, purple-proof room in the game — sterile by doctrine (this is where the conspiracy keeps its *own* truth, and it keeps it colorless). Sound: HVAC, card-reader chirps, drawer glide.
- **Layout notes for level design:**
  - **Build minimally — this is a presentation set, not a level:** one corridor, the airlock, one cage row, the dossier drawer. Coverage for a cutscene/feed treatment (suggested: fragments — Nine's terse comms audio, still frames, a hand in a drawer — intercut with Adam waiting at the Lantern; the design keeps Adam player-locked per the game's perspective rules and keeps Nine's craft legendary by ellipsis).
  - Hero prop: the **dossier folder** (tabbed: protocols; the MARR, S. designation page player-readable at the Lantern in A4-S03's document interaction — the reading happens at LOC-lantern, the vault only supplies the provenance imagery).
  - Do not expand into a playable heist; canon marks the extraction off-screen, and the R5 arming beat is a *reading* scene. (If production later wants a playable Nine interlude, that is a canon change — route it through STORY.md first.)
- **Used in scenes:** *(sec)* A4-S03 (extraction off-screen).
- **State changes:** Single (mediated) appearance; none.

<a id="loc-airfield"></a>
### LOC-airfield — The airfield

- **ID / Name:** LOC-airfield — The airfield
- **Description:** A private airstrip outside the city: rain-swept tarmac, one business jet with its stairs down and its engines already spooling, black cars arriving faster than the jet can leave. The fallout's punctuation mark (A4-S09): Vivian Kessler arrested at the foot of the stairs — composed, lawyered, immaculate — delivering her exit line to the arresting party: "You've mistaken me for the author. I'm only the accountant."
- **Atmosphere:** Flat horizontal light under a scoured post-Vesper sky; light rain on tarmac reads as a silver field; strobes (aircraft and police) as the only color. No purple — Kessler never wore the vanity, and her arrest shouldn't either. Sound: engine whine cycling down (the escape dying audibly), car doors, rain on wing surfaces.
- **Layout notes for level design:**
  - Cutscene micro-set: tarmac line, the jet with stairs (hero staging point), hangar mouth for depth, perimeter fence and gate for the convoy's entrance. Runway-length lens compression is the shot grammar — build for a long lens, not traversal.
  - One dressing requirement: her single piece of luggage, already aboard, visible through the cabin door — she was *leaving*, and the frame should prove it without a line.
- **Used in scenes:** *(sec)* A4-S09.
- **State changes:** Single beat; none.

<a id="loc-cordell-cabin"></a>
### LOC-cordell-cabin — Cordell's lake cabin

- **ID / Name:** LOC-cordell-cabin — Cordell's lake cabin
- **Description:** The mentor's retreat, an hour beyond the city's weather: timber cabin, deep porch, a dock over still grey water, one room holding a stove, two chairs, whiskey, and a chessboard worn smooth — the twin of the rooftop board from A0-S05, which is the point. The stage of "One Last Game" (A3-S13): two liars performing two old men's rituals perfectly; the offer of a door; Adam castling late and saying nothing; both men knowing, and the hunt turning honest. The script protects this scene above all others — the set must be built to hold six pages of subtext with no mechanics to hide behind.
- **Atmosphere:** Grey lake, green-black pines, woodsmoke; rain here is soft and *clean* — and there is **no violet anywhere**: the one location fully outside the city's stain, because Cordell built his life to be elsewhere from its consequence (the absence is the art direction). Interior: stove-side amber, the same warm key as the Lantern — deliberately: both men built shelters; only one of them lets people in. Sound: rain on shingles, lake lap, stove tick, chess pieces on wood — the Foley carries the scene.
- **Layout notes for level design:**
  - **The approach (player-controlled, long):** a walk from the road down through pines to the cabin — unhurried by design (no sprint; dread by pacing), the cabin revealed across the water first, then the porch, then Cordell waiting. This walk is the scene's overture; do not shorten it.
  - **The interior two-hander:** chairs and board between; camera favors hands, glasses, and the board's clock-less clock. Interaction design: the game of chess is the dialogue vehicle — key beats are *player inputs on the board*, and the scene's only weapon is one of them: **the player must physically make the late castle** (the input offered at the habitual early moment, declinable; the scene tracks whether the player castles early — Cordell's habit — or late — Adam's message; late is canonical and the dialogue seals around it).
  - **The dock coda:** after Adam leaves, one held exterior shot — Cordell alone clearing the pieces, hand not quite steady (canon). Non-interactive; the player's last image of the mentor before the endgame.
  - No stealth, no combat, no evidence loop. One examinable: the notebook-brand box on the shelf — the same brand as forty-two gifts (optional gut-punch; consistent with C-05).
- **Used in scenes:** A3-S13.
- **State changes:** Single visit. (A4-S08 deliberately does *not* return here — the last confrontation happens where the First Lie lives, not where the liar vacations.)

---

# REGION 6 — MARGINS: SPACES OF LOSS AND RECKONING

*The rooms the story grieves in and the arenas where the price is paid: the crank's fortress, the staged squat, the wet grave, the flooded yard. Design brief: these are small sets with enormous loads — build them prop-perfect and light them honestly. The rain here is mostly indifferent (canon's word), which is its own register.*

<a id="loc-duval-flat"></a>
### LOC-duval-flat — Duval's flat

- **ID / Name:** LOC-duval-flat — Duval's flat
- **Description:** Locked-down rooms above a shuttered print shop — ghost signage on the brick, three locks and a chain on the door, blackout curtains, a police scanner muttering, archive boxes as furniture, a kettle burned dry. And the crazy wall: red string over six years of exile, 60% noise, 40% dead accurate — including Coby Anders' drowning, the 2020 spiked story, and the circled phrase that names the game's method: *"They don't kill stories. They kill authors."* (C-16). Alliance forged here in shared shrapnel (A2-S05); the same room, twenty weeks later, hosts her second ruin (A3-S07: "I handed them the match").
- **Atmosphere:** One desk lamp against blacked-out day; newsprint grey, string red; dust in the lamp cone. The scanner and the fridge hum are the room's pulse. Palette note: violet appears only as her marker-ink circles on the wall — she has been circling purple for six years and calling it a hunch. A3-S07 state: the lamp on the floor, the light wrong on purpose.
- **Layout notes for level design:**
  - **Entry ritual:** street door beside the shuttered shopfront → stair → the lock sequence (three locks and a chain, played as an interaction beat both visits — first as her paranoia, later as her broken habit: in A3-S07 the door is *unlocked*, and returning players should feel the wrongness before the room shows it).
  - **The wall (A2-S05):** an interactive document surface — free examination with signal items examinable in any order (Anders photo; the 2020 story; the circled phrase; the data-table fragment Adam *recognizes as his own study* — the scene's turn, staged as a player examine that Adam then reacts to). Noise items get real content (fair-play: the wall's 60% noise must be genuinely noisy, not blank).
  - Secondary spaces: kitchenette (kettle, the tea she makes when the alliance forms — domestic beat), back window to fire escape (the paranoiac's audited exit; established A2-S05, unused — its existence is characterization).
  - **A3-S07 re-dress:** the debunk playing on a laptop loop; printouts of the mockery; sections of the wall torn down or red-stamped; Duval on the floor among her life's second ruin — blocking low, camera low. The C-25 memo's printout should be findable in the wreckage with her annotation: "it was too good; God, it was too good."
- **Used in scenes:** A2-S05, A3-S07.
- **State changes:**
  - **A2-S05:** fortress-archive — obsessive order inside paranoia; the wall alive.
  - **A3-S07:** the crime scene of her own hope — locks open, wall wounded, lamp on the floor; the same geometry grieving.
  - *(Epilogue, off-set: her prize and her teaching are montage beats under LOC-meridian-streets — this room is not revisited; she gets out of it, which is the arc.)*

<a id="loc-squat"></a>
### LOC-squat — The squat

- **ID / Name:** LOC-squat — The squat
- **Description:** A derelict room arranged to look *supervised* — a cot, a hotplate, a blanket folded once, and Theo dead with a needle in his arm. Staged overdose; the city shrugs: junkie brother of a fraud. The room is a lie built by professionals, and the scene (A3-S08) is the game's saddest investigation: Adam reads it as murder in one breath — *Theo fainted at needles* (C-26 payoff, the A0-S06 joke detonating six acts later) — and the player is given the tools to read everything else the staging got almost right.
- **Atmosphere:** Sodium light striping through a boarded window; rain through a broken gutter, steady, indifferent (canon's word — the weather does not mourn); the hotplate's element dead. Palette: grey-brown dereliction, one wrong cleanliness (the staging's tell — the room is *too* composed for its own story). No violet; no music until Adam stops reading and starts kneeling.
- **Layout notes for level design:**
  - **Single room + stair approach;** the approach is played slow (word arrived off-screen; the climb is the player assembling dread).
  - **The scene-reading loop (the level *is* the puzzle):** an examine-driven "wrongness checklist" the player assembles, e.g.: the needle and Theo's known terror of them (C-26 — the anchor tell, auto-noted by Adam); the arm chosen (details staged by someone who didn't know him); no works anywhere else in the room (a habit with no history); the tape recorder **absent** — his taped confession gone (the reason for the murder, present as negative space); door forced from outside then relocked. Design rule per canon: the murder is *legible only to family* — surface forensics genuinely pass; every tell requires knowledge the player earned in Acts 0–II.
  - No verbs beyond examine and one final interaction (covering him / closing his eyes — a single tenderness input; let the player perform it rather than watch it).
  - Camera: low, close, patient; hold the boarded-window light stripe across the cot as the master frame.
- **Used in scenes:** A3-S08.
- **State changes:** Single visit. The room's afterlife is testimonial: its staging details return as evidence exhibits at A4-S09 (Marr-archive cleanup records corroborating the read) — capture the checklist tells as stills for that montage.

<a id="loc-cemetery"></a>
### LOC-cemetery — The cemetery (Theo's grave)

- **ID / Name:** LOC-cemetery — The cemetery (Theo's grave)
- **Description:** A wet municipal burial ground: leaning stones, mown grass gone to sponge, a treeline of dark yews, a gravediggers' shed, an iron gate with a chalkable pillar. Theo's grave is the story's fixed point of grief and, in sequence, its most trafficked dead-drop: the funeral where Marr delivers his creed graveside and Mara leaves her clinic pin on the headstone (A3-S09); the gate where her chalked clinic symbol opens a channel (A3-S15 *(sec)*); and the place Adam finally brings the dismissed-charges order and reads it aloud, once, quietly, leaving it under a stone (A4-S09) — paper doing the only job it was ever good for: witness, not weapon.
- **Atmosphere:** Green-grey under wet daylight; black umbrellas; cold, sorrowful register — rain soft to steady across its uses, warm never. The single point of saturated color across all three beats is **the clinic pin's brass glint** on the headstone — build the material so it reads at distance. Sound: rain on umbrella skins, shovel-and-tarp Foley, distant traffic; A4-S09 adds nothing but page-turn and light rain.
- **Layout notes for level design:**
  - **Sightline triangle (A3-S09):** the grave ↔ the treeline (Marr's approach — he appears *beside* Adam at the treeline; blocking: two men at parallel distance from the grave, neither facing the other) ↔ Mara across the grave (she never looks at Adam). All three stations must hold one another in coverage.
  - **Adam's cover:** the gravedigger crew (tarp, shovels, a barrow — the disguise-in-plain-sight staging; Marr *lets* him attend, which the blocking must communicate: the hunter's glance that lands and moves on).
  - **The headstone:** examine prop with two states — the pin left (A3-S09; examinable: *she'd never part with it idly* — RH-03 debunk begins), and the order left under a stone (A4-S09 end-state).
  - **The gate pillar (A3-S15 *(sec)*):** the chalked clinic symbol — a small examine that opens the night-ward meeting; teach the player the symbol's shape at A3-S09 (the pin's clinic emblem) so recognition is theirs, not the UI's.
  - No stealth systems; social tension only. Keep the set small enough that all three visits share one master layout — the repetition is the meaning.
- **Used in scenes:** A3-S09; *(sec)* A3-S15 (gate signal), A4-S09 (the reading).
- **State changes:**
  - **A3-S09 (Week 21+3d):** fresh grave, funeral dressing, the pin newly placed.
  - **A3-S15 *(sec)*:** the gate at night — chalk symbol; the grave settled, flowers gone.
  - **A4-S09 (Days V+1…V+10):** light rain; a modest permanent stone now set (time has passed); the order left beneath a pebble on its shoulder — the game's quietest ending beat before the epilogue.

<a id="loc-transit-yard"></a>
### LOC-transit-yard — The transit yard

- **ID / Name:** LOC-transit-yard — The transit yard
- **Description:** A rain-flooded rail and transit yard on the river margin: dead rolling stock in silent ranks, signal gantries against sodium tower-light, ballast underwater, hazard signage half-drowned. The arena of "Rage" (A3-S10): Adam hunts Lt. Dane Krebs — Theo's killer — through the flood and corners him, and the game opens its formal morality valve: **kill him / flip him / walk away**. Canonically Adam hears his own creed come back in Cordell's voice and takes evidence over blood: Krebs's phone and geotagged Aegis field notes (C-21 payoff — the interception pattern made undeniable).
- **Atmosphere:** The city's harshest light: sodium towers in hard rain over black standing water — orange and black, nothing else. **No violet** (motif rule: purple belongs to the truth and to the crime, never to Adam's fury — revenge gets no title color). Sound: rain on steel roofs like drumfire, water displacement in the sprint, one loose signal cable slapping a mast — the yard plays percussion under the chase.
- **Layout notes for level design:**
  - **Two-phase arena:** (1) **the hunt** — pursuit lanes between carriage ranks (parallel alleys with cut-throughs via open rolling stock), gantry verticality (Krebs runs high across a signal bridge; the player can mirror or flank below), floodwater as the shared cost (both movers slowed — tension from symmetric physics, not rubber-banding); (2) **the corner** — a dead-end pocket between a derailed carriage and deep water: no exit for Krebs, no audience, the valve.
  - **Valve staging:** all three choices playable from identical blocking (series rule — see LOC-seal-chamber): *kill* (priced honestly, per the game's design values — consequence carried by characters and epilogue text, no meter), *flip* (Krebs talks — an interrogation beat yielding the same evidence plus a human stain), *walk away* (the phone and notes are recoverable from his dropped jacket regardless — canon requires C-21's payoff on every path; design the evidence acquisition path-independent).
  - **Loot/evidence:** Krebs's phone (geotagged field notes — the journal's correlation view lights up on pickup: every interception, only Nine-brokered jobs).
  - Hazard theater: third-rail and catenary warnings dressed prominently, *dead* (the yard is flooded and unpowered) — dread without instant-kill gotchas.
- **Used in scenes:** A3-S10.
- **State changes:** Single visit. The yard's aftermath is carried by people, not the place: the choice made here is remembered in dialogue (A3-S11 onward) and epilogue shading, per the no-meter morality design.

---

## Appendix A — Revisit matrix (locations with state ladders)

| Location | Visits | State ladder |
|----------|--------|--------------|
| LOC-vale-rowhouse | 7 beats | warm → drawer → raid → siege → the table → night/go-bag → abandoned (never revisited) |
| LOC-waterworks | 5 beats | mundane-confident ×4 → epilogue field office |
| LOC-lowmarsh | 3 | wistful morning → pre-dawn hunt → purple flood |
| LOC-marsh-gate | 2 | omen (paint) → threshold (descent) |
| LOC-meridian-streets | 2 | intact ordinary city → epilogue begun-not-restored |
| LOC-st-brigids | 3 | window unread (ext.) → window decoded → night ward |
| LOC-courthouse | 5 beats | machine-confident → proffer → steps/scrum → parallel investigation → fallout (steps re-rhymed, minus Adam) |
| LOC-undercroft | 11 beats | terror → refuge → home → bounty-hostile → allied → Vesper surge |
| LOC-lantern | 15 beats | riddle door → orientation → evidence board → wariness → war room → despair → prep → eve → legal Lantern |
| LOC-forge-shop | 2 | unmasking → redemption shift |
| LOC-nightingale-hall | 4 | running-hidden → labored descent → storm-load screaming → remediation |
| LOC-st-albans | 4 | confessional dark → war council edge → eve on the steps → drained & swept |
| LOC-duval-flat | 2 | fortress-archive → ruin |
| LOC-cemetery | 3 | funeral/pin → gate signal → the reading |
| LOC-ascension-plaza | 2 | ceremony rising → the water testifies |
| LOC-vestry-row | 2 | sovereign silence → sealed in evidence |

Single-visit sets (build once, load-bearing): LOC-lowmarsh-restaurant, LOC-betting-cafe, LOC-archive-annex, LOC-depot, LOC-ag-office, LOC-seal-chamber, LOC-vestry-crypt (drained state renders under LOC-st-albans), LOC-voss-house, LOC-meridian-trust, LOC-aegis-vault (mediated), LOC-airfield, LOC-cordell-cabin, LOC-squat, LOC-transit-yard.

## Appendix B — Registry notes & flagged gaps

1. **Unnamed surface church (A3-S12).** The canary trap's third meet — "Aegis hits the church only ROOK9 knew" — has **no LOC ID** in the registry (registry lists A3-S12 as `LOC-lantern (sec: unnamed surface church, meet sites)`). Treated here as a cutscene exterior under LOC-undercroft's meet-site variants. If Phase 2 quest design makes it traversable, register a new `LOC-*` ID first.
2. **The epilogue's new house / coffee shop (A4-S10).** Adam's new house and the Mara coffee beat have no LOC IDs; the registry folds A4-S10 into `LOC-meridian-streets (citywide montage)`. Handled as montage dressing under that entry. Register IDs only if they become playable sets.
3. **LOC-vestry-crypt drained state (A4-S10).** The registry credits the epilogue crypt beat to `LOC-st-albans (sec)`; this document keeps that attribution and cross-references it from the crypt entry.
4. **LOC-aegis-vault** is canonically off-screen (extraction, A4-S03); this document deliberately specs it as a presentation set, not a level. Expanding it to playable would be a canon change (STORY.md A4-S03).
5. **No other gaps found:** all 30 registry `LOC-*` IDs are covered above; all scene lists match the registry verbatim; no new location, character, or scene IDs were coined.

---

*End of LOCATIONS.md v1.0. Locations: 30 (Region 1: 8 · Region 2: 4 · Region 3: 5 · Region 4: 4 · Region 5: 5 · Region 6: 4). Any Phase 2+ level, quest, or scene work that adds, moves, or re-dresses a location must update this document, the registry, and — if clue staging is affected — MYSTERY_LOGIC.md.*
